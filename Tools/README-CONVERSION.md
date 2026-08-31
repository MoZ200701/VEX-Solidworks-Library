# Converting the STEP library to SolidWorks parts

You have two ways to do this. **Task Scheduler is easier if you have it**;
the macro works on every SolidWorks edition.

Before either one, set the import options below — they make a large
difference to both speed and to what you end up with.

---

## Step 1 — Set the STEP import options (do this first)

In SolidWorks: **Tools > Options > System Options > Import**, choose
**STEP/IGES/ACIS...** as the file format, then:

| Setting | Set it to | Why |
|---|---|---|
| Import as | **Solid/Surface bodies** | The alternative runs feature recognition on every file, which is enormously slower and, on imported geometry, usually produces a worse tree than no tree at all. |
| Enable surface/solid entity import | **checked** | This is what actually brings the geometry in. |
| Perform full entity check and repair errors | **unchecked** | Roughly doubles import time. VEX's STEP exports are clean; turn it on later only for a specific part that misbehaves. |
| Import multiple bodies as parts | **unchecked** | Keeps each VEX part as one file. With this checked, a multi-body part such as a motor explodes into an assembly plus a pile of loose part files. |
| Map configuration data | **unchecked** | Nothing in these files uses it. |

If **FeatureWorks** is installed, also make sure it is not set to run
automatically on import (**Tools > Options > FeatureWorks**, or dismiss its
prompt on the first file). Automatic feature recognition on ~350 imported
parts will take hours and is not worth it.

---

## Step 2a — SolidWorks Task Scheduler (Professional / Premium only)

1. Start menu > **SOLIDWORKS Tools 2026 > SOLIDWORKS Task Scheduler**
2. Click **Convert Files** in the left pane.
3. **Add Folder...** → select `VEX-STEP-2026`, and tick **Include subfolders**.
4. Set the output folder to `VEX-SLDPRT-2026`.
5. Under file type, choose **SOLIDWORKS Part (*.sldprt)**.
6. Set it to run **Now**, then **Finish**.

Task Scheduler runs SolidWorks in the background and will happily chew
through the whole tree unattended. It does not perfectly mirror the
subfolder structure in every version — if it flattens the output, use the
macro instead.

## Step 2b — The macro (any edition)

1. Open SolidWorks.
2. **Tools > Macro > New...**, save it as `ConvertStepToSldprt.swp`
   (anywhere convenient).
3. The macro editor opens. Delete the stub code in the module and paste in
   the entire contents of `ConvertStepToSldprt.swp.bas` from this folder.
4. Check the two paths at the top of the file:

   ```vba
   Const SRC_ROOT As String = "C:\Users\M0obo\Desktop\VEX-CAD-Solidworks-1.1.1\VEX-STEP-2026"
   Const OUT_ROOT As String = "C:\Users\M0obo\Desktop\VEX-CAD-Solidworks-1.1.1\VEX-SLDPRT-2026"
   ```

   They are already set for where the library currently lives. If you move
   the folder, update them.
5. Press **F5**.

### What to expect

- It mirrors the `VEX-STEP-2026` folder structure into `VEX-SLDPRT-2026`.
- **It is resumable.** Anything already converted is skipped, so you can
  stop it with Esc and re-run later. Nothing is redone.
- A running log is written to `VEX-SLDPRT-2026\_conversion-log.txt`, with an
  `OK` / `FAIL` / `SAVEFAIL` line per file.
- Plan for this to take a while and leave the machine alone while it runs.
  Most parts convert in a second or two, but the large electronics files
  (the V5 Smart Motor STEP alone is 16 MB) can take minutes each.
- A file that fails is logged and skipped rather than stopping the run.
  Open any stragglers by hand afterwards.

---

## What you get, and what you don't

Converted parts are **dumb solids**. This is a property of STEP itself, not
of the conversion:

- no feature tree, no sketches, nothing to edit parametrically
- **no configurations** — this is the one that matters most here. In the
  original 1.1.1 library a C-channel is *one* file whose length you pick
  from a configuration list. In STEP, every length is a separate fixed file.
- no mate references, no custom appearances

That is exactly why the original `.SLDPRT` library in the top level of this
folder was left untouched. For any part that exists in both places, **use
the original** — it is genuinely nicer to CAD with. Reach for the converted
parts for things the old library never had.

---

## Notes from automating this (findings, SOLIDWORKS 2026 SP1.1)

The conversion in `VEX-SLDPRT-2026/` was produced by `SwConvert.exe` in this
folder. These are the things that actually mattered.

**Use `LoadFile4`, not `OpenDoc6`.** This is the one that counts. On these
VEX STEP files `OpenDoc6` fails with error **2097152**
(`swFileRequiresRepairError`) for every combination of open options, and it
still fails after disabling import diagnostics and full entity check
(`swImportAutoRunImportDiagnostics`, `swImportNeutralRunDiagnostics`,
`swForceEnableImportDiagnosis`, `swImportCheckAndRepair`). `LoadFile4` with
an argument string of `"r"` imports the same files with `err = 0`. The VBA
macro here was corrected to match.

`OpenDoc7` is not an alternative: it rejects neutral formats outright.
`GetOpenDocSpec` on a `.step` returns `DocumentType = -1` and
`spec.Error = 1024` (`swInvalidFileTypeError`). Renaming to `.stp` changes
nothing.

**To decode an error number, reflect over the interop enum** rather than
guessing:

```powershell
[void][Reflection.Assembly]::LoadFrom("$SWDIR\SolidWorks.Interop.swconst.dll")
[Enum]::GetNames([SolidWorks.Interop.swconst.swFileLoadError_e])
```

**Late-bound scripting hosts cannot call these APIs at all.** `OpenDoc6` and
`LoadFile4` take `ByRef Long` out-parameters. VBScript and PowerShell are
late-bound, cannot produce `VT_BYREF|VT_I4`, and fail with "Type mismatch"
*before the method runs*. Compiled C# against the interop assemblies is
early-bound and marshals correctly — that is why `SwConvert.exe` works and a
`.vbs` or `.ps1` cannot. VBA works for the same reason, in-process.

**The generic COM ProgID points at the wrong SolidWorks.** This machine has
2026 and 2024. `SldWorks.Application` and `SldWorks.Application.32` resolve
to the *same* CLSID — 2024. Use `SldWorks.Application.34` for 2026.

**Never start SolidWorks via COM for batch work.** A COM-created instance
starts hidden, and any modal dialog then blocks every API call forever with
nothing visible to dismiss — the process sits at ~400 MB, "Responding",
doing nothing. Start `SLDWORKS.exe` normally, let it load, then attach with
`Marshal.GetActiveObject`. The converter also needs `[STAThread]`;
SolidWorks is an STA server and calling from an MTA thread deadlocks.

**Watch the save prompt on library files.** Opening a v1.1.1 `.SLDPRT` in
2026 marks it modified (version upgrade), so closing prompts *"Save changes
to ...?"* under a **"SOLIDWORKS CAM Warning"** title. Answering **Yes
rewrites that file in 2026 format**. Always answer **No** for anything in
the original six folders. `CloseAllDocuments` raises this prompt; `CloseDoc`
discards silently, which is what the converter uses.

## Re-running the conversion

```
Tools\SwConvert.exe <stepFolder> <outFolder> <logFile>
```

SolidWorks must already be running. It is resumable — anything already
converted is skipped — and logs one line per file. Source is in
`Tools\src\SwConvert.cs`; rebuild with `csc.exe` referencing the two
`SolidWorks.Interop.*.dll` files kept alongside it.

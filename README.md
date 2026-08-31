|[Discord](https://discord.gg/BKV3DJm)|[BLRS Wiki](https://wiki.purduesigbots.com/vex-cad/solidworks)|[Original Repo](https://github.com/VEX-CAD/VEX-CAD-Solidworks)|[FAQ](https://github.com/VEX-CAD/VEX-CAD-Solidworks/wiki)
|---|---|---|---|

# VEX SolidWorks Library — 1.1.1 + 2026-08-30 catalogue refresh

A fork of the community **VEX-CAD SolidWorks library v1.1.1** (parts as of
2023-02-17), plus a refresh pulled from VEX's own product pages on
**2026-08-30** to cover everything added since.

The upstream project stopped releasing after v1.1.1, so the refresh comes
directly from vexrobotics.com — where VEX publishes a `.step` file for each
part — rather than from a newer library release. There isn't one.

## Layout

```
Electronics/  Hardware/  Motion/       <- ORIGINAL v1.1.1 library, as forked
Pneumatics/   Structure/ Wheels/          (untouched — see note below)

VEX-Library-2026/    the merged, current library — START HERE
Tools/               macros and helpers (source; see Tools/.gitignore)
NEW-PARTS-REPORT.md  what the refresh added, and what it left out
Changelog.txt        history
```

**`VEX-Library-2026/` is the one you want.** It is the v1.1.1 library plus
the 108 parts added since, merged into a single tree, with per-length files
generated for the metals that have them (see below).

The original six folders at the root are byte-for-byte as they shipped.
Nothing was moved, renamed, or replaced — if you have robot assemblies
pointing at these files, their references still resolve.

### Not in this repository

Two intermediates from building the refresh are kept locally but not
committed, because the merged library above supersedes both:

- `VEX-STEP-2026/` — the 108 raw `.step` downloads (~340 MB)
- `VEX-SLDPRT-2026/` — those STEP files converted to `.SLDPRT` (~208 MB)

`Tools/README-CONVERSION.md` covers regenerating them if you want them.

### Which copy of a part should you use?

**Prefer a hand-built v1.1.1 part over an imported STEP one** whenever a part
exists as both. The hand-built library is genuinely better to CAD with:

- metals are **one file with configurations** for every length, instead of
  one fixed file per length
- pneumatic cylinders and switches are configurable assemblies
- proper appearances, and square holes have concentric-mate circles cut in

STEP carries none of that. An imported STEP part is a dumb solid: no feature
tree, no configurations, no mates. That is a limitation of the format, not
of the download.

For this reason the refresh took **only the 108 parts that have no
counterpart in v1.1.1**. The other 181 available STEP parts were left out
as redundant; they are listed in `NEW-PARTS-REPORT.md` if you want any.

## One file per length

The library ships each cut-to-length metal as a single part with one
configuration per hole count — the C-Channels carry `1` through `35`, driven
by a design table. Some workflows want a real file per length instead: a BOM
row per part number, a drag-and-drop parts folder, or an exporter that
ignores configurations.

`Tools/ExplodeConfigsToFiles.swp.bas` writes those out. Every master gets a
folder beside it, holding one single-configuration part per length:

```
Structure/C-Channel/Aluminum 2 Wide C-Channel.SLDPRT      <- master, untouched
Structure/C-Channel/Aluminum 2 Wide C-Channel/
    1 Aluminum 2 Wide C-Channel.SLDPRT
    2 Aluminum 2 Wide C-Channel.SLDPRT
    ...
    35 Aluminum 2 Wide C-Channel.SLDPRT
```

The `<holes> <master name>` naming is the one v1.1.1 already used for the
single file it happened to ship this way, `25 Aluminum 2 Wide C-Channel`.

### Done

| Folder | Masters | Files | Lengths |
|---|---|---|---|
| `Structure/C-Channel` | 5 | 175 | 1–35 holes |
| `Structure/Angle` | 4 | 140 | 1–35 holes |

Every file was checked after writing: its bounding box measures the expected
holes × 0.5 in. Two came back wrong, and the cause is upstream:

> **Known defect inherited from v1.1.1.** Configuration `33` of
> `Aluminum 2x2 Angle` and `Steel 2x2 Angle` is **16.990 in** long in the
> original masters, where 33 holes × 0.5 in is 16.500 in — `32` is 16.000 and
> `34` is 17.000, so only `33` is off. The generated `33 ...` files copy the
> masters exactly and inherit it. This is a bad value in the original design
> table, not an export error. Verify before cutting metal to it.

### Not done yet

Add these to `TargetFolders()` in the macro to generate them:

| Folder | Masters | Files | Note |
|---|---|---|---|
| `Structure/U-Channel` | 1 | 20 | 1–20, not 35 |
| `Structure/Chassis Rail` | 3 | 85 | 25 / 25 / 35 |
| `Structure/Linear Slide` | 1 | 35 | |
| `Structure/Plate` | 2 | 248 | named `5x25`, see below |
| `Structure/0.25in Pitch Structure` | 3 | 360 | `0.25 in` pitch, see below |

Two traps in that list. The plates are configured in **two** dimensions and
named `width x length` in holes (`5x25`), not by a plain hole count — so they
need `MAX_HOLES = 0` in the macro or every one of them is skipped. And the
`0.25in Pitch` parts sit on a **0.25 in hole pitch, not 0.5 in**, so their
configuration `N` is N × 0.25 in long; `30` is 7.5 in, not 15 in.

Nothing outside `Structure/` needs this. Every part in Hardware, Motion,
Wheels and Electronics is already single-configuration.

**The masters are not modified.** For ordinary CAD work prefer them: one file
whose length you change beats 35 files you have to choose between, and an
assembly that uses the master can be re-lengthed without swapping references.

## A note on Git LFS

The repository root tracks `*.SLDPRT` through Git LFS, inherited from
upstream. `VEX-Library-2026/` deliberately **opts out** via its own
`.gitattributes`: those parts are stored as ordinary git blobs. Generating a
file per length produces a few thousand parts, which would blow past a free
LFS quota. Nothing special is needed to clone or use them.

## Refreshing this again later

VEX exposes a per-product CAD archive at:

```
https://www.vexrobotics.com/cadmodels/archive/download/product_id/<id>
```

`Tools/vex-v5-products.tsv` lists every V5 product id, name and SKU, so the
pull can be repeated. Two gotchas worth knowing: the site is behind
Cloudflare and rejects ordinary scripted requests, and it returns a plain
`404` both for "this product has no CAD" and for "you are being rate
limited" — so a single pass silently under-collects and any miss needs a
retry to classify.

## Credits

Original v1.1.1 SolidWorks library by **Owen (169E)** and **Ryan (4253B)**.
STEP files are VEX Robotics'.

NOTE: The original library is not backwards compatible before SolidWorks 2021-2022.

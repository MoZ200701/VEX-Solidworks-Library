VEX SolidWorks Library — merged 2026 edition
============================================================

378 parts: the complete community v1.1.1 library (2023-02-17) plus the
genuinely new parts from the 2026-08-30 refresh of VEX's own STEP downloads.

  323  native v1.1.1 parts   (unchanged, byte for byte)
   55  new 2026 parts        (imported from VEX STEP files)


WHAT WAS LEFT OUT, AND WHY
------------------------------------------------------------

The 2026 refresh offered 108 parts. 53 were dropped here because v1.1.1
already contains the same part in a better form. Two naming mismatches hid
this in the original comparison:

  Fractions vs decimals.  v1.1.1 writes 'Screw 8-32 0.250in'; VEX ships
  '#8-32 x 1-4in Screw'. Same screw, no name match. This alone accounted
  for 6 screws, 4 standoffs, 4 nylon spacers and 3 click-on spacers.

  Configurations vs one-file-per-length.  v1.1.1 stores length variants as
  configurations inside a single file; VEX ships one STEP per length. All 8
  C-channels and all 4 angles in the refresh were already covered.

Where a part exists in both, the v1.1.1 original is the better file: it
carries configurations, mates and appearances. A STEP import cannot.

Caution: exclusions were judged on names and SKUs, not geometry, and a
shared name does not always mean a shared part. Two corrections have already
been made on that basis:

  - the 2in Mecanum V2 wheels are a different design from the older 2in
    Mecanums, not a re-release;
  - the stroke cylinders and the reservoir belong to VEX's V2 pneumatics,
    a generation newer than anything in the v1.1.1 Pneumatics folder.

Anything excluded is still in VEX-SLDPRT-2026/ and can be copied back in.


KNOW WHAT YOU ARE GRABBING
------------------------------------------------------------

The 55 added parts are STEP imports, so they are dumb solids:

  - no feature tree and no configurations
  - no appearances (they render in default grey)
  - material is <not specified>, so mass properties read as zero

The 323 v1.1.1 parts have none of these limitations. Prefer them whenever
both would do.


VERIFY BEFORE YOU TRUST (18 parts)
------------------------------------------------------------

Added because a name match was ambiguous. A similar v1.1.1 part exists, and
this may be a genuine revision or a redundant copy. Compare before relying
on either.

  Hardware       2x Pitch Shaft (228-2500-117)
                   vs v1.1.1: 228- is the VEX IQ range
  Hardware       3x Pitch Shaft (228-2500-119)
                   vs v1.1.1: 228- is the VEX IQ range
  Hardware       4x Pitch Shaft (228-2500-120)
                   vs v1.1.1: 228- is the VEX IQ range
  Hardware       5x Pitch Shaft (228-2500-121)
                   vs v1.1.1: 228- is the VEX IQ range
  Hardware       6x Pitch Shaft (228-2500-122)
                   vs v1.1.1: 228- is the VEX IQ range
  Hardware       7x Pitch Shaft (228-2500-123)
                   vs v1.1.1: 228- is the VEX IQ range
  Hardware       8x Pitch Shaft (228-2500-124)
                   vs v1.1.1: 228- is the VEX IQ range
  Hardware       Drive Shaft Bar Lock (275-1065)
                   vs v1.1.1: Plastic / Titanium Lock Bar
  Hardware       Lead Screw Nut (276-2045-031)
                   vs v1.1.1: Lead Screw Mounting Bracket exists
  Hardware       Teflon Washer (275-1025)
                   vs v1.1.1: 1-16 Nylon Washer (material differs)
  Hardware       U-Joint (276-2045-020)
                   vs v1.1.1: part of Advanced Mechanics kit?
  Hardware       Universal Joints (276-2723)
                   vs v1.1.1: part of Advanced Mechanics kit?
  Motion         24T Bevel Gear (276-2184-001)
                   vs v1.1.1: kit 276-2184; v1.1.1 has 16T + 32T
  Pneumatics     Pneumatic Hand Valve
                   vs v1.1.1: On-Off Switch
  Pneumatics     Pressure Gauge
                   vs v1.1.1: Flow Meter
  Pneumatics     Schrader Valve
                   vs v1.1.1: Tire Pump Fitting
  Pneumatics     Straight Pneumatic Fitting
                   vs v1.1.1: Cylinder Fitting
  Wheels         4in Wheel (High Strength Bore) (276-1497-110)
                   vs v1.1.1: 4in Wheel (bore differs)


CONFIDENTLY NEW (37 parts)
------------------------------------------------------------

No v1.1.1 counterpart. The Star Drive line is the bulk of it — VEX
introduced star drive after the v1.1.1 release.


  [Electronics]
    Battery Extension Cable (276-3442)
    Battery Strap (276-2219)
    Competition Cortex Wire Retaining Clip (276-2173)
    Extension Cable Retaining Clip (276-4128)
    V5 Controller (276-4820)

  [Field]
    VEX Portable Competition Field Perimeter (276-8242)

  [Hardware]
    #6-32 x 1-2in Screw (275-1169)
    #6-32 x 1-4in Screw (275-0659)
    #8-32 x 0.500in Star Drive Coupler (276-4989)
    #8-32 x 1-2in Star Drive Screw (276-4992)
    #8-32 x 1-4in Star Drive Screw (276-4990)
    #8-32 x 1.000in Star Drive Coupler (276-4988)
    #8-32 x 1.000in Star Drive Screw (276-4996)
    #8-32 x 1.250in Star Drive Screw (276-4997)
    #8-32 x 1.500in Star Drive Screw (276-4998)
    #8-32 x 1.750in Star Drive Screw (276-4999)
    #8-32 x 2.000in Star Drive Screw (276-5004)
    #8-32 x 2.250in Star Drive Screw (276-8015)
    #8-32 x 2.500in Star Drive Screw (276-8016)
    #8-32 x 3-4in Star Drive Screw (276-4994)
    #8-32 x 3-8in Star Drive Screw (276-4991)
    #8-32 x 5-8in Star Drive Screw (276-4993)
    #8-32 x 7-8in Star Drive Screw (276-4995)
    Short Shifter Shaft 2.65 Ratio Spread (217-3288)
    Star Drive Shaft Collar (276-6103)

  [Kits and Misc]
    V5 Clawbot (276-6009)

  [Pneumatics]
    25mm Stroke Pneumatic Cylinder
    50mm Stroke Pneumatic Cylinder
    75mm Stroke Pneumatic Cylinder
    Air Pressure Regulator Mounting Bracket
    Elbow Fitting
    Manifold Assembly
    Pneumatic Fitting Plug
    Pneumatic Reservoir Assembly
    Pressure Regulator

  [Wheels]
    2in Mecanum Wheels V2 (Left) (276-9041-801)
    2in Mecanum Wheels V2 (Right) (276-9041-802)


PROVENANCE
------------------------------------------------------------

  v1.1.1 library   Owen (169E) and Ryan (4253B), released 2023-02-17.
                   github.com/VEX-CAD/VEX-CAD-Solidworks
  2026 additions   VEX Robotics STEP downloads, pulled 2026-08-30 and
                   converted to SLDPRT/SLDASM locally.

Some added parts are .SLDASM rather than .SLDPRT. That is correct: those
STEP files contain multiple solid bodies, so SolidWorks imports them as
assemblies.

Requires SolidWorks 2021-2022 or newer — the v1.1.1 parts are not
backwards compatible before that.

# VEX catalogue refresh — 2026-08-30

The SolidWorks library in this folder was frozen at **2023-02-17** (v1.1.1,
the last release the VEX-CAD project ever published). This is a comparison
against VEX's live V5 catalogue today.

| | count |
|---|---|
| Parts in the original 1.1.1 `.SLDPRT` library | 323 |
| V5 products checked on vexrobotics.com | 136 |
| Unique STEP parts available | 289 |
| Already covered by the 1.1.1 library — **not shipped** | 181 |
| **No counterpart in 1.1.1 — shipped in `VEX-STEP-2026/`** | **108** |

## How the comparison was made, and where it can be wrong

Parts were matched on **name**, not geometry. VEX's STEP exports and the
community library use different naming conventions, so this is a good guide
but not a precise diff. Two things in particular to be aware of:

- **Configurations.** The 1.1.1 library stores length variants as
  configurations inside a single file — one `Aluminum C-Channel.SLDPRT`
  covers every length. VEX ships one STEP per length. Where a length had no
  obvious name match it may appear below as "new" when it is really just a
  variant you already have.
- **Renames.** A part renamed between 2023 and now can look new. Conversely,
  a genuinely new part with a familiar name can be judged "already covered"
  and left out.

If something you expected is missing, check the omitted list at the bottom —
everything there is still available and can be re-downloaded.

---

# Shipped: 108 parts with no 1.1.1 counterpart

## Electronics/Control (2)

- Competition Cortex Wire Retaining Clip (276-2173) — `276-2173`
- V5 Controller (276-4820) — `276-4820`

## Electronics/Power (3)

- Battery Extension Cable (276-3442) — `276-3442`
- Battery Strap (276-2219) — `276-2219`
- Extension Cable Retaining Clip (276-4128) — `276-4128`

## Field (1)

- VEX Portable Competition Field Perimeter (276-8242) — `276-8242`

## Hardware/Bearings (2)

- Bearing Blocks (276-2016-001) — `276-2016-001`
- Flat Bearing (276-1209) — `276-1209`

## Hardware/License Plates (1)

- V5RC License Plate (276-3938) — `276-3938`

## Hardware/Screws and Nuts (27)

- #6-32 x 1-2in Screw (275-1169) — `275-1169`
- #6-32 x 1-4in Screw (275-0659) — `275-0659`
- #8-32 x 0.500in Hex Drive Coupler (275-1000) — `275-1000`
- #8-32 x 0.500in Star Drive Coupler (276-4989) — `276-4989`
- #8-32 x 1-2in Screw (275-1004) — `275-1004`
- #8-32 x 1-2in Star Drive Screw (276-4992) — `276-4992`
- #8-32 x 1-4in Screw (275-1002) — `275-1002`
- #8-32 x 1-4in Star Drive Screw (276-4990) — `276-4990`
- #8-32 x 1.000in Hex Drive Coupler (275-1001) — `275-1001`
- #8-32 x 1.000in Star Drive Coupler (276-4988) — `276-4988`
- #8-32 x 1.000in Star Drive Screw (276-4996) — `276-4996`
- #8-32 x 1.250in Star Drive Screw (276-4997) — `276-4997`
- #8-32 x 1.500in Star Drive Screw (276-4998) — `276-4998`
- #8-32 x 1.750in Star Drive Screw (276-4999) — `276-4999`
- #8-32 x 2.000in Star Drive Screw (276-5004) — `276-5004`
- #8-32 x 2.250in Star Drive Screw (276-8015) — `276-8015`
- #8-32 x 2.500in Star Drive Screw (276-8016) — `276-8016`
- #8-32 x 3-4in Screw (275-1006) — `275-1006`
- #8-32 x 3-4in Star Drive Screw (276-4994) — `276-4994`
- #8-32 x 3-8in Screw (275-1003) — `275-1003`
- #8-32 x 3-8in Star Drive Screw (276-4991) — `276-4991`
- #8-32 x 5-8in Screw (275-1005) — `275-1005`
- #8-32 x 5-8in Star Drive Screw (276-4993) — `276-4993`
- #8-32 x 7-8in Screw (275-1007) — `275-1007`
- #8-32 x 7-8in Star Drive Screw (276-4995) — `276-4995`
- 1-2in Thumbscrew (275-1485) — `275-1485`
- Lead Screw Nut (276-2045-031) — `276-2045-031`

## Hardware/Shaft Hardware (8)

- High Strength Bushing Kit (1-8in Thick) (276-7582-001) — `276-7582-001`
- High Strength Bushing Kit (5-16in Thick) (276-7582-002) — `276-7582-002`
- High Strength Shaft Adapter (#8 Round Bore, 1-2in Long) (276-8034) — `276-8034`
- High Strength Shaft Adapter (1-8in Square Bore, 1-2in Long) (276-8235) — `276-8235`
- Metal Shaft Inserts (276-3881-002) — `276-3881-002`
- Plastic Shaft Inserts (276-3881-001) — `276-3881-001`
- U-Joint (276-2045-020) — `276-2045-020`
- Universal Joints (276-2723) — `276-2723`

## Hardware/Shafts (10)

- 2x Pitch Shaft (228-2500-117) — `228-2500-117`
- 3x Pitch Shaft (228-2500-119) — `228-2500-119`
- 4x Pitch Shaft (228-2500-120) — `228-2500-120`
- 5x Pitch Shaft (228-2500-121) — `228-2500-121`
- 6x Pitch Shaft (228-2500-122) — `228-2500-122`
- 7x Pitch Shaft (228-2500-123) — `228-2500-123`
- 8x Pitch Shaft (228-2500-124) — `228-2500-124`
- Drive Shaft Bar Lock (275-1065) — `275-1065`
- Short Shifter Shaft 2.65 Ratio Spread (217-3288) — `217-3288`
- Star Drive Shaft Collar (276-6103) — `276-6103`

## Hardware/Spacers (11)

- 1-16in High Strength Shaft Spacer (276-3441-001) — `276-3441-001`
- 1-2in Nylon Spacer (275-1066-004) — `275-1066-004`
- 1-4in Nylon Spacer (275-1066-002) — `275-1066-002`
- 1-8in High Strength Shaft Spacer (276-3441-002) — `276-3441-002`
- 1-8in Nylon Spacer (275-1066-001) — `275-1066-001`
- 3-8in Nylon Spacer (275-1066-003) — `275-1066-003`
- 3-8in OD x #8 Click-On Spacer, 0.063in (276-8019-001) — `276-8019-001`
- 3-8in OD x #8 Click-On Spacer, 0.125in (276-8019-002) — `276-8019-002`
- 3-8in OD x #8 Click-On Spacer, 0.250in (276-8019-003) — `276-8019-003`
- Steel Washer (275-1024) — `275-1024`
- Teflon Washer (275-1025) — `275-1025`

## Hardware/Standoffs (4)

- 1-2in Standoff (275-1014) — `275-1014`
- 1-4in Standoff (275-1013) — `275-1013`
- 1.500in Standoff (275-1017) — `275-1017`
- 3-4in Standoff (275-1015) — `275-1015`

## Kits and Misc (2)

- Intake Rollers (276-1499) — `276-1499`
- V5 Clawbot (276-6009) — `276-6009`

## Motion/Gears (3)

- 24T Bevel Gear (276-2184-001) — `276-2184-001`
- Differential & Bevel Gear (276-2184-002) — `276-2184-002`
- Rack Gear & Pinion (276-2184-003) — `276-2184-003`

## Motion/Misc (1)

- Conveyor-belt Base Links (276-2214-001) — `276-2214-001`

## Pneumatics/Cylinders (3)

- 25mm Stroke Pneumatic Cylinder
- 50mm Stroke Pneumatic Cylinder
- 75mm Stroke Pneumatic Cylinder

## Pneumatics/Fittings (12)

- Air Flow Valve Fitting
- Air Pressure Regulator Mounting Bracket
- Elbow Fitting
- Manifold Assembly
- Pneumatic Fitting Plug
- Pneumatic Hand Valve
- Pneumatic Reservoir Assembly
- Pressure Gauge
- Pressure Regulator
- Schrader Valve
- Straight Pneumatic Fitting
- Tee Fittings

## Structure/Angle (4)

- 1x1x35 Aluminum Angle (217-6484) — `217-6484`
- 2x2x25 Steel Angle (275-1142) — `275-1142`
- 2x2x35 Steel Angle (275-1143) — `275-1143`
- 3x3x35 Steel Angle (275-1144) — `275-1144`

## Structure/Bar (1)

- 1x25 Steel Bar (275-1141) — `275-1141`

## Structure/C-Channel (8)

- 1x2x1x25 Aluminum C-Channel (276-2288) — `276-2288`
- 1x2x1x35 Aluminum C-Channel (276-2289) — `276-2289`
- 1x2x1x35 Steel C-Channel (276-2906) — `276-2906`
- 1x3x1x35 Aluminum C-Channel (276-4359) — `276-4359`
- 1x5x1x25 Aluminum C-Channel (276-2290) — `276-2290`
- 1x5x1x25 Steel C-Channel (275-1138) — `275-1138`
- 1x5x1x35 Aluminum C-Channel (276-2298) — `276-2298`
- 1x5x1x35 Steel C-Channel (275-1139) — `275-1139`

## Structure/U-Channel (1)

- U-Channel 2x2x2x20 (276-7285) — `276-7285`

## Wheels/Mecanum (2)

- 2in Mecanum Wheels V2 (Left) (276-9041-801) — `276-9041-801`
- 2in Mecanum Wheels V2 (Right) (276-9041-802) — `276-9041-802`

## Wheels/Misc (2)

- 4in Wheel (High Strength Bore) (276-1497-110) — `276-1497-110`
- Tread Links (276-2168-004) — `276-2168-004`


---

# Omitted: 181 parts judged already present

Each line shows the VEX STEP part and the file in your existing library that
it was matched to. If any match looks wrong, that part is worth pulling in
by hand from its product page on vexrobotics.com.


## Electronics/Control (7)

- Power Expander (276-2271)  ←  `Power Expander.SLDPRT`
- V5 3-Wire Expander (276-5299)  ←  `V5 3-Wire Expander.SLDPRT`
- V5 Robot Brain (276-4810)  ←  `V5 Robot Brain.SLDPRT`
- V5 Robot Brain Mounting Flange (Long) (276-4810-003)  ←  `V5 Robot Brain Mounting Flange Long.SLDPRT`
- V5 Robot Brain Mounting Flange (Short) (276-4810-002)  ←  `V5 Robot Brain Mounting Flange Short.SLDPRT`
- V5 Robot Brain Screen Protector (276-4810-030)  ←  `V5 Robot Brain Screen Protector.SLDPRT`
- V5 Robot Radio (276-4831)  ←  `V5 Robot Radio.SLDPRT`

## Electronics/Misc (1)

- Flashlight (276-2210)  ←  `Flashlight.SLDPRT`

## Electronics/Motors (6)

- 2-Wire Motor 393 (276-2177)  ←  `2-Wire Motor 393.SLDPRT`
- 3-Wire Servo (276-2162)  ←  `3-Wire Servo.SLDPRT`
- Motor Controller 29 (276-2193)  ←  `Motor Controller.SLDPRT`
- Motor Post (276-1843-002)  ←  `Motor Post.SLDPRT`
- V5 Smart Motor (276-4840)  ←  `V5 Smart Motor.SLDPRT`
- V5 Smart Motor (5.5W) (276-4842)  ←  `V5 Smart Motor.SLDPRT`

## Electronics/Power (5)

- 7.2V Robot Battery NiMH 2000mAh (276-1456)  ←  `7.2V Robot Battery NiMH 2000mAh.SLDPRT`
- 7.2V Robot Battery NiMH 3000mAh (276-1491)  ←  `7.2V_Robot Battery NiMH 3000mAh.SLDPRT`
- Battery Clip (276-4042)  ←  `Battery Clip.SLDPRT`
- V5 Battery Clip (276-6020)  ←  `Battery Clip.SLDPRT`
- V5 Robot Battery (276-4811)  ←  `V5 Robot Battery.SLDPRT`

## Electronics/Sensors (14)

- AI Vision Sensor (276-8659)  ←  `Vision Sensor.SLDPRT`
- Analog Accelerometer V1.0 (276-2332)  ←  `Analog Accelerometer.SLDPRT`
- Bumper Switch (276-2159)  ←  `Bumper Switch.SLDPRT`
- Bumper Switch v2 (276-4858)  ←  `Bumper Switch V2.SLDPRT`
- Light Sensor (276-2158)  ←  `Light Sensor.SLDPRT`
- Limit Switch (276-2174)  ←  `Limit Switch.SLDPRT`
- Line Tracker (276-2154)  ←  `Line Tracker.SLDPRT`
- Potentiometer V2 (276-7417)  ←  `Potentiometer V2.SLDPRT`
- Rubber Bumper (276-7499)  ←  `Rubber Bumper.SLDPRT`
- V5 Distance Sensor (276-4852)  ←  `V5 Distance Sensor.SLDPRT`
- V5 Inertial Sensor (276-4855)  ←  `V5 Inertial Sensor.SLDPRT`
- V5 Optical Sensor (276-7043)  ←  `V5 Optical Sensor.SLDPRT`
- V5 Rotation Sensor (276-6050)  ←  `V5 Rotation Sensor.SLDPRT`
- VEX GPS Sensor (276-7405)  ←  `V5 GPS Sensor.SLDPRT`

## Hardware/Bearings (6)

- 1-Post Hex Nut Retainer w- Bearing Flat (276-6481)  ←  `1-Post Hex Nut Retainer with Bearing Flat.SLDPRT`
- 1-Post Standoff Retainer with Bearing Flat (276-8021)  ←  `1-Post Standoff Retainer with Bearing Flat.SLDPRT`
- High Strength Pillow Block Bearing (276-8383)  ←  `High Strength Pillow Block Bearing.SLDPRT`
- Large Turntable Bearing (276-5652-000)  ←  `Large Turntable Bearing.SLDPRT`
- Low Profile Bearing Flat (276-8023)  ←  `Low Profile Bearing Flat.SLDPRT`
- Small Turntable Bearing (276-5652-004)  ←  `Small Turntable Bearing.SLDPRT`

## Hardware/Retainers (4)

- 1-Post Hex Nut Retainer (276-6482)  ←  `1-Post Hex Nut Retainer.SLDPRT`
- 1-Post Standoff Retainer (276-8020)  ←  `1-Post Standoff Retainer.SLDPRT`
- 4-Post Hex Nut Retainer (276-6483)  ←  `4-Post Hex Nut Retainer.SLDPRT`
- 4-Post Standoff Retainer (276-8022)  ←  `4-Post Standoff Retainer.SLDPRT`

## Hardware/Screws and Nuts (11)

- #8-32 Hex Nut (275-1028)  ←  `Nut 8-32 Hex.SLDPRT`
- #8-32 Keps Nut (275-1026)  ←  `Nut 8-32 Keps.SLDPRT`
- #8-32 Low Profile Nut (276-7767)  ←  `Nut 8-32 Low Profile.SLDPRT`
- #8-32 Nylock Nut (275-1027)  ←  `Nut 8-32 Nylock.SLDPRT`
- #8-32 Shoulder Screws (276-1408)  ←  `Screw 8-32 0.250in.SLDPRT`
- #8-32 x 1.000in Screw (275-1008)  ←  `Screw 8-32 1.000in.SLDPRT`
- #8-32 x 1.250in Screw (275-1009)  ←  `Screw 8-32 1.250in.SLDPRT`
- #8-32 x 1.750in Screw (275-1011)  ←  `Screw 8-32 1.750in.SLDPRT`
- #8-32 x 2.000in Screw (275-1012)  ←  `Screw 8-32 2.000in.SLDPRT`
- Lead Screw (276-2045-032)  ←  `Lead Screw Segment.SLDPRT`
- Lead Screw Bracket (276-2045-033)  ←  `Lead Screw Mounting Bracket.SLDPRT`

## Hardware/Shaft Hardware (5)

- High Strength Clamping Shaft Collar (276-3520)  ←  `Clamping Shaft Collar.SLDPRT`
- Low Profile High Strength Clamping Shaft Collar (276-7580)  ←  `Low Profile HS Clamping Shaft Collar.SLDPRT`
- Rubber Shaft Collar (228-3510)  ←  `Rubber Shaft Collar.SLDPRT`
- Shaft Collar Retainer with Bearing Flat (276-8024)  ←  `Shaft Collar Retainer with Bearing Flat.SLDPRT`
- Star Drive Clamping Shaft Collar (276-6101)  ←  `Clamping Shaft Collar.SLDPRT`

## Hardware/Shafts (20)

- 1.5in Capped Shaft (228-2500-2221)  ←  `1.5in Capped Shaft.SLDPRT`
- 1in Capped Shaft (228-2500-2219)  ←  `1in Capped Shaft.SLDPRT`
- 2.5in Capped Shaft (228-2500-2225)  ←  `2.5in Capped Shaft.SLDPRT`
- 24in High Strength Shaft (276-7465)  ←  `24in High Strength Shaft.SLDPRT`
- 2in Capped Shaft (228-2500-2223)  ←  `2in Capped Shaft.SLDPRT`
- 2in High Strength Shaft (276-3440)  ←  `2in High Strength Shaft.SLDPRT`
- 2in Shaft (276-2011-001)  ←  `2in Shaft.SLDPRT`
- 3 High Strength Shaft (276-3522)  ←  `12in High Strength Shaft.SLDPRT`
- 3.5in Capped Shaft (228-2500-2227)  ←  `3.5in Capped Shaft.SLDPRT`
- 3in Capped Shaft (228-2500-2226)  ←  `3in Capped Shaft.SLDPRT`
- 3in Shaft (276-2011-002)  ←  `3in Shaft.SLDPRT`
- 4.5in Capped Shaft (228-2500-2229)  ←  `4.5in Capped Shaft.SLDPRT`
- 4in Capped Shaft (228-2500-2228)  ←  `4in Capped Shaft.SLDPRT`
- 4in High Strength Shaft (276-3523)  ←  `4in High Strength Shaft.SLDPRT`
- 5.5in Capped Shaft (228-2500-2231)  ←  `5.5in Capped Shaft.SLDPRT`
- 5in Capped Shaft (228-2500-2230)  ←  `5in Capped Shaft.SLDPRT`
- 6in Capped Shaft (228-2500-2232)  ←  `6in Capped Shaft.SLDPRT`
- Drive Shaft 12in (276-1149)  ←  `12in Shaft.SLDPRT`
- High Strength Shaft Bearing (276-3521)  ←  `12in High Strength Shaft.SLDPRT`
- Shaft Coupler (276-1843-001)  ←  `Shaft Coupler.SLDPRT`

## Hardware/Spacers (3)

- 1-2in High Strength Shaft Spacer (276-3441-004)  ←  `2in High Strength Shaft.SLDPRT`
- 1-4in High Strength Shaft Spacer (276-3441-003)  ←  `4in High Strength Shaft.SLDPRT`
- 8mm Plastic Spacer (276-2019)  ←  `8mm Plastic Spacer.SLDPRT`

## Hardware/Standoffs (7)

- 1.00in Standoff (275-1016)  ←  `1.00in Standoff.SLDPRT`
- 2.00in Standoff (275-1018)  ←  `2.00in Standoff.SLDPRT`
- 2.50in Standoff (275-1019)  ←  `2.50in Standoff.SLDPRT`
- 3.00in Standoff (275-1020)  ←  `3.00in Standoff.SLDPRT`
- 4.00in Standoff (275-1021)  ←  `4.00in Standoff.SLDPRT`
- 5.00in Standoff (275-1022)  ←  `5.00in Standoff.SLDPRT`
- 6.00in Standoff (275-1023)  ←  `6.00in Standoff.SLDPRT`

## Kits and Misc (1)

- V5 Claw Kit (276-6010)  ←  `Claw Kit.SLDPRT`

## Motion/6P Sprockets (5)

- 16T Sprocket, 6P (276-8328)  ←  `16T 6P Sprocket.SLDPRT`
- 24T Sprocket, 6P (276-8329)  ←  `24T 6P Sprocket.SLDPRT`
- 32T Sprocket, 6P (276-8330)  ←  `32T 6P Sprocket.SLDPRT`
- 40T Sprocket, 6P (276-8331)  ←  `40T 6P Sprocket.SLDPRT`
- 8T Sprocket, 6P (276-8030)  ←  `8T 6P Sprocket.SLDPRT`

## Motion/Gears (12)

- 12T Gear (276-2169-001)  ←  `12T Gear.SLDPRT`
- 12T Metal Gear (276-7368)  ←  `12T Metal Gear.SLDPRT`
- 16t Bevel Gear (276-2045-051)  ←  `16T Bevel Gear.SLDPRT`
- 32t Bevel Gear (276-2045-052)  ←  `32T Bevel Gear.SLDPRT`
- 36T Gear (276-2169-002)  ←  `36T Gear.SLDPRT`
- 60T Gear (276-2169-003)  ←  `60T Gear.SLDPRT`
- 84T Gear (276-2169-004)  ←  `84T Gear.SLDPRT`
- Bevel Gearbox Bracket (275-1189)  ←  `Bevel Gearbox Bracket.SLDPRT`
- Rack Gear v2 (276-4782)  ←  `Rack Gear v2.SLDPRT`
- Rack Gearbox Bracket v2 (276-5771)  ←  `Rack Gearbox Bracket v2.SLDPRT`
- Worm Gear & Wheel (276-2184-004)  ←  `Worm Gear.SLDPRT`
- Worm Gearbox Bracket (275-1187)  ←  `Worm Gearbox Bracket.SLDPRT`

## Motion/HS Gears (10)

- 12T High Strength Metal Pinion (276-2251)  ←  `12T High Strength Pinion.SLDPRT`
- 24T High Strength Gear v2 (276-7572)  ←  `24T High Strength Gear v2.SLDPRT`
- 36T High Strength Gear (276-5034)  ←  `36T High Strength Gear.SLDPRT`
- 36T High Strength Gear v2 (8-pack) (276-7747)  ←  `36T High Strength Gear V2.SLDPRT`
- 48T High Strength Gear v2 (8-Pack) (276-7573)  ←  `48T High Strength Gear V2.SLDPRT`
- 60T High Strength Gear (276-5035)  ←  `60T High Strength Gear.SLDPRT`
- 60T High Strength Gear v2 (8-pack) (276-7748)  ←  `60T High Strength Gear V2.SLDPRT`
- 72T High Strength Gear v2 (6-Pack) (276-7574)  ←  `72T High Strength Gear V2.SLDPRT`
- 84T High Strength Gear (276-3438)  ←  `84T High Strength Gear.SLDPRT`
- 84T High Strength Gear v2 (4-pack) (276-7749)  ←  `84T High Strength Gear V2.SLDPRT`

## Motion/HS Sprockets (10)

- 12T High Strength Sprocket (276-3877)  ←  `12T High Strength Sprocket.SLDPRT`
- 12T High Strength Sprocket (HS Bore) (276-3877)  ←  `12T High Strength Sprocket HS Bore.SLDPRT`
- 18T High Strength Sprocket (276-3878)  ←  `18T High Strength Sprocket.SLDPRT`
- 18T High Strength Sprocket (HS Bore) (276-3878)  ←  `18T High Strength Sprocket HS Bore.SLDPRT`
- 24T High Strength Sprocket (276-3879)  ←  `24T High Strength Sprocket.SLDPRT`
- 24T High Strength Sprocket (HS Bore) (276-3879)  ←  `24T High Strength Sprocket HS Bore.SLDPRT`
- 30T High Strength Sprocket (276-3880)  ←  `30T High Strength Sprocket.SLDPRT`
- 30T High Strength Sprocket (HS Bore) (276-3880)  ←  `30T High Strength Sprocket HS Bore.SLDPRT`
- 6T High Strength Sprocket (276-3876)  ←  `6T High Strength Sprocket.SLDPRT`
- 6T High Strength Sprocket (HS Bore) (276-3876)  ←  `6T High Strength Sprocket HS Bore.SLDPRT`

## Motion/Misc (10)

- Cam Follower (276-2045-066)  ←  `Cam Follower.SLDPRT`
- Clutch (276-1098)  ←  `Clutch.SLDPRT`
- Drop Off Cam (276-2045-061)  ←  `Drop Off Cam.SLDPRT`
- Hand Crank (276-2045-001)  ←  `Hand Crank.SLDPRT`
- Medium Conveyor-belt Inserts (276-2214-002)  ←  `Medium Conveyor-belt Insert.SLDPRT`
- Rubber Link (275-1029)  ←  `Rubber Link.SLDPRT`
- Short Conveyor-belt Inserts (276-2214-003)  ←  `Short Conveyor-belt Insert.SLDPRT`
- Tall Conveyor-belt Inserts (276-2214-004)  ←  `Tall Conveyor-belt Insert.SLDPRT`
- Turntable Mounting Bracket (276-5652-007)  ←  `Turntable Mounting Bracket.SLDPRT`
- V5 Flywheel Weight (276-8794)  ←  `Flywheel Weight.SLDPRT`

## Motion/Sprockets (3)

- High Strength Chain Attachment Links (276-2252-002)  ←  `High Strength Chain Attachment Links.SLDPRT`
- High Strength Chain Links (276-2252-001)  ←  `High Strength Chain Links.SLDPRT`
- High Strength Conveyor Chain (276-7141)  ←  `High Strength Chain Links.SLDPRT`

## Structure/Angle (4)

- 90-Degree Gusset Set - Angle (276-2577)  ←  `90-Degree Gusset Set - Angle.SLDPRT`
- Angle Corner Gusset (276-2576)  ←  `Angle Corner Gusset.SLDPRT`
- Angle Coupler Gusset (276-2578)  ←  `Angle Coupler Gusset.SLDPRT`
- Gusset Pack - Angle (276-1110)  ←  `Angle Gusset.SLDPRT`

## Structure/Bar (1)

- Lock Bar (276-2016-002)  ←  `Plastic Lock Bar.SLDPRT`

## Structure/Base Plate (1)

- 15x30 Base Plate (276-1341)  ←  `Steel 15x30 Base Plate.SLDPRT`

## Structure/Brackets (1)

- Hinge (275-1272)  ←  `Hinge.SLDASM`

## Structure/C-Channel (1)

- C-Channel Coupler Gusset (276-2575)  ←  `C-Channel Coupler Gusset.SLDPRT`

## Structure/Chassis Rail (2)

- 2x1x25 Steel Chassis Rail (275-1145)  ←  `Steel 2x1x25 Chassis Rail.SLDPRT`
- 2x1x35 Steel Chassis Rail (275-1146)  ←  `Steel 2x1x35 Chassis Rail.SLDPRT`

## Structure/Gusset (12)

- 30 Degree Bent Gusset (276-7758-002)  ←  `30 Degree Bent Gusset.SLDPRT`
- 30 Degree Flat Gusset (276-7758-001)  ←  `30 Degree Flat Gusset.SLDPRT`
- 45 Degree Bent Gusset (276-7759-002)  ←  `45 Degree Bent Gusset.SLDPRT`
- 45 Degree Flat Gusset (276-7759-001)  ←  `45 Degree Flat Gusset.SLDPRT`
- 45 Degree Gusset (275-1186)  ←  `45 Degree Gusset.SLDPRT`
- 60 Degree Bent Gusset (276-7760-002)  ←  `60 Degree Bent Gusset.SLDPRT`
- 60 Degree Flat Gusset (276-7760-001)  ←  `60 Degree Flat Gusset.SLDPRT`
- 90 Degree Bent Gusset (276-7761-002)  ←  `90 Degree Bent Gusset.SLDPRT`
- 90 Degree Flat Gusset (276-7761-001)  ←  `90 Degree Flat Gusset.SLDPRT`
- 90-Degree Gusset Set - Plate (276-2577)  ←  `90-Degree Gusset Set - Angle.SLDPRT`
- Gusset Pack - Pivot (276-1110)  ←  `Pivot Gusset.SLDPRT`
- Gusset Pack - Plus (276-1110)  ←  `Plus Gusset.SLDPRT`

## Structure/Plate (2)

- 5x15 Steel Plate (275-2023)  ←  `Steel Plate.SLDPRT`
- 5x25 Steel Plate (275-1140)  ←  `Steel Plate.SLDPRT`

## Structure/U-Channel (1)

- 2x2x2x20 Aluminum U-Channel (6-pack) (276-7285)  ←  `Aluminum U-Channel.SLDPRT`

## Wheels/Anti-Static (3)

- 2.75in (220mm Travel) Anti-Static Wheel (276-8098)  ←  `2.75in Omni-Directional Anti-Static Wheel (220mm Travel).SLDPRT`
- 3.25in (260mm Travel) Anti-Static Wheel (276-7771)  ←  `3.25in Anti-Static Wheel (260mm Travel).SLDPRT`
- 4in (320mm Travel) Anti-Static Wheel (2-Pack) (276-8103)  ←  `4in Anti-Static Wheel (320mm Travel).SLDASM`

## Wheels/Mecanum (3)

- 2in Mecanum Wheel- Left (217-7400)  ←  `2in Mecanum Wheel - Left.SLDPRT`
- 2in Mecanum Wheel- Right (217-7400)  ←  `2in Mecanum Wheel - Right.SLDPRT`
- 4in Mecanum Wheel (276-1447)  ←  `4in Mecanum Wheel.SLDPRT`

## Wheels/Misc (5)

- 2.75in Wheel (276-1496)  ←  `2.75in Wheel.SLDPRT`
- 4in Wheel (276-1497)  ←  `4in Wheel.SLDPRT`
- Double Bogie Wheel (276-2168-002)  ←  `Double Bogie Wheel.SLDPRT`
- Single Bogie Wheel (276-2168-003)  ←  `Single Bogie Wheel.SLDPRT`
- Tank Tread Drive Wheels (276-2168-001)  ←  `Tank Tread Drive Wheel.SLDPRT`

## Wheels/Omni (4)

- 2.75in (220mm Travel) Omni-Directional Anti-Static Wheel (276-8106)  ←  `2.75in Omni-Directional Anti-Static Wheel (220mm Travel).SLDPRT`
- 2in Omni-Directional Wheel (276-9044)  ←  `2in Omni-Directional Wheel (276-9044).SLDPRT`
- 3.25in (260mm Travel) Omni-Directional Anti-Static Wheel (276-8026)  ←  `3.25in Omni-Directional Anti-Static Wheel  (260mm Travel).SLDPRT`
- 4in (320mm Travel) Omni-Directional Anti-Static Wheel (276-8107)  ←  `4in Omni-Directional Anti-Static Wheel (320mm Travel).SLDPRT`

## Wheels/Traction (1)

- Tank Tread Traction Links (276-2214-005)  ←  `Tank Tread Traction Link.SLDPRT`

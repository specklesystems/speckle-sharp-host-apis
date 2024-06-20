namespace Speckle.Rhino7.Interfaces;

public enum RhinoUnitSystem : byte
{
  /// <summary>
  ///  ON::LengthUnitSystem::None indicates no length unit system. The scale factor
  ///  when converting between a specified unit system and None is always 1.0.
  ///  ON::LengthUnitSystem::None is used as a unit system for models and
  ///  instance defitions that should be imported or referenced with no
  ///  scaling applied.
  /// </summary>
  None = 0,

  /// <summary>1 micron = 1.0e-6 meters</summary>
  Microns = 1,

  /// <summary>1 millimeter = 1.0e-3 meters</summary>
  Millimeters = 2,

  /// <summary>1 centimeter = 1.0e-2 meters</summary>
  Centimeters = 3,

  /// <summary>SI meter length unit</summary>
  Meters = 4,

  /// <summary>1 kilometer = 1.0e+3 meters</summary>
  Kilometers = 5,

  /// <summary>1 microinches = 2.54e-8 meters = 1.0e-6 inches</summary>
  Microinches = 6,

  /// <summary>1 mil = 2.54e-5 meters = 0.001 inches</summary>
  Mils = 7,

  /// <summary>1 inch = 0.0254 meters = 1/12 foot</summary>
  Inches = 8,

  /// <summary>1 foot = 0.3048  meters (12 inches)</summary>
  Feet = 9,

  /// <summary>1 US statute mile = 1609.344 meters = 5280 feet</summary>
  Miles = 10, // 0x0A

  /// <summary>
  ///  The name of a custom unit and the conversion to meters
  ///  are saved in the ON_UnitSystem class.
  /// </summary>
  CustomUnits = 11, // 0x0B

  /// <summary>1 angstroms = 1.0e-10 meters</summary>
  Angstroms = 12, // 0x0C

  /// <summary>1 nanometer = 1.0e-9 meters</summary>
  Nanometers = 13, // 0x0D

  /// <summary>1 decimeter = 1.0e-1 meters</summary>
  Decimeters = 14, // 0x0E

  /// <summary>1 dekameter = 1.0e+1 meters</summary>
  Dekameters = 15, // 0x0F

  /// <summary>1 hectometer = 1.0e+2 meters</summary>
  Hectometers = 16, // 0x10

  /// <summary>1 megameter = 1.0e+6 meters</summary>
  Megameters = 17, // 0x11

  /// <summary>1 gigameter = 1.0e+9 meters</summary>
  Gigameters = 18, // 0x12

  /// <summary>1 foot = 0.3048 meters = 12 inches</summary>
  Yards = 19, // 0x13

  /// <summary>1 printer point = 1/72 inch</summary>
  PrinterPoints = 20, // 0x14

  /// <summary>1 printer pica = 1/6 inch</summary>
  PrinterPicas = 21, // 0x15

  /// <summary>
  ///  1 nautical mile = 1852 meters
  ///  Approximately 1 minute of arc on a terrestrial great circle.
  ///  Reference: http://en.wikipedia.org/wiki/Nautical_mile
  /// </summary>
  NauticalMiles = 22, // 0x16

  /// <summary>
  ///  1 astronomical unit = 1.4959787e+11 meters
  ///  An astronomical unit (au) is the mean distance from the
  ///  center of the earth to the center of the sun.
  ///  References:
  ///    http://en.wikipedia.org/wiki/Astronomical_unit (1.4959787e+11 meters)
  ///    http://units.nist.gov/Pubs/SP811/appenB9.htm (1.495979e+11 meters)
  /// </summary>
  AstronomicalUnits = 23, // 0x17

  /// <summary>
  ///  1 light year = 9.4607304725808e+15 meters
  ///  A light year is the distance light travels in one Julian year.
  ///     The speed of light is exactly 299792458 meters/second.
  ///     A Julian year is exactly 365.25 * 86400 seconds and is
  ///     approximately the time it takes for one earth orbit.
  ///  References:
  ///    http://en.wikipedia.org/wiki/Light_year (9.4607304725808e+15 meters)
  ///    http://units.nist.gov/Pubs/SP811/appenB9.htm (9.46073e+15 meters)
  /// </summary>
  LightYears = 24, // 0x18

  /// <summary>
  ///  1 parsec = 3.08567758e+16 meters
  ///  References:
  ///    http://en.wikipedia.org/wiki/Parsec (3.08567758e+16 meters)
  ///    http://units.nist.gov/Pubs/SP811/appenB9.htm (3.085678e+16)
  /// </summary>
  Parsecs = 25, // 0x19

  /// <summary>
  ///  The ON::LengthUnitSystem::Unset is used to indicate no unit system is set.
  ///  This is a differnt condition from ON::LengthUnitSystem::None.
  /// </summary>
  Unset = 255, // 0xFF
}

public enum RhinoObjectType : uint
{
  /// <summary>Nothing.</summary>
  None = 0,

  /// <summary>A point.</summary>
  Point = 1,

  /// <summary>A point set or cloud.</summary>
  PointSet = 2,

  /// <summary>A curve.</summary>
  Curve = 4,

  /// <summary>A surface.</summary>
  Surface = 8,

  /// <summary>A brep.</summary>
  Brep = 16, // 0x00000010

  /// <summary>A mesh.</summary>
  Mesh = 32, // 0x00000020

  /// <summary>A rendering light.</summary>
  Light = 256, // 0x00000100

  /// <summary>An annotation.</summary>
  Annotation = 512, // 0x00000200

  /// <summary>A block definition.</summary>
  InstanceDefinition = 2048, // 0x00000800

  /// <summary>A block reference.</summary>
  InstanceReference = 4096, // 0x00001000

  /// <summary>A text dot.</summary>
  TextDot = 8192, // 0x00002000

  /// <summary>Selection filter value - not a real object type.</summary>
  Grip = 16384, // 0x00004000

  /// <summary>A detail.</summary>
  Detail = 32768, // 0x00008000

  /// <summary>A hatch.</summary>
  Hatch = 65536, // 0x00010000

  /// <summary>A morph control.</summary>
  MorphControl = 131072, // 0x00020000

  /// <summary>A SubD object.</summary>
  SubD = 262144, // 0x00040000

  /// <summary>A brep loop.</summary>
  BrepLoop = 524288, // 0x00080000

  /// <summary>a brep vertex.</summary>
  BrepVertex = 1048576, // 0x00100000

  /// <summary>Selection filter value - not a real object type.</summary>
  PolysrfFilter = 2097152, // 0x00200000

  /// <summary>Selection filter value - not a real object type.</summary>
  EdgeFilter = 4194304, // 0x00400000

  /// <summary>Selection filter value - not a real object type.</summary>
  PolyedgeFilter = 8388608, // 0x00800000

  /// <summary>A mesh vertex.</summary>
  MeshVertex = 16777216, // 0x01000000

  /// <summary>A mesh edge.</summary>
  MeshEdge = 33554432, // 0x02000000

  /// <summary>A mesh face.</summary>
  MeshFace = 67108864, // 0x04000000

  /// <summary>A cage.</summary>
  Cage = 134217728, // 0x08000000

  /// <summary>A phantom object.</summary>
  Phantom = 268435456, // 0x10000000

  /// <summary>A clipping plane.</summary>
  ClipPlane = 536870912, // 0x20000000

  /// <summary>An extrusion.</summary>
  Extrusion = 1073741824, // 0x40000000

  /// <summary>All bits set.</summary>
  AnyObject = 4294967295, // 0xFFFFFFFF
}

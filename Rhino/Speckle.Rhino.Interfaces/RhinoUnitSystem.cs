using System.Collections.Concurrent;

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

public enum RhinoLoopFormula
{
  /// <summary>The original Loop formula.</summary>
  Loop,

  /// <summary>Warren's improved formula.</summary>
  Warren,

  /// <summary>
  /// The formula as explained by Weimer, improving over Warren's.
  /// </summary>
  WarrenWeimer,
}

public enum RhinoBrepSolidOrientation
{
  /// <summary>Brep is a Solid with inward facing normals.</summary>
  Inward = -1, // 0xFFFFFFFF

  /// <summary>Brep is not a Solid.</summary>
  None = 0,

  /// <summary>Brep is a Solid with outward facing normals.</summary>
  Outward = 1,

  /// <summary>
  /// Breps is a Solid but no orientation could be computed.
  /// </summary>
  Unknown = 2,
}

public enum RhinoIsoStatus
{
  /// <summary>curve is not an isoparametric curve.</summary>
  None,

  /// <summary>
  /// curve is a "x" = constant (vertical) isoparametric curve in the interior of the surface's domain.
  /// </summary>
  X,

  /// <summary>
  /// curve is a "y" = constant (horizontal) isoparametric curve in the interior of the surface's domain.
  /// </summary>
  Y,

  /// <summary>
  /// curve is a "x" = constant isoparametric curve along the west side of the surface's domain.
  /// </summary>
  West,

  /// <summary>
  /// curve is a "y" = constant isoparametric curve along the south side of the surface's domain.
  /// </summary>
  South,

  /// <summary>
  /// curve is a "x" = constant isoparametric curve along the east side of the surface's domain.
  /// </summary>
  East,

  /// <summary>
  /// curve is a "y" = constant isoparametric curve along the north side of the surface's domain.
  /// </summary>
  North,
}

public enum RhinoBrepTrimType
{
  /// <summary>Unknown type</summary>
  Unknown,

  /// <summary>
  /// Trim is connected to an edge, is part of an outer, inner or
  /// slit loop, and is the only trim connected to the edge.
  /// </summary>
  Boundary,

  /// <summary>
  /// Trim is connected to an edge, is part of an outer, inner or slit loop,
  /// no other trim from the same loop is connected to the edge, and at least
  /// one trim from a different loop is connected to the edge.
  /// </summary>
  Mated,

  /// <summary>
  /// trim is connected to an edge, is part of an outer, inner or slit loop,
  /// and one other trim from the same loop is connected to the edge.
  /// (There can be other mated trims that are also connected to the edge.
  /// For example, the non-manifold edge that results when a surface edge lies
  /// in the middle of another surface.)  Non-manifold "cuts" have seam trims too.
  /// </summary>
  Seam,

  /// <summary>
  /// Trim is part of an outer loop, the trim's 2d curve runs along the singular
  /// side of a surface, and the trim is NOT connected to an edge. (There is
  /// no 3d edge because the surface side is singular.)
  /// </summary>
  Singular,

  /// <summary>
  /// Trim is connected to an edge, is the only trim in a curve-on-surface loop, and
  /// is the only trim connected to the edge.
  /// </summary>
  CurveOnSurface,

  /// <summary>
  /// Trim is a point on a surface, trim.m_pbox is records surface parameters,
  /// and is the only trim in a point-on-surface loop.  This trim is not connected to
  /// an edge and has no 2d curve.
  /// </summary>
  PointOnSurface,

  /// <summary></summary>
  Slit,
}

public enum RhinoBrepLoopType
{
  /// <summary>Unknown loop type.</summary>
  Unknown,

  /// <summary>
  /// 2d loop curves form a simple closed curve with a counterclockwise orientation.
  /// </summary>
  Outer,

  /// <summary>
  /// 2d loop curves form a simple closed curve with a clockwise orientation.
  /// </summary>
  Inner,

  /// <summary>
  /// Always closed - used internally during splitting operations.
  /// </summary>
  Slit,

  /// <summary>
  /// "loop" is a curve-on-surface made from a single (open or closed) trim that
  /// has type TrimType.CurveOnSurface.
  /// </summary>
  CurveOnSurface,

  /// <summary>
  /// "loop" is a PointOnSurface made from a single trim that has
  /// type TrimType.PointOnSurface.
  /// </summary>
  PointOnSurface,
}

public static class EnumUtility<TSource, TDestination>
  where TSource : struct, Enum
  where TDestination : struct, Enum
{
  private static readonly ConcurrentDictionary<TSource, TDestination> _destinations = new();

  static EnumUtility()
  {
    var sources = ((TSource[])Enum.GetValues(typeof(TSource))).Select(x => (x.ToString(), x));
    var destinations = Enum.GetNames(typeof(TDestination))
      .Select(x => (x, (TDestination)Enum.Parse(typeof(TDestination), x.ToString())))
      .ToList();
    foreach (var (name, val) in sources)
    {
      var d = destinations.Where(x => x.Item1 == name).ToList();
      if (d.Any())
      {
        foreach (var v in d)
        {
          destinations.Remove(v);
        }
        _destinations.TryAdd(val, d.Single().Item2);
      }
    }
  }

  public static TDestination Convert(TSource source)
  {
    if (_destinations.TryGetValue(source, out var destination))
    {
      return destination;
    }

    throw new InvalidOperationException($"{source} does not exist in destination enum: {typeof(TDestination)}");
  }
}

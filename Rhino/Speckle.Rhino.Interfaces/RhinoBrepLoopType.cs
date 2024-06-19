namespace Speckle.Rhino7.Interfaces;

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

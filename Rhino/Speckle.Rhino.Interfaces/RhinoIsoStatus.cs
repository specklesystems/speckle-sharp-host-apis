namespace Speckle.Rhino7.Interfaces;

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

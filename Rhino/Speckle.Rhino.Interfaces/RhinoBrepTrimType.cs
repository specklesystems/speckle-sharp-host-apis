namespace Speckle.Rhino7.Interfaces;

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

namespace Speckle.Rhino7.Interfaces;

public interface IRhinoDoc
{
  double ModelAbsoluteTolerance { get; }
}

public interface IRhinoCurve : IRhinoGeometryBase
{
  bool TryGetCircle(out IRhinoCircle circle, double tolerance);
  IRhinoInterval Domain { get; }
  IRhinoNurbsCurve ToNurbsCurve();
  double GetLength();
}

public interface IRhinoGeometryBase : IRhinoCommonObject
{
  IRhinoBoundingBox GetBoundingBox(bool val);
}

public interface IRhinoCommonObject;

public interface IRhinoObject : IRhinoModelComponent;

public interface IRhinoModelComponent : IRhinoCommonObject;

public interface IRhinoArcCurve : IRhinoCurve
{
  bool IsCompleteCircle { get; }
  IRhinoArc Arc { get; }
}

public interface IRhinoCircle
{
  IRhinoPlane Plane { get; }
  double Radius { get; }
}

public interface IRhinoArc
{
  IRhinoPlane Plane { get; }
  double Radius { get; }
  double StartAngle { get; }
  double EndAngle { get; }
  double Angle { get; }
  IRhinoPoint3d StartPoint { get; }
  IRhinoPoint3d MidPoint { get; }
  IRhinoPoint3d EndPoint { get; }
  double Length { get; }
  IRhinoBoundingBox BoundingBox();
}

public interface IRhinoInterval
{
  double T0 { get; }
  double T1 { get; }
}

public interface IRhinoPoint3d
{
  double X { get; }
  double Y { get; }
  double Z { get; }
}

public interface IRhinoPlane;

public interface IRhinoBox
{
  IRhinoPlane Plane { get; }
  IRhinoInterval X { get; }
  IRhinoInterval Y { get; }
  IRhinoInterval Z { get; }
  double Area { get; }
  double Volume { get; }
}

public interface IRhinoBoundingBox;

public interface IRhinoBrep : IRhinoGeometryBase
{
  bool Repair(double tolerance);

  IRhinoBrepVertexList Vertices { get; }
  IRhinoBrepCurveList Curves3D { get; }
  IRhinoBrepSurfaceList Surfaces { get; }
  IRhinoBrepCurveList Curves2D { get; }
  IRhinoBrepFaceList Faces { get; }
  IRhinoBrepEdgeList Edges { get; }
  IRhinoBrepLoopList Loops { get; }
  IRhinoBrepTrimList Trims { get; }
  bool IsSolid { get; }
  double GetVolume();
  double GetArea();
  RhinoBrepSolidOrientation SolidOrientation { get; }
}

public interface IRhinoPoint : IRhinoGeometryBase
{
  IRhinoPoint3d Location { get; }
}

public interface IRhinoBrepVertex : IRhinoPoint
{
  int VertexIndex { get; }
}

public interface IRhinoBrepVertexList : IReadOnlyList<IRhinoBrepVertex>;

public interface IRhinoNurbsSurface : IRhinoSurface;

public interface IRhinoSurface : IRhinoGeometryBase
{
  IRhinoNurbsSurface ToNurbsSurface();
}

public interface IRhinoMesh : IRhinoGeometryBase
{
  void Append(IEnumerable<IRhinoMesh> meshes);
}

public interface IRhinoRefinementSettings;

public interface IRhinoBrepCurveList : IReadOnlyList<IRhinoCurve>;

public interface IRhinoBrepSurfaceList : IReadOnlyList<IRhinoSurface>;

public interface IRhinoBrepFaceList : IReadOnlyList<IRhinoBrepFace>;

public interface IRhinoSurfaceProxy : IRhinoSurface;

public interface IRhinoBrepFace : IRhinoSurfaceProxy
{
  int FaceIndex { get; }
  int SurfaceIndex { get; }
  IRhinoBrepLoopList Loops { get; }
  IRhinoBrepLoop OuterLoop { get; }
  bool OrientationIsReversed { get; }
}

public interface IRhinoBrepLoopList : IReadOnlyList<IRhinoBrepLoop>;

public interface IRhinoBrepLoop : IRhinoGeometryBase
{
  int LoopIndex { get; }
  IRhinoBrepFace Face { get; }
  IRhinoBrepTrimList Trims { get; }
  RhinoBrepLoopType LoopType { get; }
}

public interface IRhinoBrepEdgeList : IReadOnlyList<IRhinoBrepEdge>;

public interface IRhinoCurveProxy2 : IRhinoCurve
{
  bool ProxyCurveIsReversed { get; }
}

public interface IRhinoBrepEdge : IRhinoCurveProxy2
{
  int EdgeIndex { get; }
  int EdgeCurveIndex { get; }
  int[] TrimIndices();
  IRhinoBrepVertex? StartVertex { get; }
  IRhinoBrepVertex? EndVertex { get; }
}

public interface IRhinoBrepTrim : IRhinoCurveProxy2
{
  int TrimIndex { get; }
  IRhinoBrepEdge? Edge { get; }
  IRhinoBrepFace Face { get; }
  IRhinoBrepLoop Loop { get; }
  int TrimCurveIndex { get; }
  RhinoIsoStatus IsoStatus { get; }
  RhinoBrepTrimType TrimType { get; }
  bool IsReversed();
  IRhinoBrepVertex? StartVertex { get; }
  IRhinoBrepVertex? EndVertex { get; }
}

public interface IRhinoBrepTrimList : IReadOnlyList<IRhinoBrepTrim>;

public interface IRhinoControlPoint
{
  IRhinoPoint3d Location { get; }
  double Weight { get; }
}

public interface IRhinoPolyCurve : IRhinoCurve;

public interface IRhinoPolylineCurve : IRhinoCurve;

public interface IRhinoNurbsCurve : IRhinoCurve { }

public interface IRhinoLineCurve : IRhinoCurve
{
  IRhinoLine Line { get; }
}

public interface IRhinoEllipse
{
  IRhinoNurbsCurve ToNurbsCurve();
  IRhinoPlane Plane { get; }
  double Radius1 { get; }
  double Radius2 { get; }
}

public interface IRhinoLine
{
  IRhinoPoint3d From { get; }
  IRhinoPoint3d To { get; }
  double Length { get; }
  IRhinoBoundingBox BoundingBox { get; }
}

using System.Drawing;

namespace Speckle.Rhino7.Interfaces;

public interface IRhinoDoc
{
  double ModelAbsoluteTolerance { get; }
  RhinoUnitSystem ModelUnitSystem { get; }
}

public interface IRhinoObjectAttributes : IRhinoCommonObject
{
  string Name { get; }
  string GetUserString(string key);
}

public interface IRhinoCurve : IRhinoGeometryBase
{
  bool TryGetCircle(out IRhinoCircle circle, double tolerance);
  IRhinoInterval Domain { get; set; }
  IRhinoNurbsCurve ToNurbsCurve();
  double GetLength();

  IRhinoPolylineCurve ToPolyline(
    int mainSegmentCount,
    int subSegmentCount,
    double maxAngleRadians,
    double maxChordLengthRatio,
    double maxAspectRatio,
    double tolerance,
    double minEdgeLength,
    double maxEdgeLength,
    bool keepStartPoint
  );

  bool TryGetPolyline(out IRhinoPolyline polyline);

  bool IsClosed { get; }
  int Degree { get; }
  bool IsPeriodic { get; }
  IRhinoCurve Trim(IRhinoInterval interval);
  IRhinoPolyCurve? ToPolyCurve();
  IRhinoArcCurve? ToArcCurve();
  IRhinoPolylineCurve? ToPolylineCurve();
  IRhinoLineCurve? ToLineCurve();
  IRhinoNurbsCurve? ToNurbsCurveReflection();
}

public interface IRhinoGeometryBase : IRhinoCommonObject
{
  IRhinoBoundingBox GetBoundingBox(bool val);
  bool Transform(IRhinoTransform transform);
}

public interface IRhinoCommonObject;

public interface IRhinoObject : IRhinoModelComponent
{
  Guid Id { get; }
  IRhinoObjectAttributes Attributes { get; }

  RhinoObjectType ObjectType { get; }

  IRhinoGeometryBase Geometry { get; }
}

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

public interface IRhinoBase { }

public interface IRhinoPoint3d : IRhinoBase
{
  double X { get; }
  double Y { get; }
  double Z { get; }
}

public interface IRhinoPlane
{
  IRhinoPoint3d Origin { get; }
  IRhinoVector3d ZAxis { get; }
  IRhinoVector3d XAxis { get; }
  IRhinoVector3d YAxis { get; }
}

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

  int AddEdgeCurve(IRhinoCurve curve);

  int AddTrimCurve(IRhinoCurve curve);

  int AddSurface(IRhinoSurface curve);

  bool IsValidWithLog(out string reason);
}

public interface IRhinoTransform;

public interface IRhinoPoint : IRhinoGeometryBase
{
  IRhinoPoint3d Location { get; }
}

public interface IRhinoBrepVertex : IRhinoPoint
{
  int VertexIndex { get; }
}

public interface IRhinoBrepVertexList : IReadOnlyList<IRhinoBrepVertex>
{
  IRhinoBrepVertex Add(IRhinoPoint3d vertex, double tolerance);
}

public interface IRhinoNurbsSurface : IRhinoSurface
{
  int OrderU { get; }
  int OrderV { get; }
  bool IsRational { get; }
  IRhinoNurbsSurfaceKnotList KnotsU { get; }
  IRhinoNurbsSurfaceKnotList KnotsV { get; }
  IRhinoNurbsSurfacePointList Points { get; }
}

public interface IRhinoNurbsSurfaceKnotList : IReadOnlyList<double>
{
  void SetKnot(int index, double value);
}

public interface IRhinoNurbsSurfacePointList : IEnumerable<IRhinoControlPoint>
{
  int CountU { get; }
  int CountV { get; }
  IRhinoControlPoint GetControlPoint(int i, int j);

  bool SetPoint(int u, int v, double x, double y, double z);

  bool SetWeight(int u, int v, double weight);
}

public interface IRhinoSurface : IRhinoGeometryBase
{
  IRhinoNurbsSurface ToNurbsSurface();
  bool IsClosed(int direction);
  IRhinoInterval Domain(int direction);
}

public interface IRhinoMesh : IRhinoGeometryBase
{
  void Append(IEnumerable<IRhinoMesh> meshes);
  IRhinoMeshVertexList Vertices { get; }
  IRhinoMeshFaceList Faces { get; }
  IRhinoMeshNgonList Ngons { get; }
  IEnumerable<IRhinoMeshNgon> GetNgonAndFacesEnumerable();
  IRhinoMeshTextureCoordinateList TextureCoordinates { get; }
  IRhinoMeshVertexColorList VertexColors { get; }
  bool IsClosed { get; }
  double Volume();
}

public interface IRhinoMeshNgonList : IReadOnlyList<IRhinoMeshNgon>
{
  int AddNgon(IRhinoMeshNgon ngon);
}

public interface IRhinoMeshVertexColorList : IReadOnlyList<Color>
{
  bool SetColors(Color[] colors);
}

public interface IRhinoPoint2f
{
  float X { get; }
  float Y { get; }
}

public interface IRhinoMeshTextureCoordinateList : IReadOnlyList<IRhinoPoint2f>
{
  bool SetTextureCoordinates(IRhinoPoint2f[] textureCoordinates);
}

public interface IRhinoMeshNgon
{
  uint[] BoundaryVertexIndexList();
}

public interface IRhinoPoint3f;

public interface IRhinoMeshVertexList : IReadOnlyList<IRhinoPoint3f>
{
  IRhinoPoint3d[] ToPoint3dArray();

  void AddVertices(IEnumerable<IRhinoPoint3d> points);
}

public interface IRhinoMeshFace;

public interface IRhinoMeshFaceList : IReadOnlyList<IRhinoMeshFace>
{
  int AddFace(IRhinoMeshFace face);
  int AddFace(int vertex1, int vertex2, int vertex3);
  int AddFace(int vertex1, int vertex2, int vertex3, int vertex4);
  int CullDegenerateFaces();
}

public interface IRhinoRefinementSettings;

public interface IRhinoBrepCurveList : IReadOnlyList<IRhinoCurve>;

public interface IRhinoBrepSurfaceList : IReadOnlyList<IRhinoSurface>;

public interface IRhinoBrepFaceList : IReadOnlyList<IRhinoBrepFace>
{
  IRhinoBrepFace Add(int surfaceIndex);
}

public interface IRhinoSurfaceProxy : IRhinoSurface;

public interface IRhinoBrepFace : IRhinoSurfaceProxy
{
  int FaceIndex { get; }
  int SurfaceIndex { get; }
  IRhinoBrepLoopList Loops { get; }
  IRhinoBrepLoop OuterLoop { get; }
  bool OrientationIsReversed { get; set; }
}

public interface IRhinoBrepLoopList : IReadOnlyList<IRhinoBrepLoop>
{
  IRhinoBrepLoop Add(RhinoBrepLoopType type, IRhinoBrepFace face);
}

public interface IRhinoBrepLoop : IRhinoGeometryBase
{
  int LoopIndex { get; }
  IRhinoBrepFace Face { get; }
  IRhinoBrepTrimList Trims { get; }
  RhinoBrepLoopType LoopType { get; }
}

public interface IRhinoBrepEdgeList : IReadOnlyList<IRhinoBrepEdge>
{
  IRhinoBrepEdge Add(int curve3dIndex);
  IRhinoBrepEdge Add(int startIndex, int endIndex, int curve3dIndex, IRhinoInterval domain, double tolerance);
}

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
  RhinoIsoStatus IsoStatus { get; set; }
  RhinoBrepTrimType TrimType { get; set; }
  bool IsReversed();
  IRhinoBrepVertex? StartVertex { get; }
  IRhinoBrepVertex? EndVertex { get; }
  void SetTolerances(double toleranceX, double toleranceY);
}

public interface IRhinoBrepTrimList : IReadOnlyList<IRhinoBrepTrim>
{
  IRhinoBrepTrim Add(IRhinoBrepEdge edge, bool isReversed, IRhinoBrepLoop loop, int curveIndex);
  IRhinoBrepTrim Add(bool isReversed, IRhinoBrepLoop loop, int curveIndex);
  IRhinoBrepTrim AddSingularTrim(IRhinoBrepVertex vertex, IRhinoBrepLoop loop, RhinoIsoStatus status, int curveIndex);
}

public interface IRhinoControlPoint
{
  IRhinoPoint3d Location { get; }
  double Weight { get; }
}

public interface IRhinoPolyCurve : IRhinoCurve
{
  IRhinoCurve[] DuplicateSegments();
  bool AppendSegment(IRhinoCurve curve);
}

public interface IRhinoPolylineCurve : IRhinoCurve
{
  IRhinoPolyline ToPolyline();
}

public interface IRhinoNurbsCurve : IRhinoCurve
{
  IRhinoNurbsCurveKnotList Knots { get; }
  IRhinoNurbsCurvePointList Points { get; }
  bool IsRational { get; }
}

public interface IRhinoNurbsCurveKnotList : IReadOnlyList<double>
{
  void SetKnot(int index, double value);
}

public interface IRhinoNurbsCurvePointList : IReadOnlyList<IRhinoControlPoint>
{
  bool SetPoint(int index, IRhinoPoint3d point3d, double weight);
}

public interface IRhinoPoint3dList : IReadOnlyList<IRhinoPoint3d>
{
  void Add(IRhinoPoint3d point3d);
}

public interface IRhinoPolyline : IRhinoPoint3dList
{
  IRhinoBoundingBox BoundingBox { get; }
  bool IsClosed { get; }
  IRhinoPolylineCurve ToPolylineCurve();
}

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

public interface IRhinoVector3d
{
  double X { get; }
  double Y { get; }
  double Z { get; }
}

public interface IRhinoPointCloud : IRhinoGeometryBase
{
  IRhinoPoint3d[] GetPoints();
  Color[] GetColors();
  IRhinoPointCloudItem this[int index] { get; }
}

public interface IRhinoPointCloudItem
{
  Color Color { get; set; }
}

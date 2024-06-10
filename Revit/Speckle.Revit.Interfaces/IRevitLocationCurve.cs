namespace Speckle.Revit.Interfaces;

public interface IRevitLocationCurve : IRevitLocation
{
  IRevitCurve Curve { get; }
}

public interface IRevitPolyLine : IRevitGeometryObject
{
  IList<IRevitXYZ> GetCoordinates();
}

public interface IRevitGeometryObject : IRevitObject
{
}

public interface IRevitPoint : IRevitObject
{
  IRevitXYZ Coord { get; }
}

public interface IRevitPlane : IRevitSurface {
IRevitXYZ Origin { get; }
  IRevitXYZ Normal { get; }
  IRevitXYZ XVec { get; }
  IRevitXYZ YVec { get; }
}

public interface IRevitSurface : IRevitObject, IDisposable
{
}

public interface IRevitLine : IRevitCurve
{
}

public interface IRevitArc : IRevitCurve
{
  IRevitXYZ Center { get; }
  IRevitXYZ XDirection { get; }
  IRevitXYZ YDirection { get; }
  
  double Radius { get; }
  IRevitXYZ Normal { get; }
}

public interface IRevitMesh : IRevitGeometryObject
{
  IList<IRevitXYZ> Vertices { get; }
  IRevitElementId MaterialElementId {get;}
  int NumTriangles { get; }
  IRevitMeshTriangle GetTriangle(int index);
}
public interface IRevitMaterial : IRevitElement
{
}

public interface IRevitMeshTriangle
{
  uint GetIndex(int idx);
}

public interface IRevitHermiteSpline : IRevitCurve
{
}

public interface IRevitNurbSpline : IRevitCurve
{
  IList<IRevitXYZ> CtrlPoints { get; }
  IRevitDoubleArray Weights { get; }
  IRevitDoubleArray Knots { get; }
  int Degree { get; }
  bool IsRational { get; }
  bool IsClosed { get; }
}
public interface IRevitDoubleArray: IReadOnlyList<double>
{
}

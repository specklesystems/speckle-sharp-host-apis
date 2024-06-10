namespace Speckle.Revit.Interfaces;

public interface IRevitCurve : IRevitGeometryObject
{
  IRevitXYZ GetEndPoint(int index);
  double Length { get; }
  IRevitXYZ Evaluate(double parameter, bool normalized);
  double GetEndParameter(int index);
  bool IsBound { get; }
  IList<IRevitXYZ> Tessellate();
}

public interface IRevitCloudPoint
{   float X  { get; }
   float Y  { get; }
   float Z  { get; }
   int Color { get; }
  IRevitXYZ ToXYZ();
}

public interface IRevitCloudPointList : IEnumerable<IRevitCloudPoint>
{
}

public interface IRevitPointCloudInstance : IRevitInstance
{
  IRevitCloudPointList GetPoints(
   IRevitPointCloudFilter filter,
    double averageDistance,
    int numPoints);
}
public interface IRevitInstance :IRevitElement
{
  IRevitTransform GetTransform();
}
public interface IRevitCurveArray : IReadOnlyList<IRevitCurve>
{
  
}

public interface IRevitCurveArrArray : IReadOnlyList<IRevitCurveArray>
{
}

public interface IRevitEllipse : IRevitCurve
{
  IRevitXYZ Center { get; }
  IRevitXYZ XDirection { get; }
  IRevitXYZ YDirection { get; }
  double RadiusX { get; }
  double RadiusY { get; }
}

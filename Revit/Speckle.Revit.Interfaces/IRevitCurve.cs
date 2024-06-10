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

public struct RevitCloudPoint
{
  public float X  { get; }
  public float Y  { get; }
  public float Z  { get; }
  public int Color { get; }

  public RevitCloudPoint(float x, float y, float z, int color)
  {
    X = x;
    Y = y;
    Z = z;
    Color = color;
  }
}

public interface IRevitCloudPointList : IEnumerable<RevitCloudPoint>
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

namespace Speckle.Revit.Interfaces;

public interface IRevitCurve : IRevitObject
{
  IRevitXYZ GetEndPoint(int index);
  double Length { get; }
  IRevitXYZ Evaluate(double parameter, bool normalized);
  double GetEndParameter(int index);
}

public interface IRevitCurveArray : IReadOnlyList<IRevitCurve>
{
  
}

public interface IRevitCurveArrArray : IReadOnlyList<IRevitCurveArray>
{
}

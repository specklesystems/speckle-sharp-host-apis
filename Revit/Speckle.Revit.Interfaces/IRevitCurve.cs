namespace Speckle.Revit.Interfaces;

public interface IRevitCurve : IRevitObject
{
  IRevitXYZ GetEndPoint(int index);
  double Length { get; }
}

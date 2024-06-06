namespace Speckle.Revit.Interfaces;

public interface IRevitCurve
{
  IRevitXYZ GetEndPoint(int index);
  double Length { get; }
}

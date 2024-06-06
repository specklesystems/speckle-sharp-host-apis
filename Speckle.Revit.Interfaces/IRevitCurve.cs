namespace Speckle.Revit2023.Interfaces;

public interface IRevitCurve
{
  IRevitXYZ GetEndPoint(int index);
  double Length { get; }
}
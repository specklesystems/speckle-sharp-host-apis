namespace Speckle.Revit.Interfaces;

public interface IRevitXYZ
{
  double Z { get; }

   double Y { get; }

   double X { get; }
  double DistanceTo(IRevitXYZ source);
}

namespace Speckle.Revit.Interfaces;

public interface IRevitLocation : IRevitObject
{
  IRevitLocationCurve? ToLocationCurve();
  IRevitLocationPoint? ToLocationPoint();
}

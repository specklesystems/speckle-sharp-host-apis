namespace Speckle.Revit.Interfaces;

public interface IRevitLocation: IRevitObject
{
  IRevitLocationPoint? ToLocationPoint();
  
    IRevitLocationCurve? ToLocationCurve();
}

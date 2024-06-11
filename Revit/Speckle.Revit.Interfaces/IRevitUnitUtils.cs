namespace Speckle.Revit.Interfaces;

public interface IRevitUnitUtils
{
  double ConvertFromInternalUnits(double value, IRevitForgeTypeId forgeTypeId);
  IRevitForgeTypeId Length { get; }
  IRevitForgeTypeId Millimeters { get; }
  IRevitForgeTypeId Centimeters { get; }
  IRevitForgeTypeId Meters { get; }
  IRevitForgeTypeId MetersCentimeters { get; }
  IRevitForgeTypeId Inches { get; }
  IRevitForgeTypeId FractionalInches { get; }
  IRevitForgeTypeId Feet { get; }
  IRevitForgeTypeId FeetFractionalInches { get; }
}

public interface IRevitPlaneUtils
{
  IRevitPlane CreateByOriginAndBasis(IRevitXYZ center, IRevitXYZ xDirection, IRevitXYZ yDirection);
  IRevitPlane CreateByNormalAndOrigin(IRevitXYZ normal, IRevitXYZ center);
}

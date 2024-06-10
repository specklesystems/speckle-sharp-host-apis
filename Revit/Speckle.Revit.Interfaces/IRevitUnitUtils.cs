namespace Speckle.Revit.Interfaces;

public interface IRevitUnitUtils
{
  double ConvertFromInternalUnits(double value, IRevitForgeTypeId forgeTypeId);
  IRevitForgeTypeId Length { get; }
}

public interface IRevitPlaneUtils
{
  IRevitPlane CreateByOriginAndBasis(IRevitXYZ center, IRevitXYZ xDirection,IRevitXYZ yDirection);
  IRevitPlane CreateByNormalAndOrigin(IRevitXYZ normal,IRevitXYZ center);
}

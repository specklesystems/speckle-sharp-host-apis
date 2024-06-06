namespace Speckle.Revit.Interfaces;

public interface IRevitUnitUtils
{
  double ConvertFromInternalUnits(double value, IRevitForgeTypeId forgeTypeId);
}

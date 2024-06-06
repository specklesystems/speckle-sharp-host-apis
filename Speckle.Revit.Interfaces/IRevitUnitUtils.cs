namespace Speckle.Revit2023.Interfaces;

public interface IRevitUnitUtils
{
  double ConvertFromInternalUnits(double value, IRevitForgeTypeId forgeTypeId);
}
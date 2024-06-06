using Autodesk.Revit.DB;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

public class RevitUnitUtils : IRevitUnitUtils
{
  public double ConvertFromInternalUnits(double value, IRevitForgeTypeId forgeTypeId) =>
    UnitUtils.ConvertFromInternalUnits(value, ((IRevitForgeTypeIdProxy)forgeTypeId)._Instance);
  public IRevitForgeTypeId Length => new ForgeTypeIdProxy(SpecTypeId.Length);
}

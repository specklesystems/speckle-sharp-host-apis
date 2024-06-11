using System.Collections.Generic;

namespace Speckle.Revit.Interfaces;

public interface IRevitFormatOptions : IRevitObject
{
  IRevitForgeTypeId GetUnitTypeId();
}

public interface IRevitFormatOptionsUtils
{
  bool CanHaveSymbol(IRevitForgeTypeId forgeTypeId);
  IList<IRevitForgeTypeId> GetValidSymbols(IRevitForgeTypeId forgeTypeId);
  string GetLabelForSymbol(IRevitForgeTypeId symbolId);
}

public interface IRevitSolidUtils
{
  IRevitSolid CreateTransformed(IRevitSolid solid, IRevitTransform inverseTransform);
}

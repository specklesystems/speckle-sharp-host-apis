#pragma warning disable CA1040

namespace Speckle.Revit2023.Interfaces;

public interface IRevitUnits
{
  IRevitFormatOptions GetFormatOptions(IRevitForgeTypeId length);
}


#pragma warning restore CA1040

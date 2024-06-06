using System.Diagnostics.CodeAnalysis;

namespace Speckle.Revit.Interfaces;

[SuppressMessage("Design", "CA1040:Avoid empty interfaces")]
public interface IRevitFormatOptions
{
  IRevitForgeTypeId GetUnitTypeId();
}

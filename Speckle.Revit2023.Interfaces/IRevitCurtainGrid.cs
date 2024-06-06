namespace Speckle.Revit2023.Interfaces;

public interface IRevitCurtainGrid
{
  ICollection<IRevitElementId> GetMullionIds();
  ICollection<IRevitElementId> GetPanelIds();
}
namespace Speckle.Revit.Interfaces;

public interface IRevitCurtainGrid
{
  ICollection<IRevitElementId> GetMullionIds();
  ICollection<IRevitElementId> GetPanelIds();
}

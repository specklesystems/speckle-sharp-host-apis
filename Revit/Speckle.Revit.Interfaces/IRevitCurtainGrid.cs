namespace Speckle.Revit.Interfaces;

public interface IRevitCurtainGrid : IRevitObject
{
  ICollection<IRevitElementId> GetMullionIds();
  ICollection<IRevitElementId> GetPanelIds();
}

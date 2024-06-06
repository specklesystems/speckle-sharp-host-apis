namespace Speckle.Revit2023.Interfaces;

public interface IRevitWall : IRevitHostObject
{
  IRevitCurtainGrid CurtainGrid { get; }
  bool IsStackedWall { get; }
  IList<IRevitElementId> GetStackedWallMemberIds();
}
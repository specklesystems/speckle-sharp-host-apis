namespace Speckle.Revit.Interfaces;

public interface IRevitWall : IRevitHostObject
{
  IRevitCurtainGrid CurtainGrid { get; }
  bool IsStackedWall { get; }
  IList<IRevitElementId> GetStackedWallMemberIds();
}

namespace Speckle.Revit.Interfaces;

public interface IRevitWall : IRevitHostObject
{
  IRevitCurtainGrid CurtainGrid { get; }
  bool IsStackedWall { get; }
  IList<IRevitElementId> GetStackedWallMemberIds();
  IRevitWallType WallType { get; }
  bool Flipped { get; }
  IRevitElementId SketchId { get; }
}

public interface IRevitWallType : IRevitElementType
{
}

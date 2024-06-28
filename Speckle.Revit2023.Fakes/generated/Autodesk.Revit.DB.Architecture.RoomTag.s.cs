namespace Autodesk.Revit.DB.Architecture;

public partial class RoomTag : Autodesk.Revit.DB.SpatialElementTag
{
	public virtual Autodesk.Revit.DB.LinkElementId TaggedRoomId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId TaggedLocalRoomId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Architecture.RoomTagType RoomTagType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Architecture.Room Room
	{
		get => throw new System.NotImplementedException();
	}
}

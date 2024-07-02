namespace Rhino.DocObjects;

public partial class GripObject : Rhino.DocObjects.RhinoObject
{
	public GripObject() {}
	public virtual void Move(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual void Move(Rhino.Geometry.Vector3d delta) => throw new System.NotImplementedException();
	public virtual void Move(Rhino.Geometry.Point3d newLocation) => throw new System.NotImplementedException();
	public virtual void UndoMove() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.GripObject NeighborGrip(System.Int32 directionR,System.Int32 directionS,System.Int32 directionT,System.Boolean wrap) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d CurrentLocation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point3d OriginalLocation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Moved
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Weight
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid OwnerId
	{
		get => throw new System.NotImplementedException();
	}
	public override System.Int32 Index
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

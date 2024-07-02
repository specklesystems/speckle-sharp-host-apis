namespace Rhino.Display;

public partial class DisplayBitmapDrawList
{
	public DisplayBitmapDrawList() {}
	public virtual System.Int32[] Sort(Rhino.Geometry.Vector3d cameraDirection) => throw new System.NotImplementedException();
	public virtual void SetPoints(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.BoundingBox BoundingBox
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 MaximumCachedSortLists
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SortAngleTolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

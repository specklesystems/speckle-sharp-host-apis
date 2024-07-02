namespace Rhino.Geometry;

public partial class Unroller
{
	public Unroller() {}
	public Unroller(Rhino.Geometry.Surface surface) => throw new System.NotImplementedException();
	public Unroller(Rhino.Geometry.Brep brep) => throw new System.NotImplementedException();
	public virtual void AddFollowingGeometry(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves) => throw new System.NotImplementedException();
	public virtual void AddFollowingGeometry(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public virtual void AddFollowingGeometry(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) => throw new System.NotImplementedException();
	public virtual void AddFollowingGeometry(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual void AddFollowingGeometry(Rhino.Geometry.Point point) => throw new System.NotImplementedException();
	public virtual void AddFollowingGeometry(System.Collections.Generic.IEnumerable<Rhino.Geometry.TextDot> dots) => throw new System.NotImplementedException();
	public virtual void AddFollowingGeometry(Rhino.Geometry.TextDot dot) => throw new System.NotImplementedException();
	public virtual void AddFollowingGeometry(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> dotLocations,System.Collections.Generic.IEnumerable<System.String> dotText) => throw new System.NotImplementedException();
	public virtual void AddFollowingGeometry(Rhino.Geometry.Point3d dotLocation,System.String dotText) => throw new System.NotImplementedException();
	public virtual System.Int32 PerformUnroll(System.Collections.Generic.List<Rhino.Geometry.Brep> flatbreps) => throw new System.NotImplementedException();
	public virtual System.Int32 FollowingGeometryIndex(Rhino.Geometry.TextDot dot) => throw new System.NotImplementedException();
	public virtual System.Int32 FollowingGeometryIndex(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public virtual System.Boolean ExplodeOutput
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ExplodeSpacing
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AbsoluteTolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double RelativeTolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

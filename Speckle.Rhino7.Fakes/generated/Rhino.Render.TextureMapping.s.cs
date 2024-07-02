namespace Rhino.Render;

public partial class TextureMapping : Rhino.DocObjects.ModelComponent
{
	public TextureMapping() {}
	public virtual System.Int32 Evaluate(Rhino.Geometry.Point3d p,Rhino.Geometry.Vector3d n,out Rhino.Geometry.Point3d t) => throw new System.NotImplementedException();
	public virtual System.Int32 Evaluate(Rhino.Geometry.Point3d p,Rhino.Geometry.Vector3d n,out Rhino.Geometry.Point3d t,Rhino.Geometry.Transform pXform,Rhino.Geometry.Transform nXform) => throw new System.NotImplementedException();
	public virtual System.Boolean TryGetMappingBox(out Rhino.Geometry.Plane plane,out Rhino.Geometry.Interval dx,out Rhino.Geometry.Interval dy,out Rhino.Geometry.Interval dz) => throw new System.NotImplementedException();
	public virtual System.Boolean TryGetMappingBox(out Rhino.Geometry.Plane plane,out Rhino.Geometry.Interval dx,out Rhino.Geometry.Interval dy,out Rhino.Geometry.Interval dz,out System.Boolean capped) => throw new System.NotImplementedException();
	public virtual System.Boolean TryGetMappingSphere(out Rhino.Geometry.Sphere sphere) => throw new System.NotImplementedException();
	public virtual System.Boolean TryGetMappingCylinder(out Rhino.Geometry.Cylinder cylinder) => throw new System.NotImplementedException();
	public virtual System.Boolean TryGetMappingCylinder(out Rhino.Geometry.Cylinder cylinder,out System.Boolean capped) => throw new System.NotImplementedException();
	public virtual System.Boolean TryGetMappingPlane(out Rhino.Geometry.Plane plane,out Rhino.Geometry.Interval dx,out Rhino.Geometry.Interval dy,out Rhino.Geometry.Interval dz) => throw new System.NotImplementedException();
	public virtual System.Boolean TryGetMappingPlane(out Rhino.Geometry.Plane plane,out Rhino.Geometry.Interval dx,out Rhino.Geometry.Interval dy,out Rhino.Geometry.Interval dz,out System.Boolean capped) => throw new System.NotImplementedException();
	public virtual System.Boolean TryGetMappingMesh(out Rhino.Geometry.Mesh mesh) => throw new System.NotImplementedException();
	public static Rhino.Render.TextureMapping CreateSurfaceParameterMapping() => throw new System.NotImplementedException();
	public static Rhino.Render.TextureMapping CreatePlaneMapping(Rhino.Geometry.Plane plane,Rhino.Geometry.Interval dx,Rhino.Geometry.Interval dy,Rhino.Geometry.Interval dz) => throw new System.NotImplementedException();
	public static Rhino.Render.TextureMapping CreatePlaneMapping(Rhino.Geometry.Plane plane,Rhino.Geometry.Interval dx,Rhino.Geometry.Interval dy,Rhino.Geometry.Interval dz,System.Boolean capped) => throw new System.NotImplementedException();
	public static Rhino.Render.TextureMapping CreateCylinderMapping(Rhino.Geometry.Cylinder cylinder,System.Boolean capped) => throw new System.NotImplementedException();
	public static Rhino.Render.TextureMapping CreateSphereMapping(Rhino.Geometry.Sphere sphere) => throw new System.NotImplementedException();
	public static Rhino.Render.TextureMapping CreateBoxMapping(Rhino.Geometry.Plane plane,Rhino.Geometry.Interval dx,Rhino.Geometry.Interval dy,Rhino.Geometry.Interval dz,System.Boolean capped) => throw new System.NotImplementedException();
	public static Rhino.Render.TextureMapping CreateCustomMeshMapping(Rhino.Geometry.Mesh mesh) => throw new System.NotImplementedException();
	public virtual Rhino.Render.TextureMappingType MappingType
	{
		get => throw new System.NotImplementedException();
	}
	public new System.Guid Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Transform UvwTransform
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Transform PrimativeTransform
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Transform PrimitiveTransform
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Transform NormalTransform
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public new Rhino.DocObjects.ModelComponentType ComponentType
	{
		get => throw new System.NotImplementedException();
	}
}

namespace Rhino.Render;

public partial class RenderPrimitiveList : System.IDisposable
{
	public RenderPrimitiveList() {}
	public virtual Rhino.Geometry.Mesh ToMeshArray() => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderMaterial ToMaterialArray() => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Mesh mesh,Rhino.Render.RenderMaterial material) => throw new System.NotImplementedException();
	public virtual void Add(System.Collections.Generic.IEnumerable<Rhino.Geometry.Mesh> meshes,Rhino.Render.RenderMaterial material) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Mesh mesh,Rhino.Render.RenderMaterial material,Rhino.Geometry.Transform t) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Sphere sphere,Rhino.Render.RenderMaterial material) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Cone cone,Rhino.Geometry.Plane truncation,Rhino.Render.RenderMaterial material) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.PlaneSurface plane,Rhino.Render.RenderMaterial material) => throw new System.NotImplementedException();
	public virtual void Add(Rhino.Geometry.Box box,Rhino.Render.RenderMaterial material) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderPrimitiveType PrimitiveType(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Mesh Mesh(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderMaterial Material(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void ConvertMeshesToTriangles() => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Transform GetInstanceTransform(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void SetInstanceTransform(System.Int32 index,Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual System.Boolean AutoDeleteMeshesOn() => throw new System.NotImplementedException();
	public virtual System.Boolean AutoDeleteMaterialsOn() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean UseObjectsMappingChannels
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Count
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.RhinoObject RhinoObject
	{
		get => throw new System.NotImplementedException();
	}
}

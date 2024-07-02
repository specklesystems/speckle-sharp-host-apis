namespace Rhino.Render;

public partial class RenderPrimitive : System.IDisposable
{
	public RenderPrimitive() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Mesh Mesh() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.RhinoObject RhinoObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderPrimitiveType PrimitiveType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Transform InstanceTransform
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderMaterial RenderMaterial
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BoundingBox BoundingBox
	{
		get => throw new System.NotImplementedException();
	}
}

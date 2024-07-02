namespace Rhino.Render;

public partial class RenderPrimitive : System.IDisposable
{
  public RenderPrimitive() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh Mesh() => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetSphere(out Rhino.Geometry.Sphere sphere) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetBox(out Rhino.Geometry.Box box) => throw new System.NotImplementedException();

  public virtual System.Boolean TryGetPlane(out Rhino.Geometry.PlaneSurface plane) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean TryGetCone(out Rhino.Geometry.Cone cone, out Rhino.Geometry.Plane truncation) =>
    throw new System.NotImplementedException();

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

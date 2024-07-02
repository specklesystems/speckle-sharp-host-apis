namespace Rhino.DocObjects;

public partial class LightObject : Rhino.DocObjects.RhinoObject
{
  public LightObject() { }

  public virtual Rhino.Geometry.Light DuplicateLightGeometry() => throw new System.NotImplementedException();

  public new Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Light LightGeometry
  {
    get => throw new System.NotImplementedException();
  }
}

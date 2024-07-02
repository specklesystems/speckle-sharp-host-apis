namespace Rhino.DocObjects;

public partial class PointObject : Rhino.DocObjects.RhinoObject
{
  public PointObject() { }

  public virtual Rhino.Geometry.Point DuplicatePointGeometry() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point PointGeometry
  {
    get => throw new System.NotImplementedException();
  }
}

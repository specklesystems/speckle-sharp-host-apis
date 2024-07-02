namespace Rhino.DocObjects;

public partial class CurveObject : Rhino.DocObjects.RhinoObject
{
  public CurveObject() { }

  public virtual Rhino.Geometry.Curve DuplicateCurveGeometry() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve CurveGeometry
  {
    get => throw new System.NotImplementedException();
  }
}

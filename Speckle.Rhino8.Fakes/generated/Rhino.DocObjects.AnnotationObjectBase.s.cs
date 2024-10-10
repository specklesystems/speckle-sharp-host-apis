namespace Rhino.DocObjects;

public partial class AnnotationObjectBase : Rhino.DocObjects.RhinoObject
{
  public AnnotationObjectBase() { }

  public virtual System.String DisplayText
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.AnnotationBase AnnotationGeometry
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasMeasurableTextFields
  {
    get => throw new System.NotImplementedException();
  }
}

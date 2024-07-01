namespace Autodesk.Revit.DB;

public partial class GeometryElement
  : Autodesk.Revit.DB.GeometryObject,
    System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.GeometryObject>
{
  public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.GeometryObject> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.BoundingBoxXYZ GetBoundingBox() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.GeometryElement GetTransformed(Autodesk.Revit.DB.Transform transform) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Material MaterialElement
  {
    get => throw new System.NotImplementedException();
  }
}

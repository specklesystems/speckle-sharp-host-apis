namespace Autodesk.Revit.DB;

public partial class SketchPlane : Autodesk.Revit.DB.Element
{
  public SketchPlane() { }

  public static Autodesk.Revit.DB.SketchPlane Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId datumId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.SketchPlane Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Reference planarFaceReference
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.SketchPlane Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Plane plane
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Plane GetPlane() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetPlaneReference() => throw new System.NotImplementedException();

  public virtual System.Boolean IsSuitableForModelElements
  {
    get => throw new System.NotImplementedException();
  }
}

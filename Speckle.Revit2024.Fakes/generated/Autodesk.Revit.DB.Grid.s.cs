namespace Autodesk.Revit.DB;

public partial class Grid : Autodesk.Revit.DB.DatumPlane
{
  public Grid() { }

  public static Autodesk.Revit.DB.Grid Create(Autodesk.Revit.DB.Document document, Autodesk.Revit.DB.Arc arc) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Grid Create(Autodesk.Revit.DB.Document document, Autodesk.Revit.DB.Line line) =>
    throw new System.NotImplementedException();

  public virtual void SetVerticalExtents(System.Double bottom, System.Double top) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Outline GetExtents() => throw new System.NotImplementedException();

  public virtual System.Boolean IsCurved
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Curve Curve
  {
    get => throw new System.NotImplementedException();
  }
}

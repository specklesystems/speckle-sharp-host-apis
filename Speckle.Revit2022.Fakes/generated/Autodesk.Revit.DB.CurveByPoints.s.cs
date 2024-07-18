namespace Autodesk.Revit.DB;

public partial class CurveByPoints : Autodesk.Revit.DB.CurveElement
{
  public CurveByPoints() { }

  public virtual Autodesk.Revit.DB.ReferencePointArray GetPoints() => throw new System.NotImplementedException();

  public virtual void SetPoints(Autodesk.Revit.DB.ReferencePointArray points) =>
    throw new System.NotImplementedException();

  public static System.Boolean SortPoints(Autodesk.Revit.DB.ReferencePointArray arr) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FamilyElementVisibility GetVisibility() =>
    throw new System.NotImplementedException();

  public virtual void SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility visibility) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ReferenceType ReferenceType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Visible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.GraphicsStyle Subcategory
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsReferenceLine
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public new Autodesk.Revit.DB.SketchPlane SketchPlane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

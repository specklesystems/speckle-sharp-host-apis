namespace Autodesk.Revit.DB;

public partial class ColorFillLegend : Autodesk.Revit.DB.Element
{
  public ColorFillLegend() { }

  public static Autodesk.Revit.DB.ColorFillLegend Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewId,
    Autodesk.Revit.DB.ElementId catetoryId,
    Autodesk.Revit.DB.XYZ origin
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Double> GetColumnWidths() =>
    throw new System.NotImplementedException();

  public virtual void SetColumnWidths(System.Collections.Generic.IList<System.Double> widths) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ Origin
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId ColorFillCategoryId
  {
    get => throw new System.NotImplementedException();
  }
}

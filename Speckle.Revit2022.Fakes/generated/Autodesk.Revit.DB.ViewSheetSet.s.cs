namespace Autodesk.Revit.DB;

public partial class ViewSheetSet : Autodesk.Revit.DB.Element, Autodesk.Revit.DB.IViewSheetSet
{
  public ViewSheetSet() { }

  public virtual Autodesk.Revit.DB.ViewSet Views
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public new System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

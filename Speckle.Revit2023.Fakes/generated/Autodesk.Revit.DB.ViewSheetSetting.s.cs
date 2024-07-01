namespace Autodesk.Revit.DB;

public partial class ViewSheetSetting : Autodesk.Revit.DB.APIObject
{
  public virtual System.Boolean Save() => throw new System.NotImplementedException();

  public virtual System.Boolean SaveAs(System.String newName) => throw new System.NotImplementedException();

  public virtual System.Boolean Rename(System.String newName) => throw new System.NotImplementedException();

  public virtual System.Boolean Delete() => throw new System.NotImplementedException();

  public virtual void Revert() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.InSessionViewSheetSet InSession
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ViewSet AvailableViews
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.IViewSheetSet CurrentViewSheetSet
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

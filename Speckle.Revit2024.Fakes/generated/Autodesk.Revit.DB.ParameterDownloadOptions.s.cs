namespace Autodesk.Revit.DB;

public partial class ParameterDownloadOptions : System.IDisposable
{
  public ParameterDownloadOptions() { }

  public ParameterDownloadOptions(
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> categories,
    System.Boolean isInstance,
    System.Boolean visible,
    Autodesk.Revit.DB.ForgeTypeId groupTypeId
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetCategories() =>
    throw new System.NotImplementedException();

  public virtual void SetCategories(System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> categories) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ForgeTypeId GetGroupTypeId() => throw new System.NotImplementedException();

  public virtual void SetGroupTypeId(Autodesk.Revit.DB.ForgeTypeId groupTypeId) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Visible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsInstance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

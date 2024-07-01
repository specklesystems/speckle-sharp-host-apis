namespace Autodesk.Revit.DB;

public partial class SaveAsOptions : System.IDisposable
{
  public SaveAsOptions() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.WorksharingSaveAsOptions GetWorksharingOptions() =>
    throw new System.NotImplementedException();

  public virtual void SetWorksharingOptions(Autodesk.Revit.DB.WorksharingSaveAsOptions worksharingOptions) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Compact
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MaximumBackups
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId PreviewViewId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean OverwriteExistingFile
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Autodesk.Revit.DB;

public partial class FabricationItemFolder : System.IDisposable
{
  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFolder> GetSubFolders() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FabricationItemFile> GetItemFiles() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
  }
}

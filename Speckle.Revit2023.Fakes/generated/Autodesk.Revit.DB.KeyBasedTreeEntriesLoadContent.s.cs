namespace Autodesk.Revit.DB;

public partial class KeyBasedTreeEntriesLoadContent : Autodesk.Revit.DB.ExternalResourceLoadContent
{
  public virtual System.Boolean AddEntry(Autodesk.Revit.DB.KeyBasedTreeEntry entry) =>
    throw new System.NotImplementedException();

  public virtual void BuildEntries() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.KeyBasedTreeEntries GetEntries() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.KeyBasedTreeEntriesLoadResults GetLoadResults() =>
    throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public static System.Boolean IsEntriesBuilt(Autodesk.Revit.DB.KeyBasedTreeEntriesLoadContent content) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanAddEntry(Autodesk.Revit.DB.KeyBasedTreeEntry entry) =>
    throw new System.NotImplementedException();
}

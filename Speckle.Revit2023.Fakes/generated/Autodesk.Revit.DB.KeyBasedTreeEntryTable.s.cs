namespace Autodesk.Revit.DB;

public partial class KeyBasedTreeEntryTable : Autodesk.Revit.DB.Element
{
	public virtual System.Boolean ServerSupports(Autodesk.Revit.DB.ExternalResourceReference extRef) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalResourceLoadStatus LoadFrom(Autodesk.Revit.DB.ExternalResourceReference desiredResourceReference,Autodesk.Revit.DB.KeyBasedTreeEntriesLoadResults loadResults) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalResourceLoadStatus Reload(Autodesk.Revit.DB.KeyBasedTreeEntriesLoadResults loadResults) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.KeyBasedTreeEntries GetKeyBasedTreeEntries() => throw new System.NotImplementedException();
}

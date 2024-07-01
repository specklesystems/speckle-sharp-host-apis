namespace Autodesk.Revit.DB;

public partial class DocumentDifference : System.IDisposable
{
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetCreatedElementIds() => throw new System.NotImplementedException();
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetModifiedElementIds() => throw new System.NotImplementedException();
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetDeletedElementIds() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean AreDeletedElementIdsAvailable
	{
		get => throw new System.NotImplementedException();
	}
}

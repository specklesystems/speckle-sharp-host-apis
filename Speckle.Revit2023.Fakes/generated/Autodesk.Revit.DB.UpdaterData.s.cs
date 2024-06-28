namespace Autodesk.Revit.DB;

public partial class UpdaterData : System.Object
{
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetAddedElementIds() => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetDeletedElementIds() => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetModifiedElementIds() => throw new System.NotImplementedException();
	public virtual System.Boolean IsChangeTriggered(Autodesk.Revit.DB.ElementId id,Autodesk.Revit.DB.ChangeType type) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Document GetDocument() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}

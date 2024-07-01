namespace Autodesk.Revit.DB;

public partial class WorksetTable : System.IDisposable
{
	public virtual Autodesk.Revit.DB.Workset GetWorkset(System.Guid guid) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Workset GetWorkset(Autodesk.Revit.DB.WorksetId id) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksetId GetActiveWorksetId() => throw new System.NotImplementedException();
	public virtual void SetActiveWorksetId(Autodesk.Revit.DB.WorksetId worksetId) => throw new System.NotImplementedException();
	public static System.Boolean CanDeleteWorkset(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.WorksetId worksetId,Autodesk.Revit.DB.DeleteWorksetSettings deleteWorksetSettings) => throw new System.NotImplementedException();
	public static void DeleteWorkset(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.WorksetId worksetId,Autodesk.Revit.DB.DeleteWorksetSettings deleteWorksetSettings) => throw new System.NotImplementedException();
	public static void RenameWorkset(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.WorksetId worksetId,System.String name) => throw new System.NotImplementedException();
	public static System.Boolean IsWorksetNameUnique(Autodesk.Revit.DB.Document aDoc,System.String name) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}

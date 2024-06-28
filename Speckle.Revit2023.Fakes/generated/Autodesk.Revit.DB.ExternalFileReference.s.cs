namespace Autodesk.Revit.DB;

public partial class ExternalFileReference : System.Object
{
	public virtual Autodesk.Revit.DB.ModelPath GetPath() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelPath GetAbsolutePath() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkedFileStatus GetLinkedFileStatus() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetReferencingId() => throw new System.NotImplementedException();
	public static System.Boolean IsValidExternalFileReference(Autodesk.Revit.DB.ExternalFileReference data) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidPathTypeForExternalFileReference(Autodesk.Revit.DB.PathType pathType) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ExternalFileReferenceType ExternalFileReferenceType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PathType PathType
	{
		get => throw new System.NotImplementedException();
	}
}

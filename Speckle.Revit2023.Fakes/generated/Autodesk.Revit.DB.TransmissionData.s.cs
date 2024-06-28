namespace Autodesk.Revit.DB;

public partial class TransmissionData : System.Object
{
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetAllExternalFileReferenceIds() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalFileReference GetLastSavedReferenceData(Autodesk.Revit.DB.ElementId elemId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalFileReference GetDesiredReferenceData(Autodesk.Revit.DB.ElementId elemId) => throw new System.NotImplementedException();
	public virtual void SetDesiredReferenceData(Autodesk.Revit.DB.ElementId elemId,Autodesk.Revit.DB.ModelPath path,Autodesk.Revit.DB.PathType pathType,System.Boolean shouldLoad) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.TransmissionData ReadTransmissionData(Autodesk.Revit.DB.ModelPath path) => throw new System.NotImplementedException();
	public static void WriteTransmissionData(Autodesk.Revit.DB.ModelPath path,Autodesk.Revit.DB.TransmissionData data) => throw new System.NotImplementedException();
	public static System.Boolean IsDocumentTransmitted(Autodesk.Revit.DB.ModelPath filePath) => throw new System.NotImplementedException();
	public static System.Boolean DocumentIsNotTransmitted(Autodesk.Revit.DB.ModelPath filePath) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Version
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String UserData
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsTransmitted
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

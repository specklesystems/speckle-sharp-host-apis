namespace Autodesk.Revit.DB;

public partial class ExternalResourceReference : System.IDisposable
{
	public ExternalResourceReference() {}
	public ExternalResourceReference(Autodesk.Revit.DB.ExternalResourceReference other) => throw new System.NotImplementedException();
	public ExternalResourceReference(System.Guid serverId,System.Collections.Generic.IDictionary<System.String, System.String> referenceInformation,System.String version,System.String inSessionPath) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ExternalResourceReference CreateLocalResource(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.ExternalResourceType resourceType,Autodesk.Revit.DB.ModelPath path,Autodesk.Revit.DB.PathType pathType) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetReferenceInformation() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidReference(Autodesk.Revit.DB.ExternalResourceType resourceType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ResourceVersionStatus GetResourceVersionStatus() => throw new System.NotImplementedException();
	public virtual System.String GetResourceShortDisplayName() => throw new System.NotImplementedException();
	public virtual System.Boolean HasValidDisplayPath() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String InSessionPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Version
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid ServerId
	{
		get => throw new System.NotImplementedException();
	}
}

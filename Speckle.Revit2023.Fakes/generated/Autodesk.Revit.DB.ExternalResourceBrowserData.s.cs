namespace Autodesk.Revit.DB;

public partial class ExternalResourceBrowserData : System.Object
{
	public ExternalResourceBrowserData(Autodesk.Revit.DB.Document document,System.Guid serverId,System.String folderPath,Autodesk.Revit.DB.ExternalResourceMatchOptions matchOptions) => throw new System.NotImplementedException();
	public virtual void AddResource(System.String resourceName,System.String version,IDictionary<System.String, System.String> referenceInformation) => throw new System.NotImplementedException();
	public virtual void AddResource(System.String resourceName,System.String version) => throw new System.NotImplementedException();
	public virtual void AddResource(System.String resourceName,IDictionary<System.String, System.String> referenceInformation) => throw new System.NotImplementedException();
	public virtual void AddResource(System.String resourceName) => throw new System.NotImplementedException();
	public virtual void AddSubFolder(System.String folderName,System.String iconPath) => throw new System.NotImplementedException();
	public virtual void AddSubFolder(System.String folderName) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalResourceMatchOptions GetMatchOptions() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ExternalResourceReference> GetResources() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ExternalResourceSubFolder> GetSubFoldersData() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidResourceName(System.String resourceName) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidFolderName(System.String folderName) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelPath GetCallingDocumentModelPath() => throw new System.NotImplementedException();
	public virtual System.Boolean CallingDocumentHasModelPath() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String FolderPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid ServerId
	{
		get => throw new System.NotImplementedException();
	}
}

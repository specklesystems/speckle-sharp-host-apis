namespace Autodesk.Revit.DB;

public partial class IExternalResourceServer
{
	public virtual System.Boolean SupportsExternalResourceType(Autodesk.Revit.DB.ExternalResourceType type) => throw new System.NotImplementedException();
	public virtual void LoadResource(System.Guid loadRequestId,Autodesk.Revit.DB.ExternalResourceType resourceType,Autodesk.Revit.DB.ExternalResourceReference desiredResource,Autodesk.Revit.DB.ExternalResourceLoadContext loadContext,Autodesk.Revit.DB.ExternalResourceLoadContent loadResults) => throw new System.NotImplementedException();
	public virtual System.Boolean IsResourceWellFormed(Autodesk.Revit.DB.ExternalResourceReference extRef) => throw new System.NotImplementedException();
	public virtual System.String GetInSessionPath(Autodesk.Revit.DB.ExternalResourceReference reference,System.String originalDisplayPath) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ResourceVersionStatus GetResourceVersionStatus(Autodesk.Revit.DB.ExternalResourceReference reference) => throw new System.NotImplementedException();
	public virtual System.Boolean AreSameResources(IDictionary<System.String, System.String> reference1,IDictionary<System.String, System.String> reference2) => throw new System.NotImplementedException();
	public virtual void SetupBrowserData(Autodesk.Revit.DB.ExternalResourceBrowserData browseData) => throw new System.NotImplementedException();
	public virtual System.String GetIconPath() => throw new System.NotImplementedException();
	public virtual System.String GetShortName() => throw new System.NotImplementedException();
	public virtual void GetTypeSpecificServerOperations(Autodesk.Revit.DB.ExternalResourceServerExtensions extensions) => throw new System.NotImplementedException();
	public virtual System.String GetInformationLink() => throw new System.NotImplementedException();
}

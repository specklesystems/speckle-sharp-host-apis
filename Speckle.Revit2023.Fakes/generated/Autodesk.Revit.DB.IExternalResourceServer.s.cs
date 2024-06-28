namespace Autodesk.Revit.DB;

public partial class IExternalResourceServer
{
	public virtual Autodesk.Revit.DB.ResourceVersionStatus GetResourceVersionStatus(Autodesk.Revit.DB.ExternalResourceReference reference) => throw new System.NotImplementedException();
	public virtual void SetupBrowserData(Autodesk.Revit.DB.ExternalResourceBrowserData browseData) => throw new System.NotImplementedException();
	public virtual void GetTypeSpecificServerOperations(Autodesk.Revit.DB.ExternalResourceServerExtensions extensions) => throw new System.NotImplementedException();
}

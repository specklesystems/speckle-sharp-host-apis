namespace Autodesk.Revit.DB;

public partial interface IExternalResourceServer
{
  public System.Boolean SupportsExternalResourceType(Autodesk.Revit.DB.ExternalResourceType type);
  public void LoadResource(
    System.Guid loadRequestId,
    Autodesk.Revit.DB.ExternalResourceType resourceType,
    Autodesk.Revit.DB.ExternalResourceReference desiredResource,
    Autodesk.Revit.DB.ExternalResourceLoadContext loadContext,
    Autodesk.Revit.DB.ExternalResourceLoadContent loadResults
  );
  public System.Boolean IsResourceWellFormed(Autodesk.Revit.DB.ExternalResourceReference extRef);
  public System.String GetInSessionPath(
    Autodesk.Revit.DB.ExternalResourceReference reference,
    System.String originalDisplayPath
  );
  public Autodesk.Revit.DB.ResourceVersionStatus GetResourceVersionStatus(
    Autodesk.Revit.DB.ExternalResourceReference reference
  );
  public System.Boolean AreSameResources(
    System.Collections.Generic.IDictionary<System.String, System.String> reference1,
    System.Collections.Generic.IDictionary<System.String, System.String> reference2
  );
  public void SetupBrowserData(Autodesk.Revit.DB.ExternalResourceBrowserData browseData);
  public System.String GetIconPath();
  public System.String GetShortName();
  public void GetTypeSpecificServerOperations(Autodesk.Revit.DB.ExternalResourceServerExtensions extensions);
  public System.String GetInformationLink();
}

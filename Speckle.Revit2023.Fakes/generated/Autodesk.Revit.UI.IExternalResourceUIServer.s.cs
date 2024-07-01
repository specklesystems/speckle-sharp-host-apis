namespace Autodesk.Revit.UI;

public partial interface IExternalResourceUIServer
{
	public  System.Guid GetDBServerId();
	public  void HandleLoadResourceResults(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.ExternalResourceLoadData> loadData);
	public  void HandleBrowseResult(Autodesk.Revit.DB.ExternalResourceUIBrowseResultType resultType,System.String browsingItemPath);
}

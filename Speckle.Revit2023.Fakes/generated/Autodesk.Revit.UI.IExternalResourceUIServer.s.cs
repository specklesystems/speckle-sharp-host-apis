namespace Autodesk.Revit.UI;

public partial class IExternalResourceUIServer
{
	public virtual System.Guid GetDBServerId() => throw new System.NotImplementedException();
	public virtual void HandleLoadResourceResults(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.ExternalResourceLoadData> loadData) => throw new System.NotImplementedException();
	public virtual void HandleBrowseResult(Autodesk.Revit.DB.ExternalResourceUIBrowseResultType resultType,System.String browsingItemPath) => throw new System.NotImplementedException();
}

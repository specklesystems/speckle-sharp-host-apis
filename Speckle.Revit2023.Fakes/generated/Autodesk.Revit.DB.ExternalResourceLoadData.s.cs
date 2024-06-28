namespace Autodesk.Revit.DB;

public partial class ExternalResourceLoadData : System.Object
{
	public virtual Autodesk.Revit.DB.ExternalResourceReference GetExternalResourceReference() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalResourceLoadContent GetLoadContent() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalResourceLoadContext GetLoadContext() => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.ExternalResourceLoadStatus LoadStatus
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ExternalResourceType ExternalResourceType
	{
		get => throw new System.NotImplementedException();
	}
}

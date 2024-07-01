namespace Autodesk.Revit.DB;

public partial class LinkLoadResult : System.Object
{
	public LinkLoadResult(Autodesk.Revit.DB.LinkLoadResult other) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelPath GetModelName() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelPath GetParentModelName() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelPath GetCentralModelName() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalResourceReference GetExternalResourceReference() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkLoadResult GetLinkLoadResult(Autodesk.Revit.DB.ExternalResourceReference matchExtResRef) => throw new System.NotImplementedException();
	public virtual IDictionary<System.String, Autodesk.Revit.DB.LinkLoadResult> GetNestedLinkLoadResults() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ExternalResourceReference> GetExternalResourceReferencesFromFailedLoads() => throw new System.NotImplementedException();
	public static System.Boolean IsCodeSuccess(Autodesk.Revit.DB.LinkLoadResultType code) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.LinkLoadResultType LoadResult
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsNested
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsCircularLink
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId ElementId
	{
		get => throw new System.NotImplementedException();
	}
}

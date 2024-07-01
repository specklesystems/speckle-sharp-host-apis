namespace Autodesk.Revit.DB;

public partial class FilteredWorksetCollector : System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.Workset>,System.IDisposable
{
	public FilteredWorksetCollector(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredWorksetIdIterator GetWorksetIdIterator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredWorksetIterator GetWorksetIterator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredWorksetCollector WherePasses(Autodesk.Revit.DB.WorksetFilter filter) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredWorksetCollector OfKind(Autodesk.Revit.DB.WorksetKind worksetKind) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.WorksetId> ToWorksetIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Workset> ToWorksets() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksetId FirstWorksetId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Workset FirstWorkset() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Workset> GetEnumerator() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}

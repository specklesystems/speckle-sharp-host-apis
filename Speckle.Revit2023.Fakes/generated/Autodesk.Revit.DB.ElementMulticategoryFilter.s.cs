namespace Autodesk.Revit.DB;

public partial class ElementMulticategoryFilter : Autodesk.Revit.DB.ElementQuickFilter
{
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetCategoryIds() => throw new System.NotImplementedException();
}

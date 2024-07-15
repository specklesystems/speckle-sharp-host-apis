namespace Autodesk.Revit.DB;

public partial class ElementIdSetFilter : Autodesk.Revit.DB.ElementQuickFilter
{
	public ElementIdSetFilter() {}
	public ElementIdSetFilter(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> idsToInclude) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetIdsToInclude() => throw new System.NotImplementedException();
}

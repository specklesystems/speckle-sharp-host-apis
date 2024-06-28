namespace Autodesk.Revit.DB;

public partial class ExclusionFilter : Autodesk.Revit.DB.ElementQuickFilter
{
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetIdsToExclude() => throw new System.NotImplementedException();
}

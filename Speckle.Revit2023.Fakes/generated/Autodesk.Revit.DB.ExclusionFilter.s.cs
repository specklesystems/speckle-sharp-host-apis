namespace Autodesk.Revit.DB;

public partial class ExclusionFilter : Autodesk.Revit.DB.ElementQuickFilter
{
  public ExclusionFilter(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> idsToExclude) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetIdsToExclude() =>
    throw new System.NotImplementedException();
}

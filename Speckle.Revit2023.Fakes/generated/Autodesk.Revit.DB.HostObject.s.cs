namespace Autodesk.Revit.DB;

public partial class HostObject : Autodesk.Revit.DB.Element
{
  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> FindInserts(
    System.Boolean addRectOpenings,
    System.Boolean includeShadows,
    System.Boolean includeEmbeddedWalls,
    System.Boolean includeSharedEmbeddedInserts
  ) => throw new System.NotImplementedException();
}

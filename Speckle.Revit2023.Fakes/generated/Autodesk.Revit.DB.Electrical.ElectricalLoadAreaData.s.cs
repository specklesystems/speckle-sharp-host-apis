namespace Autodesk.Revit.DB.Electrical;

public partial class ElectricalLoadAreaData : Autodesk.Revit.DB.SpatialElementDomainData
{
  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAreaBasedLoadIds() =>
    throw new System.NotImplementedException();

  public static System.Boolean HasCircuitsWithoutElectricalLoadAreas(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId levelId,
    Autodesk.Revit.DB.ElementId phaseId
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> CreateElectricalLoadAreas(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId levelId,
    Autodesk.Revit.DB.ElementId phaseId
  ) => throw new System.NotImplementedException();
}

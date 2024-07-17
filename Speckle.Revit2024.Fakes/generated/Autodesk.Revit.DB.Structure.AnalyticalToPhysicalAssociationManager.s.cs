namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalToPhysicalAssociationManager : Autodesk.Revit.DB.Element
{
  public AnalyticalToPhysicalAssociationManager() { }

  public static Autodesk.Revit.DB.Structure.AnalyticalToPhysicalAssociationManager GetAnalyticalToPhysicalAssociationManager(
    Autodesk.Revit.DB.Document doc
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasAssociation(Autodesk.Revit.DB.ElementId id) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsAnalyticalElement(Autodesk.Revit.DB.Document doc, Autodesk.Revit.DB.ElementId id) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsPhysicalElement(Autodesk.Revit.DB.Document doc, Autodesk.Revit.DB.ElementId id) =>
    throw new System.NotImplementedException();

  public virtual void AddAssociation(
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> analyticalElementIds,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> physicalElementIds
  ) => throw new System.NotImplementedException();

  public virtual void AddAssociation(
    Autodesk.Revit.DB.ElementId analyticalElementId,
    Autodesk.Revit.DB.ElementId physicalElementId
  ) => throw new System.NotImplementedException();

  public virtual void RemoveAssociation(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetAssociatedElementId(Autodesk.Revit.DB.ElementId elementId) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAssociatedElementIds(
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public static System.Boolean EnableAssistedAssociation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Autodesk.Revit.DB.Analysis;

public partial class MassEnergyAnalyticalModel : Autodesk.Revit.DB.Element
{
  public MassEnergyAnalyticalModel() { }

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetMassZoneIds() =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Reference GetCoincidentEnergyAnalyticalModelFaceReference(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Reference referenceToFace
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetCoincidentMassZoneFaceReferences(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Reference referenceToFace
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetMassSurfaceDataIdForReference(Autodesk.Revit.DB.Reference reference) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetMassEnergyAnalyticalModelIdForMassInstance(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId massInstanceId
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetJoinedMassEnergyAnalyticalModelElementIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetReferencesToAllFaces() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetReferencesToAllShadingFaces() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId MassId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double MassZoneCoreOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

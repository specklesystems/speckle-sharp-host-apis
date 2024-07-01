namespace Autodesk.Revit.DB.Analysis;

public partial class MassZone : Autodesk.Revit.DB.Element
{
  public virtual System.Boolean IsEmpty() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetEquivalentReferenceFromMassOrLevel(
    Autodesk.Revit.DB.Reference referenceToZoneFace
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetCoincidentReferenceFromAdjacentZone(
    Autodesk.Revit.DB.Reference referenceToZoneFace
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetReferencesToEnergyAnalysisFaces() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetMassDataElementIdForZoneFaceReference(
    Autodesk.Revit.DB.Reference referenceOfZone
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId SpaceTypeId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.gbXMLSpaceType SpaceType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.gbXMLConditionType ConditionType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.MassZoneLevelCutState CutByUpperLevel
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Analysis.MassZoneLevelCutState CutByLowerLevel
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId MassEnergyAnalyticalModelId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsZoneOccupiable
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Analysis.MassZoneMaterialType MaterialType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId MaterialId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId UpperLevelId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId LowerLevelId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double FloorArea
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Volume
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB.Analysis;

public partial class MassLevelData : Autodesk.Revit.DB.Element
{
  public MassLevelData() { }

  public virtual System.Boolean IsEmpty() => throw new System.NotImplementedException();

  public static System.Boolean IsMassFamilyInstance(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId id
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidConceptualConstructionTypeElement(Autodesk.Revit.DB.ElementId id) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ConceptualConstructionIsByEnergyData
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId ConceptualConstructionId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId MaterialId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId OwningMassId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType MaterialType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double NLevelPerimeter
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double NLevelFafArea
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double NExteriorSurfaceArea
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double NVolume
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String StrUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

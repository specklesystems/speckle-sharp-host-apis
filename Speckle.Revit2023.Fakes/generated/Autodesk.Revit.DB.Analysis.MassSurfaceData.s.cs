namespace Autodesk.Revit.DB.Analysis;

public partial class MassSurfaceData : Autodesk.Revit.DB.Element
{
  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetFaceReferences() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId ReferenceElementId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId CategoryIdForConceptualSurfaceType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSlab
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsUnderground
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsGlazingShaded
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsConceptualConstructionByEnergyData
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.MassSurfaceDataMaterialType MaterialType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId MaterialId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId MassLevelDataId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId ConceptualConstructionId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Analysis.MassSurfaceDataSource SurfaceDataSource
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SkylightWidth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PercentageSkylights
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SillHeight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ShadeDepth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PercentageGlazing
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Area
  {
    get => throw new System.NotImplementedException();
  }
}

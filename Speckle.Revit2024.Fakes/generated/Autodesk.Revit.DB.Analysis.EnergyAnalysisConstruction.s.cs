namespace Autodesk.Revit.DB.Analysis;

public partial class EnergyAnalysisConstruction : Autodesk.Revit.DB.Element
{
  public EnergyAnalysisConstruction() { }

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetMaterialIds() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Roughness
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Absorptance
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ThermalMass
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ThermalResistance
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double HeatTransferCoefficient
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ConstructionName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSchematic
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB.Analysis;

public partial class EnergyAnalysisWindowType : Autodesk.Revit.DB.Element
{
  public EnergyAnalysisWindowType() { }

  public virtual System.Collections.Generic.IDictionary<
    System.Double,
    System.Double
  > GetSolarHeatGainCoefficientsForSolarIndicientAngles() => throw new System.NotImplementedException();

  public virtual System.Double Transmittance
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double SolarHeatGainCoefficient
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
  public virtual System.String WindowTypeName
  {
    get => throw new System.NotImplementedException();
  }
}

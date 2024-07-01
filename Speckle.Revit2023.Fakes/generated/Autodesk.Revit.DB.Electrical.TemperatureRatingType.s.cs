namespace Autodesk.Revit.DB.Electrical;

public partial class TemperatureRatingType : Autodesk.Revit.DB.ElementType
{
  public TemperatureRatingType() { }

  public virtual Autodesk.Revit.DB.Electrical.InsulationType AddInsulationType(System.String name) =>
    throw new System.NotImplementedException();

  public virtual void RemoveInsulationType(Autodesk.Revit.DB.Electrical.InsulationType insulationType) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.WireSize AddWireSize(
    System.String size,
    System.Int64 ampacity,
    System.Double diameter
  ) => throw new System.NotImplementedException();

  public virtual void RemoveWireSize(Autodesk.Revit.DB.Electrical.WireSize wireSize) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.CorrectionFactor AddCorrectionFactor(
    System.Double temperature,
    System.Double factor
  ) => throw new System.NotImplementedException();

  public virtual void RemoveCorrectionFactor(Autodesk.Revit.DB.Electrical.CorrectionFactor correctionFactor) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsInUse
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Electrical.CorrectionFactorSet CorrectionFactors
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Electrical.WireSizeSet WireSizes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Electrical.InsulationTypeSet InsulationTypes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Electrical.WireMaterialType MaterialType
  {
    get => throw new System.NotImplementedException();
  }
  public new System.String Name
  {
    set { }
  }
}

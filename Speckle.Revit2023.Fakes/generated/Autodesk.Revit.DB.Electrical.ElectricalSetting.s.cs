namespace Autodesk.Revit.DB.Electrical;

public partial class ElectricalSetting : Autodesk.Revit.DB.Element
{
  public virtual Autodesk.Revit.DB.Electrical.VoltageType AddVoltageType(
    System.String name,
    System.Double actualValue,
    System.Double minValue,
    System.Double maxValue
  ) => throw new System.NotImplementedException();

  public virtual void RemoveVoltageType(Autodesk.Revit.DB.Electrical.VoltageType voltageType) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.DistributionSysType AddDistributionSysType(
    System.String name,
    Autodesk.Revit.DB.Electrical.ElectricalPhase phase,
    Autodesk.Revit.DB.Electrical.ElectricalPhaseConfiguration phaseConfig,
    System.Int32 numWire,
    Autodesk.Revit.DB.Electrical.VoltageType volLineToLine,
    Autodesk.Revit.DB.Electrical.VoltageType volLineToGround
  ) => throw new System.NotImplementedException();

  public virtual void RemoveDistributionSysType(Autodesk.Revit.DB.Electrical.DistributionSysType distributionSysType) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.WireMaterialType AddWireMaterialType(
    System.String name,
    Autodesk.Revit.DB.Electrical.WireMaterialType baseMaterial
  ) => throw new System.NotImplementedException();

  public virtual void RemoveWireMaterialType(Autodesk.Revit.DB.Electrical.WireMaterialType materialType) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.WireType AddWireType(
    System.String name,
    Autodesk.Revit.DB.Electrical.WireMaterialType materialType,
    Autodesk.Revit.DB.Electrical.TemperatureRatingType temperatureRating,
    Autodesk.Revit.DB.Electrical.InsulationType insulation,
    Autodesk.Revit.DB.Electrical.WireSize maxSize,
    System.Double neutralMultiplier,
    System.Boolean neutralRequired,
    Autodesk.Revit.DB.Electrical.NeutralMode neutralMode,
    Autodesk.Revit.DB.Electrical.WireConduitType conduit
  ) => throw new System.NotImplementedException();

  public virtual void RemoveWireType(Autodesk.Revit.DB.Electrical.WireType wireType) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Electrical.ElectricalSetting GetElectricalSettings(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Electrical.CircuitNamingSchemeSettings GetCircuitNamingSchemeSettings(
    Autodesk.Revit.DB.Document cda
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Double> GetSpecificFittingAngles() =>
    throw new System.NotImplementedException();

  public virtual void SetSpecificFittingAngleStatus(System.Double angle, System.Boolean bStatus) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetSpecificFittingAngleStatus(System.Double angle) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidSpecificFittingAngle(System.Double angle) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.CircuitSequence CircuitSequence
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Electrical.CircuitLoadCalculationMethod CircuitLoadCalculationMethod
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CircuitPathOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CircuitRating
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String CircuitNamePhaseC
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String CircuitNamePhaseB
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String CircuitNamePhaseA
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Electrical.WireConduitTypeSet WireConduitTypes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Electrical.WireMaterialTypeSet WireMaterialTypes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Electrical.DistributionSysTypeSet DistributionSysTypes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Electrical.WireTypeSet WireTypes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Electrical.VoltageTypeSet VoltageTypes
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB.Mechanical;

public partial class Zone : Autodesk.Revit.DB.Element
{
  public Zone() { }

  public virtual System.Boolean AddSpaces(Autodesk.Revit.DB.Mechanical.SpaceSet spaces) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean RemoveSpaces(Autodesk.Revit.DB.Mechanical.SpaceSet spaces) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Mechanical.Zone CreateAreaBasedLoad(
    Autodesk.Revit.DB.Document doc,
    System.String name,
    Autodesk.Revit.DB.ElementId levelId,
    Autodesk.Revit.DB.ElementId phaseId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.ZoneElementDomainData GetDomainData() =>
    throw new System.NotImplementedException();

  public virtual System.Double DehumidificationSetPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double HumidificationSetPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CoolingAirTemperature
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double HeatingAirTemperature
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CoolingSetPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double HeatingSetPoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CalculatedCoolingLoad
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double CalculatedHeatingLoad
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double CalculatedSupplyAirflow
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ServiceType ServiceType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.CurveArray Boundary
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Mechanical.SpaceSet Spaces
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Perimeter
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double GrossVolume
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Volume
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double GrossArea
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Area
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsDefaultZone
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Phase Phase
  {
    get => throw new System.NotImplementedException();
  }
  public override System.String Name
  {
    set { }
  }
}

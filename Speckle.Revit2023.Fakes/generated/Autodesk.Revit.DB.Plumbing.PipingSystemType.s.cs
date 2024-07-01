namespace Autodesk.Revit.DB.Plumbing;

public partial class PipingSystemType : Autodesk.Revit.DB.MEPSystemType
{
  public static Autodesk.Revit.DB.Plumbing.PipingSystemType Create(
    Autodesk.Revit.DB.Document ADoc,
    Autodesk.Revit.DB.MEPSystemClassification systemClassification,
    System.String name
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean ValidateRiseDropSymbolType(Autodesk.Revit.DB.Mechanical.RiseDropSymbol risedropType) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId FluidType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FluidTemperature
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Mechanical.RiseDropSymbol SingleLineJunctionDropType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Mechanical.RiseDropSymbol SingleLineJunctionRiseType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Mechanical.RiseDropSymbol SingleLineBendDropType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Mechanical.RiseDropSymbol SingleLineBendRiseType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Mechanical.RiseDropSymbol TwoLineDropType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Mechanical.RiseDropSymbol TwoLineRiseType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Plumbing.FlowConversionMode FlowConversionMethod
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

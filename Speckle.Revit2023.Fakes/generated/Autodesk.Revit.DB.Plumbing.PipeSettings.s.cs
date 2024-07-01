namespace Autodesk.Revit.DB.Plumbing;

public partial class PipeSettings : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.Plumbing.PipeSettings GetPipeSettings(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Double> GetPipeSlopes() =>
    throw new System.NotImplementedException();

  public virtual void SetPipeSlopes(System.Collections.Generic.IList<System.Double> slopes) =>
    throw new System.NotImplementedException();

  public virtual void AddPipeSlope(System.Double slope) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Double> GetSpecificFittingAngles() =>
    throw new System.NotImplementedException();

  public virtual void SetSpecificFittingAngleStatus(System.Double angle, System.Boolean bStatus) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetSpecificFittingAngleStatus(System.Double angle) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsAnalysisForClosedLoopHydronicPipingNetworksEnabled(Autodesk.Revit.DB.Document ccda) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidSpecificFittingAngle(System.Double angle) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.MEPCalculationServerInfo GetFlowConvertionServerInfo() =>
    throw new System.NotImplementedException();

  public virtual void SetFlowConvertionServerInfo(Autodesk.Revit.DB.MEPCalculationServerInfo serverInfo) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean AnalysisForClosedLoopHydronicPipingNetworks
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseAnnotationScaleForSingleLineFittings
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FittingAnnotationSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ConnectorTolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ConnectorSeparator
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String SizePrefix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String SizeSuffix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.FittingAngleUsage FittingAngleUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Centerline
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String SetDownFromBottom
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String SetUpFromBottom
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String SetDown
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String SetUp
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String FlatOnBottom
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String FlatOnTop
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

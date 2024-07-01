namespace Autodesk.Revit.DB.Mechanical;

public partial class DuctSettings : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.Mechanical.DuctSettings GetDuctSettings(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<System.Double> GetSpecificFittingAngles() =>
    throw new System.NotImplementedException();

  public virtual void SetSpecificFittingAngleStatus(System.Double angle, System.Boolean useInLayout) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetSpecificFittingAngleStatus(System.Double angle) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidSpecificFittingAngle(System.Double angle) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.MEPCalculationServerInfo GetPressLossCalculationServerInfo() =>
    throw new System.NotImplementedException();

  public virtual void SetPressLossCalculationServerInfo(Autodesk.Revit.DB.MEPCalculationServerInfo serverInfo) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean UseAnnotationScaleForSingleLineFittings
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.FittingAngleUsage FittingAngleUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double RiseDropAnnotationSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FittingAnnotationSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double AirViscosity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double AirDensity
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
  public virtual System.String OvalDuctSizeSuffix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String OvalDuctSizeSeparator
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ConnectorSeparator
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String RoundDuctSizePrefix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String RoundDuctSizeSuffix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String RectangularDuctSizeSuffix
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String RectangularDuctSizeSeparator
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

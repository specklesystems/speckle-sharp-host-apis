namespace Autodesk.Revit.DB.Electrical;

public partial class CorrectionFactor : Autodesk.Revit.DB.APIObject
{
  public CorrectionFactor() { }

  public virtual System.Double GetTemperature() => throw new System.NotImplementedException();

  public virtual System.Double Factor
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int64 Temperature
  {
    get => throw new System.NotImplementedException();
  }
}

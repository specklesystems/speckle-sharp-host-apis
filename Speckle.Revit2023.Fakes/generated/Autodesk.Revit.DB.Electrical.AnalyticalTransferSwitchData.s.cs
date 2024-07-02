namespace Autodesk.Revit.DB.Electrical;

public partial class AnalyticalTransferSwitchData : Autodesk.Revit.DB.Electrical.AnalyticalDistributionNodePropertyData
{
  public AnalyticalTransferSwitchData() { }

  public virtual System.Double TotalConnectedCurrent
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double CurrentRating
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Voltage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

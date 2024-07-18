namespace Autodesk.Revit.DB.Structure;

public partial class FabricRoundingManager : Autodesk.Revit.DB.Structure.ReinforcementRoundingManager
{
  public FabricRoundingManager() { }

  public virtual Autodesk.Revit.DB.RoundingMethod ApplicableSegmentLengthRoundingMethod
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ApplicableSegmentLengthRounding
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.RoundingMethod ApplicableTotalLengthRoundingMethod
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ApplicableTotalLengthRounding
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.RoundingMethod SegmentLengthRoundingMethod
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SegmentLengthRounding
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.RoundingMethod TotalLengthRoundingMethod
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double TotalLengthRounding
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.ReinforcementRoundingSource ApplicableReinforcementRoundingSource
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB.Structure;

public partial class RebarCoupler : Autodesk.Revit.DB.Element
{
  public RebarCoupler() { }

  public static Autodesk.Revit.DB.Structure.RebarCoupler Create(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId typeId,
    Autodesk.Revit.DB.Structure.ReinforcementData pFirstData,
    Autodesk.Revit.DB.Structure.ReinforcementData pSecondData,
    out Autodesk.Revit.DB.Structure.RebarCouplerError error
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CouplerLinkTwoBars() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.ReinforcementData> GetCoupledReinforcementData() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetPointsForPlacement() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetCouplerPositionTransform(System.Int32 couplerPositionIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsUnobscuredInView(Autodesk.Revit.DB.View view) =>
    throw new System.NotImplementedException();

  public virtual void SetUnobscuredInView(Autodesk.Revit.DB.View view, System.Boolean unobscured) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetCouplerQuantity() => throw new System.NotImplementedException();

  public virtual System.String CouplerMark
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

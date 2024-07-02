namespace Autodesk.Revit.DB.Structure;

public partial class RebarCoupler : Autodesk.Revit.DB.Element
{
	public RebarCoupler() {}
	public virtual System.Boolean CouplerLinkTwoBars() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.ReinforcementData> GetCoupledReinforcementData() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetPointsForPlacement() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetCouplerPositionTransform(System.Int32 couplerPositionIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnobscuredInView(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void SetUnobscuredInView(Autodesk.Revit.DB.View view,System.Boolean unobscured) => throw new System.NotImplementedException();
	public virtual System.Int32 GetCouplerQuantity() => throw new System.NotImplementedException();
	public virtual System.Double RotationAngle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String CouplerMark
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

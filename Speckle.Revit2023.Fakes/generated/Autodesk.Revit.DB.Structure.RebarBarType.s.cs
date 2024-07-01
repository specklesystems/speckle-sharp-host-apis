namespace Autodesk.Revit.DB.Structure;

public partial class RebarBarType : Autodesk.Revit.DB.ElementType
{
	public virtual void SetBarTypeDiameters(Autodesk.Revit.DB.BarTypeDiameterOptions diametersOptions) => throw new System.NotImplementedException();
	public virtual System.Boolean GetHookPermission(Autodesk.Revit.DB.ElementId hookId) => throw new System.NotImplementedException();
	public virtual void SetHookPermission(Autodesk.Revit.DB.ElementId hookId,System.Boolean permission) => throw new System.NotImplementedException();
	public virtual System.Boolean GetAutoCalcHookLengths(Autodesk.Revit.DB.ElementId hookId) => throw new System.NotImplementedException();
	public virtual void SetAutoCalcHookLengths(Autodesk.Revit.DB.ElementId hookId,System.Boolean autoCalculated) => throw new System.NotImplementedException();
	public virtual System.Double GetHookLength(Autodesk.Revit.DB.ElementId hookId) => throw new System.NotImplementedException();
	public virtual void SetHookLength(Autodesk.Revit.DB.ElementId hookId,System.Double hookLength) => throw new System.NotImplementedException();
	public virtual System.Double GetHookTangentLength(Autodesk.Revit.DB.ElementId hookId) => throw new System.NotImplementedException();
	public virtual void SetHookTangentLength(Autodesk.Revit.DB.ElementId hookId,System.Double newLength) => throw new System.NotImplementedException();
	public virtual System.Double GetHookOffsetLength(Autodesk.Revit.DB.ElementId hookId) => throw new System.NotImplementedException();
	public virtual void SetHookOffsetLength(Autodesk.Revit.DB.ElementId hookId,System.Double newLength) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.RebarBarType Create(Autodesk.Revit.DB.Document ADoc) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarRoundingManager GetReinforcementRoundingManager() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ElementId CreateDefaultRebarBarType(Autodesk.Revit.DB.Document ADoc) => throw new System.NotImplementedException();
	public virtual System.Double BarNominalDiameter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double BarModelDiameter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double StirrupTieBendDiameter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double StandardHookBendDiameter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double StandardBendDiameter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.RebarDeformationType DeformationType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double MaximumBendRadius
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

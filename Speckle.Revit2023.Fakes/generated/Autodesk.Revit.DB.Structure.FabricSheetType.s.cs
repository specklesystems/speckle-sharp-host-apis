namespace Autodesk.Revit.DB.Structure;

public partial class FabricSheetType : Autodesk.Revit.DB.ElementType
{
	public FabricSheetType() {}
	public static Autodesk.Revit.DB.ElementId CreateDefaultFabricSheetType(Autodesk.Revit.DB.Document ADoc) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.FabricRoundingManager GetReinforcementRoundingManager() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidMajorLapSplice(System.Double majorLapSplice) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidMinorLapSplice(System.Double minorLapSplice) => throw new System.NotImplementedException();
	public virtual void SetMajorLayoutAsActualSpacing(System.Double overallWidth,System.Double minorStartOverhang,System.Double spacing) => throw new System.NotImplementedException();
	public virtual void SetMajorLayoutAsMaximumSpacing(System.Double overallWidth,System.Double minorStartOverhang,System.Double minorEndOverhang,System.Double spacing) => throw new System.NotImplementedException();
	public virtual void SetMajorLayoutAsFixedNumber(System.Double overallWidth,System.Double minorStartOverhang,System.Double minorEndOverhang,System.Int32 numberOfWires) => throw new System.NotImplementedException();
	public virtual void SetMajorLayoutAsNumberWithSpacing(System.Double overallWidth,System.Double minorStartOverhang,System.Int32 numberOfWires,System.Double spacing) => throw new System.NotImplementedException();
	public virtual void SetMinorLayoutAsActualSpacing(System.Double overallLength,System.Double majorStartOverhang,System.Double spacing) => throw new System.NotImplementedException();
	public virtual void SetMinorLayoutAsMaximumSpacing(System.Double overallLength,System.Double majorStartOverhang,System.Double majorEndOverhang,System.Double spacing) => throw new System.NotImplementedException();
	public virtual void SetMinorLayoutAsFixedNumber(System.Double overallLength,System.Double majorStartOverhang,System.Double majorEndOverhang,System.Int32 numberOfWires) => throw new System.NotImplementedException();
	public virtual void SetMinorLayoutAsNumberWithSpacing(System.Double overallLength,System.Double majorStartOverhang,System.Int32 numberOfWires,System.Double spacing) => throw new System.NotImplementedException();
	public virtual void SetLayoutAsCustomPattern(System.Double minorStartOverhang,System.Double majorStartOverhang,System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.FabricWireItem> minorFabricWireItems,System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.FabricWireItem> majorFabricWireItems) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCustom() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.FabricWireItem GetWireItem(System.Int32 wireIndex,Autodesk.Revit.DB.Structure.WireDistributionDirection direction) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId Material
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double MinorReinforcementArea
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double MajorReinforcementArea
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double SheetMassUnit
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double SheetMass
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double MinorSpacing
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 MinorNumberOfWires
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern MinorLayoutPattern
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double MinorEndOverhang
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double MinorStartOverhang
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double OverallWidth
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double MajorSpacing
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 MajorNumberOfWires
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.FabricSheetLayoutPattern MajorLayoutPattern
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double MajorEndOverhang
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double MajorStartOverhang
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double OverallLength
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double MinorLapSpliceLength
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double MajorLapSpliceLength
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId MinorDirectionWireType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId MajorDirectionWireType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

namespace Autodesk.Revit.DB;

public partial class Units : System.Object
{
	public Units(Autodesk.Revit.DB.UnitSystem unitSystem) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormatOptions GetFormatOptions(Autodesk.Revit.DB.ForgeTypeId specTypeId) => throw new System.NotImplementedException();
	public virtual void SetFormatOptions(Autodesk.Revit.DB.ForgeTypeId specTypeId,Autodesk.Revit.DB.FormatOptions options) => throw new System.NotImplementedException();
	public static System.Boolean IsModifiableSpec(Autodesk.Revit.DB.ForgeTypeId specTypeId) => throw new System.NotImplementedException();
	public static IList<Autodesk.Revit.DB.ForgeTypeId> GetModifiableSpecs() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.DigitGroupingAmount DigitGroupingAmount
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DigitGroupingSymbol DigitGroupingSymbol
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DecimalSymbol DecimalSymbol
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

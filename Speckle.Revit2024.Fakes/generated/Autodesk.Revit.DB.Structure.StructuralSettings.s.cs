namespace Autodesk.Revit.DB.Structure;

public partial class StructuralSettings : Autodesk.Revit.DB.Element
{
	public StructuralSettings() {}
	public static Autodesk.Revit.DB.Structure.StructuralSettings GetStructuralSettings(Autodesk.Revit.DB.Document doc) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetLoadForceVectorReprLine(Autodesk.Revit.DB.Structure.LoadType loadType,Autodesk.Revit.DB.XYZ forceVector) => throw new System.NotImplementedException();
	public virtual void SetValuesForLoadsDisplayScaling(System.Double minimumLoadValue,System.Double minimumForceLineLength,System.Double maximumLoadValue,System.Double maximumForceLineLength) => throw new System.NotImplementedException();
	public virtual System.Boolean UseLoadsDisplayScaling
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowBraceBelow
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowBraceAbove
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId BoundaryConditionFamilySymbolUserDefined
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId BoundaryConditionFamilySymbolRoller
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId BoundaryConditionFamilySymbolPinned
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId BoundaryConditionFamilySymbolFixed
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId KickerBraceSymbol
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId BraceBelowSymbol
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId BraceAboveSymbol
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double BoundaryConditionAreaAndLineSymbolSpacing
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SymbolicCutbackForColumn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SymbolicCutbackForBrace
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SymbolicCutbackForBeamAndTruss
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double BraceParallelLineOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

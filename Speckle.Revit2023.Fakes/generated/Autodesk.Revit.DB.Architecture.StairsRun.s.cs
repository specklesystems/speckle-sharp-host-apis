namespace Autodesk.Revit.DB.Architecture;

public partial class StairsRun : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.Reference GetNumberSystemReference(Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption referenceOption) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.Stairs GetStairs() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveLoop GetStairsPath() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveLoop GetFootprintBoundary() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.StairsRunJustification LocationLineJustification
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Architecture.StairsRunStyle StairsRunStyle
	{
		get => throw new System.NotImplementedException();
	}
}

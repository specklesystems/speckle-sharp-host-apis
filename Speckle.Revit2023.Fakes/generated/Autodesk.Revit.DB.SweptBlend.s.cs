namespace Autodesk.Revit.DB;

public partial class SweptBlend : Autodesk.Revit.DB.GenericForm
{
	public SweptBlend() {}
	public virtual Autodesk.Revit.DB.VertexIndexPairArray GetVertexConnectionMap() => throw new System.NotImplementedException();
	public virtual void SetVertexConnectionMap(Autodesk.Revit.DB.VertexIndexPairArray vertexMap) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveArrArray TopProfile
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.CurveArrArray BottomProfile
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Curve SelectedPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Sketch PathSketch
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FamilySymbolProfile BottomProfileSymbol
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Sketch BottomSketch
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FamilySymbolProfile TopProfileSymbol
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Sketch TopSketch
	{
		get => throw new System.NotImplementedException();
	}
}

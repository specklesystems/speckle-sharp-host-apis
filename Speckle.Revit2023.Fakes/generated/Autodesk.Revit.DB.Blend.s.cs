namespace Autodesk.Revit.DB;

public partial class Blend : Autodesk.Revit.DB.GenericForm
{
	public virtual Autodesk.Revit.DB.Sketch get_TopSketch() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Sketch get_BottomSketch() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.VertexIndexPairArray GetVertexConnectionMap() => throw new System.NotImplementedException();
	public virtual void SetVertexConnectionMap(Autodesk.Revit.DB.VertexIndexPairArray vertexMap) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveArrArray get_BottomProfile() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveArrArray get_TopProfile() => throw new System.NotImplementedException();
}
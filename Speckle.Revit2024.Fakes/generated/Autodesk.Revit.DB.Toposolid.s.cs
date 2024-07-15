namespace Autodesk.Revit.DB;

public partial class Toposolid : Autodesk.Revit.DB.CeilingAndFloor
{
	public Toposolid() {}
	public static Autodesk.Revit.DB.Toposolid Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profiles,System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points,Autodesk.Revit.DB.ElementId topoTypeId,Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Toposolid Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> points,Autodesk.Revit.DB.ElementId topoTypeId,Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Toposolid Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profiles,Autodesk.Revit.DB.ElementId topoTypeId,Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Toposolid CreateFromTopographySurface(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId hostSurfaceId,Autodesk.Revit.DB.ElementId topoTypeId,Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SlabShapeEditor GetSlabShapeEditor() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Toposolid CreateSubDivision(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profiles) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetSubDivisionIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> Split(System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> splitCurveLoops) => throw new System.NotImplementedException();
	public virtual void Simplify(System.Double percentage) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId SketchId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId HostTopoId
	{
		get => throw new System.NotImplementedException();
	}
}

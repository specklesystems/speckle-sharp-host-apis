namespace Autodesk.Revit.DB.Structure;

public partial class LineLoad : Autodesk.Revit.DB.Structure.LoadBase
{
	public LineLoad() {}
	public static Autodesk.Revit.DB.Structure.LineLoad Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId hostElemId,Autodesk.Revit.DB.Curve curve,Autodesk.Revit.DB.XYZ forceVector1,Autodesk.Revit.DB.XYZ momentVector1,Autodesk.Revit.DB.Structure.LineLoadType symbol) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.LineLoad Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId hostElemId,System.Int32 curveIndex,Autodesk.Revit.DB.XYZ forceVector1,Autodesk.Revit.DB.XYZ momentVector1,Autodesk.Revit.DB.Structure.LineLoadType symbol) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.LineLoad Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId hostElemId,Autodesk.Revit.DB.XYZ forceVector1,Autodesk.Revit.DB.XYZ momentVector1,Autodesk.Revit.DB.Structure.LineLoadType symbol) => throw new System.NotImplementedException();
	public static System.Boolean IsValidHostId(Autodesk.Revit.DB.Document pDoc,Autodesk.Revit.DB.ElementId hostId) => throw new System.NotImplementedException();
	public static System.Boolean IsCurveInsideHostBoundaries(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.ElementId hostId,Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve GetCurve() => throw new System.NotImplementedException();
	public virtual System.Boolean SetPoints(Autodesk.Revit.DB.XYZ startPoint,Autodesk.Revit.DB.XYZ endPoint) => throw new System.NotImplementedException();
	public virtual void SetCurve(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ MomentVector2
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ MomentVector1
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ ForceVector2
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ ForceVector1
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ EndPoint
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ StartPoint
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsProjected
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsUniform
	{
		get => throw new System.NotImplementedException();
	}
}

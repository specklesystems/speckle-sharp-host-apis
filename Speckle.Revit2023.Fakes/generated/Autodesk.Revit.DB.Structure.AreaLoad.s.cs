namespace Autodesk.Revit.DB.Structure;

public partial class AreaLoad : Autodesk.Revit.DB.Structure.LoadBase
{
	public AreaLoad() {}
	public static Autodesk.Revit.DB.Structure.AreaLoad Create(Autodesk.Revit.DB.Document aDoc,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> loops,System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> forceVectors,System.Collections.Generic.IList<System.Int32> refPointCurveIndexes,System.Collections.Generic.IList<System.Int32> refPointCurveSelectors,Autodesk.Revit.DB.Structure.AreaLoadType symbol) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.AreaLoad Create(Autodesk.Revit.DB.Document aDoc,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> loops,Autodesk.Revit.DB.XYZ forceVector,Autodesk.Revit.DB.Structure.AreaLoadType symbol) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.AreaLoad Create(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.ElementId hostElemId,Autodesk.Revit.DB.XYZ forceVector,Autodesk.Revit.DB.Structure.AreaLoadType symbol) => throw new System.NotImplementedException();
	public static System.Boolean IsValidHostId(Autodesk.Revit.DB.Document pDoc,Autodesk.Revit.DB.ElementId hostId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetRefPoint(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> GetLoops() => throw new System.NotImplementedException();
	public virtual System.Boolean SetLoops(Autodesk.Revit.DB.Document doc,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> newLoops) => throw new System.NotImplementedException();
	public virtual System.Double Area
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsProjected
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 NumRefPoints
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ ForceVector3
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
}

namespace Autodesk.Revit.DB;

public partial class Opening : Autodesk.Revit.DB.Element
{
	public Opening() {}
	public virtual Autodesk.Revit.DB.ElementId SketchId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsTransparentInElevation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsTransparentIn3D
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Element Host
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.CurveArray BoundaryCurves
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> BoundaryRect
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRectBoundary
	{
		get => throw new System.NotImplementedException();
	}
}

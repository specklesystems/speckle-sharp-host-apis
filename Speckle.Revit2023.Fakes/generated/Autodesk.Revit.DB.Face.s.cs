namespace Autodesk.Revit.DB;

public partial class Face : Autodesk.Revit.DB.GeometryObject
{
	public virtual Autodesk.Revit.DB.Surface GetSurface() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Face> GetRegions() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> GetEdgesAsCurveLoops() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Mesh Triangulate(System.Double levelOfDetail) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Mesh Triangulate() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Evaluate(Autodesk.Revit.DB.UV @params) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxUV GetBoundingBox() => throw new System.NotImplementedException();
	public virtual System.Boolean get_IsCyclic(System.Int32 paramIdx) => throw new System.NotImplementedException();
	public virtual System.Double get_Period(System.Int32 paramIdx) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform ComputeDerivatives(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FaceSecondDerivatives ComputeSecondDerivatives(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ ComputeNormal(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual System.Boolean IsInside(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FaceIntersectionFaceResult Intersect(Autodesk.Revit.DB.Face face) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SetComparisonResult Intersect(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.IntersectionResult Project(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual System.Double Area
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Reference Reference
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsTwoSided
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId MaterialElementId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.EdgeArrayArray EdgeLoops
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasRegions
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean OrientationMatchesSurfaceOrientation
	{
		get => throw new System.NotImplementedException();
	}
}

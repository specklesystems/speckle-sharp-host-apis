namespace Autodesk.Revit.DB;

public partial class Face : Autodesk.Revit.DB.GeometryObject
{
	public virtual Autodesk.Revit.DB.Surface GetSurface() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.EdgeArrayArray get_EdgeLoops() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_MaterialElementId() => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.Mesh Triangulate() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Evaluate(Autodesk.Revit.DB.UV @params) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxUV GetBoundingBox() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference get_Reference() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform ComputeDerivatives(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FaceSecondDerivatives ComputeSecondDerivatives(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ ComputeNormal(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FaceIntersectionFaceResult Intersect(Autodesk.Revit.DB.Face face) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SetComparisonResult Intersect(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.IntersectionResult Project(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
}

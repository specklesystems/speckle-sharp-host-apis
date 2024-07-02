namespace Autodesk.Revit.DB;

public partial class Curve : Autodesk.Revit.DB.GeometryObject
{
	public Curve() {}
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> Tessellate() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Evaluate(System.Double parameter,System.Boolean normalized) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetEndPoint(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetEndPointReference(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Double GetEndParameter(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void MakeBound(System.Double startParameter,System.Double endParameter) => throw new System.NotImplementedException();
	public virtual void MakeUnbound() => throw new System.NotImplementedException();
	public virtual System.Double ComputeNormalizedParameter(System.Double rawParameter) => throw new System.NotImplementedException();
	public virtual System.Double ComputeRawParameter(System.Double normalizedParameter) => throw new System.NotImplementedException();
	public virtual System.Double Distance(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve CreateTransformed(Autodesk.Revit.DB.Transform transform) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve CreateReversed() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve CreateOffset(System.Double offsetDist,Autodesk.Revit.DB.XYZ referenceVector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform ComputeDerivatives(System.Double parameter,System.Boolean normalized) => throw new System.NotImplementedException();
	public virtual System.Boolean IsInside(System.Double parameter) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SetComparisonResult Intersect(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.IntersectionResult Project(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve Clone() => throw new System.NotImplementedException();
	public virtual void SetGraphicsStyleId(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual System.Double Period
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsCyclic
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Length
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ApproximateLength
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Reference Reference
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsClosed
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsBound
	{
		get => throw new System.NotImplementedException();
	}
}

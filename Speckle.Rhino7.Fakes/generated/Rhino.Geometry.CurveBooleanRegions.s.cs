namespace Rhino.Geometry;

public partial class CurveBooleanRegions : System.IDisposable
{
	public CurveBooleanRegions() {}
	public virtual Rhino.Geometry.Curve[] RegionCurves(System.Int32 regionIndex) => throw new System.NotImplementedException();
	public virtual System.Int32 RegionPointIndex(System.Int32 pointIndex) => throw new System.NotImplementedException();
	public virtual System.Int32 BoundaryCount(System.Int32 regionIndex) => throw new System.NotImplementedException();
	public virtual System.Int32 SegmentCount(System.Int32 regionIndex,System.Int32 boundaryIndex) => throw new System.NotImplementedException();
	public virtual System.Int32 SegmentDetails(System.Int32 regionIndex,System.Int32 boundaryIndex,System.Int32 segmmentIndex,out Rhino.Geometry.Interval subDomain,out System.Boolean reversed) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve PlanarCurve(System.Int32 planarCurveIndex) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Int32 RegionCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 PointCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 PlanarCurveCount
	{
		get => throw new System.NotImplementedException();
	}
}

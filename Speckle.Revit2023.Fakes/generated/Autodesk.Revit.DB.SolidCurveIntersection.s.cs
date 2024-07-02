namespace Autodesk.Revit.DB;

public partial class SolidCurveIntersection : System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.Curve>,System.IDisposable
{
	public SolidCurveIntersection() {}
	public virtual Autodesk.Revit.DB.Curve GetCurveSegment(System.Int32 index) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveExtents GetCurveSegmentExtents(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Curve> GetEnumerator() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 SegmentCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.SolidCurveIntersectionMode ResultType
	{
		get => throw new System.NotImplementedException();
	}
}

namespace Rhino.Geometry;

public partial class PolyCurve : Rhino.Geometry.Curve
{
	public PolyCurve() {}
	public virtual Rhino.Geometry.PolyCurve DuplicatePolyCurve() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve SegmentCurve(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveNesting() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Explode() => throw new System.NotImplementedException();
	public virtual System.Boolean Append(Rhino.Geometry.Line line) => throw new System.NotImplementedException();
	public virtual System.Boolean Append(Rhino.Geometry.Arc arc) => throw new System.NotImplementedException();
	public virtual System.Boolean Append(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public virtual System.Boolean AppendSegment(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public virtual System.Double SegmentCurveParameter(System.Double polycurveParameter) => throw new System.NotImplementedException();
	public virtual System.Double PolyCurveParameter(System.Int32 segmentIndex,System.Double segmentCurveParameter) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Interval SegmentDomain(System.Int32 segmentIndex) => throw new System.NotImplementedException();
	public virtual System.Int32 SegmentIndex(System.Double polycurveParameter) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve CleanUp() => throw new System.NotImplementedException();
	public virtual System.Int32 SegmentCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsNested
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasGap
	{
		get => throw new System.NotImplementedException();
	}
}

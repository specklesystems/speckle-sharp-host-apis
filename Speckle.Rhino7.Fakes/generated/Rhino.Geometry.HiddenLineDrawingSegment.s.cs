namespace Rhino.Geometry;

public partial class HiddenLineDrawingSegment
{
	public HiddenLineDrawingSegment() {}
	public virtual System.Int32 Index
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Curve CurveGeometry
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.HiddenLineDrawingObjectCurve ParentCurve
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.HiddenLineDrawingSegment.Visibility SegmentVisibility
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSceneSilhouette
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.HiddenLineDrawingSegment.SideFill CurveSideFills
	{
		get => throw new System.NotImplementedException();
	}
}

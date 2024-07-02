namespace Rhino.Geometry;

public partial class HiddenLineDrawingObjectCurve
{
	public HiddenLineDrawingObjectCurve() {}
	public virtual Rhino.Geometry.HiddenLineDrawingSegment Curve(System.Double t) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.HiddenLineDrawingSegment Curve(System.Double t,System.Int32 side) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.HiddenLineDrawingObject SourceObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.ComponentIndex SourceObjectComponentIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 ClippingPlaneIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Index
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.SilhouetteType SilhouetteType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double OriginalDomainStart
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double[] Parameters
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.HiddenLineDrawingSegment Segments
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsProjecting
	{
		get => throw new System.NotImplementedException();
	}
}

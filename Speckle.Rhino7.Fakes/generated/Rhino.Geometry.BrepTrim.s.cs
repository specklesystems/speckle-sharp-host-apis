namespace Rhino.Geometry;

public partial class BrepTrim : Rhino.Geometry.CurveProxy
{
	public BrepTrim() {}
	public virtual System.Boolean IsReversed() => throw new System.NotImplementedException();
	public virtual void SetTolerances(System.Double toleranceU,System.Double toleranceV) => throw new System.NotImplementedException();
	public virtual System.Boolean SetTrimCurve(System.Int32 curve2dIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean SetTrimCurve(System.Int32 curve2dIndex,Rhino.Geometry.Interval subDomain) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep Brep
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BrepLoop Loop
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BrepFace Face
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BrepEdge Edge
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 TrimCurveIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Curve TrimCurve
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 TrimIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BrepTrimType TrimType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.IsoStatus IsoStatus
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.BrepVertex StartVertex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.BrepVertex EndVertex
	{
		get => throw new System.NotImplementedException();
	}
}

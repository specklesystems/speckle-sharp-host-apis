namespace Rhino.Geometry;

public partial class MorphControl : Rhino.Geometry.GeometryBase
{
	public MorphControl() {}
	public MorphControl(Rhino.Geometry.NurbsCurve originCurve,Rhino.Geometry.NurbsCurve targetCurve) => throw new System.NotImplementedException();
	public virtual System.Boolean Morph(Rhino.Geometry.GeometryBase geometry) => throw new System.NotImplementedException();
	public virtual System.Double SpaceMorphTolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean QuickPreview
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean PreserveStructure
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.NurbsCurve Curve
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.NurbsSurface Surface
	{
		get => throw new System.NotImplementedException();
	}
}

namespace Rhino.Geometry;

public partial class SweepOneRail
{
	public SweepOneRail() {}
	public virtual void SetToRoadlikeTop() => throw new System.NotImplementedException();
	public virtual void SetToRoadlikeFront() => throw new System.NotImplementedException();
	public virtual void SetToRoadlikeRight() => throw new System.NotImplementedException();
	public virtual void SetRoadlikeUpDirection(Rhino.Geometry.Vector3d up) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweep(Rhino.Geometry.Curve rail,Rhino.Geometry.Curve crossSection) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweep(Rhino.Geometry.Curve rail,Rhino.Geometry.Curve crossSection,System.Double crossSectionParameter) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweep(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweep(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,System.Collections.Generic.IEnumerable<System.Double> crossSectionParameters) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweepRefit(Rhino.Geometry.Curve rail,Rhino.Geometry.Curve crossSection,System.Double refitTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweepRefit(Rhino.Geometry.Curve rail,Rhino.Geometry.Curve crossSection,System.Double crossSectionParameter,System.Double refitTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweepRefit(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,System.Double refitTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweepRefit(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,System.Collections.Generic.IEnumerable<System.Double> crossSectionParameters,System.Double refitTolerance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweepRebuild(Rhino.Geometry.Curve rail,Rhino.Geometry.Curve crossSection,System.Int32 rebuildCount) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweepRebuild(Rhino.Geometry.Curve rail,Rhino.Geometry.Curve crossSection,System.Double crossSectionParameter,System.Int32 rebuildCount) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweepRebuild(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,System.Int32 rebuildCount) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep PerformSweepRebuild(Rhino.Geometry.Curve rail,System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> crossSections,System.Collections.Generic.IEnumerable<System.Double> crossSectionParameters,System.Int32 rebuildCount) => throw new System.NotImplementedException();
	public virtual System.Boolean IsFreeform
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRoadlike
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRoadlikeTop
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRoadlikeFront
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsRoadlineRight
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double SweepTolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AngleToleranceRadians
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 MiterType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ClosedSweep
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean GlobalShapeBlending
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

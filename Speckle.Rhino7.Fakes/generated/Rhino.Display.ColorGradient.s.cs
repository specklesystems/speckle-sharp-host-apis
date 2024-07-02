namespace Rhino.Display;

public partial class ColorGradient
{
	public ColorGradient() {}
	public virtual Rhino.Display.ColorStop[] GetColorStops() => throw new System.NotImplementedException();
	public virtual void SetColorStops(System.Collections.Generic.IEnumerable<Rhino.Display.ColorStop> stops) => throw new System.NotImplementedException();
	public virtual Rhino.Display.GradientType GradientType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Repeat
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point3d StartPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point3d EndPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

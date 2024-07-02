namespace Rhino.Geometry;

public partial class Interpolator : Rhino.Collections.RhinoList<System.Double>
{
	public Interpolator() {}
	public Interpolator(System.Int32 initialCapacity) => throw new System.NotImplementedException();
	public Interpolator(Rhino.Collections.RhinoList<System.Double> list) => throw new System.NotImplementedException();
	public Interpolator(System.Collections.Generic.IEnumerable<System.Double> collection) => throw new System.NotImplementedException();
	public Interpolator(System.Int32 amount,System.Double defaultValue) => throw new System.NotImplementedException();
	public virtual System.Double InterpolateNearestNeighbour(System.Double t) => throw new System.NotImplementedException();
	public virtual System.Double InterpolateLinear(System.Double t) => throw new System.NotImplementedException();
	public virtual System.Double InterpolateCosine(System.Double t) => throw new System.NotImplementedException();
	public virtual System.Double InterpolateCubic(System.Double t) => throw new System.NotImplementedException();
	public virtual System.Double InterpolateCatmullRom(System.Double t) => throw new System.NotImplementedException();
	public virtual System.Boolean Cyclical
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

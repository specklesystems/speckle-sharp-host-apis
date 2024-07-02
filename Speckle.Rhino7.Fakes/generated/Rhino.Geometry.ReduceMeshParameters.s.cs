namespace Rhino.Geometry;

public partial class ReduceMeshParameters
{
	public ReduceMeshParameters() {}
	public virtual System.Int32 DesiredPolygonCount
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AllowDistortion
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Accuracy
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean NormalizeMeshSize
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Error
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32[] FaceTags
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.ComponentIndex LockedComponents
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Threading.CancellationToken CancelToken
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.IProgress<System.Double> ProgressReporter
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

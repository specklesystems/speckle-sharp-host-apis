namespace Rhino.Geometry;

public partial class MeshBooleanOptions
{
  public MeshBooleanOptions() { }

  public virtual System.Double Tolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.TextLog TextLog
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Threading.CancellationToken CancellationToken
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.IProgress<System.Double> ProgressReporter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Rhino.Geometry;

public partial class RTreeEventArgs : System.EventArgs
{
  public RTreeEventArgs() { }

  public virtual System.Int32 Id
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.IntPtr IdPtr
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Cancel
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 IdB
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.IntPtr IdBPtr
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Object Tag
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Sphere SearchSphere
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.BoundingBox SearchBoundingBox
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

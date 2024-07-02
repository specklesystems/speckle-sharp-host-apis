namespace Rhino.Geometry.Collections;

public partial class BrepSurfaceList
  : System.Collections.Generic.IEnumerable<Rhino.Geometry.Surface>,
    System.Collections.IEnumerable,
    Rhino.Collections.IRhinoTable<Rhino.Geometry.Surface>
{
  public BrepSurfaceList() { }

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.Surface> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Surface this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
  }
}

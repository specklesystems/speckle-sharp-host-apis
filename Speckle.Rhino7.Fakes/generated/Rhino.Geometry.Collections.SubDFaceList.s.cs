namespace Rhino.Geometry.Collections;

public partial class SubDFaceList
  : System.Collections.Generic.IEnumerable<Rhino.Geometry.SubDFace>,
    System.Collections.IEnumerable
{
  public SubDFaceList() { }

  public virtual Rhino.Geometry.SubDFace Find(System.UInt32 id) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.SubDFace Find(System.Int32 id) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.SubDFace> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
}

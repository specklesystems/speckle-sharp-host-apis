namespace Rhino.Geometry.Collections;

public partial class BrepCurveList
  : System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve>,
    System.Collections.IEnumerable,
    Rhino.Collections.IRhinoTable<Rhino.Geometry.Curve>
{
  public BrepCurveList() { }

  public virtual System.Int32 Add(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Rhino.Geometry.Curve> GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Curve this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
  }
}

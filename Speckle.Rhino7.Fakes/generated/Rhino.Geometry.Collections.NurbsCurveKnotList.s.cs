namespace Rhino.Geometry.Collections;

public partial class NurbsCurveKnotList
  : System.Collections.Generic.IEnumerable<System.Double>,
    System.Collections.IEnumerable,
    Rhino.Collections.IRhinoTable<System.Double>,
    Rhino.IEpsilonComparable<Rhino.Geometry.Collections.NurbsCurveKnotList>,
    System.Collections.Generic.IList<System.Double>,
    System.Collections.Generic.ICollection<System.Double>
{
  public NurbsCurveKnotList() { }

  public virtual void EnsurePrivateCopy() => throw new System.NotImplementedException();

  public virtual System.Boolean InsertKnot(System.Double value) => throw new System.NotImplementedException();

  public virtual System.Boolean InsertKnot(System.Double value, System.Int32 multiplicity) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 KnotMultiplicity(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Boolean CreateUniformKnots(System.Double knotSpacing) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CreatePeriodicKnots(System.Double knotSpacing) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ClampEnd(Rhino.Geometry.CurveEnd end) => throw new System.NotImplementedException();

  public virtual System.Double SuperfluousKnot(System.Boolean start) => throw new System.NotImplementedException();

  public virtual System.Int32 RemoveMultipleKnots(
    System.Int32 minimumMultiplicity,
    System.Int32 maximumMultiplicity,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean RemoveKnots(System.Int32 index0, System.Int32 index1) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean RemoveKnotAt(System.Double t) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(
    Rhino.Geometry.Collections.NurbsCurveKnotList other,
    System.Double epsilon
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 IndexOf(System.Double item) => throw new System.NotImplementedException();

  public virtual System.Boolean Contains(System.Double item) => throw new System.NotImplementedException();

  public virtual void CopyTo(System.Double[] array, System.Int32 arrayIndex) =>
    throw new System.NotImplementedException();

  System.Collections.Generic.IEnumerator<System.Double> System.Collections.Generic.IEnumerable<System.Double>.GetEnumerator() =>
    throw new System.NotImplementedException();

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<System.Double>.Insert(System.Int32 index, System.Double item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.IList<System.Double>.RemoveAt(System.Int32 index) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<System.Double>.Add(System.Double item) =>
    throw new System.NotImplementedException();

  void System.Collections.Generic.ICollection<System.Double>.Clear() => throw new System.NotImplementedException();

  System.Boolean System.Collections.Generic.ICollection<System.Double>.Remove(System.Double item) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsClampedStart
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsClampedEnd
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.KnotStyle KnotStyle
  {
    get => throw new System.NotImplementedException();
  }
  System.Boolean System.Collections.Generic.ICollection<System.Double>.IsReadOnly
  {
    get => throw new System.NotImplementedException();
  }
}

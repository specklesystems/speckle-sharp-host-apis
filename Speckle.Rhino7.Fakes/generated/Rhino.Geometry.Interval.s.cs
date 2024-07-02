namespace Rhino.Geometry;

public partial struct Interval
  : System.Runtime.Serialization.ISerializable,
    System.IEquatable<Rhino.Geometry.Interval>,
    System.IComparable<Rhino.Geometry.Interval>,
    System.IComparable,
    Rhino.IEpsilonComparable<Rhino.Geometry.Interval>,
    Rhino.Geometry.IValidable
{
  public Interval() { }

  public Interval(System.Double t0, System.Double t1) => throw new System.NotImplementedException();

  public Interval(Rhino.Geometry.Interval other) => throw new System.NotImplementedException();

  public System.Boolean Equals(Rhino.Geometry.Interval other) => throw new System.NotImplementedException();

  public System.Int32 CompareTo(Rhino.Geometry.Interval other) => throw new System.NotImplementedException();

  public void Grow(System.Double value) => throw new System.NotImplementedException();

  public void MakeIncreasing() => throw new System.NotImplementedException();

  public void Reverse() => throw new System.NotImplementedException();

  public void Swap() => throw new System.NotImplementedException();

  public System.Double ParameterAt(System.Double normalizedParameter) => throw new System.NotImplementedException();

  public Rhino.Geometry.Interval ParameterIntervalAt(Rhino.Geometry.Interval normalizedInterval) =>
    throw new System.NotImplementedException();

  public System.Double NormalizedParameterAt(System.Double intervalParameter) =>
    throw new System.NotImplementedException();

  public Rhino.Geometry.Interval NormalizedIntervalAt(Rhino.Geometry.Interval intervalParameter) =>
    throw new System.NotImplementedException();

  public System.Boolean IncludesParameter(System.Double t) => throw new System.NotImplementedException();

  public System.Boolean IncludesParameter(System.Double t, System.Boolean strict) =>
    throw new System.NotImplementedException();

  public System.Boolean IncludesInterval(Rhino.Geometry.Interval interval) =>
    throw new System.NotImplementedException();

  public System.Boolean IncludesInterval(Rhino.Geometry.Interval interval, System.Boolean strict) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Interval FromIntersection(Rhino.Geometry.Interval a, Rhino.Geometry.Interval b) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Interval FromUnion(Rhino.Geometry.Interval a, Rhino.Geometry.Interval b) =>
    throw new System.NotImplementedException();

  public System.Boolean EpsilonEquals(Rhino.Geometry.Interval other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  void System.Runtime.Serialization.ISerializable.GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Interval Unset
  {
    get => throw new System.NotImplementedException();
  }
  public System.Double T0
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double T1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double this[System.Int32 index]
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double Min
  {
    get => throw new System.NotImplementedException();
  }
  public System.Double Max
  {
    get => throw new System.NotImplementedException();
  }
  public System.Double Mid
  {
    get => throw new System.NotImplementedException();
  }
  public System.Double Length
  {
    get => throw new System.NotImplementedException();
  }
  public System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public System.Boolean IsSingleton
  {
    get => throw new System.NotImplementedException();
  }
  public System.Boolean IsIncreasing
  {
    get => throw new System.NotImplementedException();
  }
  public System.Boolean IsDecreasing
  {
    get => throw new System.NotImplementedException();
  }
}

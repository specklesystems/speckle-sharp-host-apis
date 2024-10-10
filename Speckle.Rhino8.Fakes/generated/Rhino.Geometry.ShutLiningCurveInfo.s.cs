namespace Rhino.Geometry;

public partial class ShutLiningCurveInfo
{
  public ShutLiningCurveInfo() { }

  public ShutLiningCurveInfo(
    Rhino.Geometry.Curve curve,
    System.Double radius,
    System.Int32 profile,
    System.Boolean pull,
    System.Boolean isBump,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Interval> curveIntervals,
    System.Boolean enabled
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve Curve
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Enabled
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Profile
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Pull
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsBump
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.ObjectModel.ReadOnlyCollection<Rhino.Geometry.Interval> CurveIntervals
  {
    get => throw new System.NotImplementedException();
  }
}

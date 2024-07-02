namespace Rhino.Geometry;

public partial class CurveProxy : Rhino.Geometry.Curve
{
  public CurveProxy() { }

  public virtual System.Boolean ProxyCurveIsReversed
  {
    get => throw new System.NotImplementedException();
  }
}

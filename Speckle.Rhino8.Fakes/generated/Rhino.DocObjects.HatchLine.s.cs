namespace Rhino.DocObjects;

public partial class HatchLine : System.IDisposable
{
  public HatchLine() { }

  public HatchLine(Rhino.DocObjects.HatchLine hatchLine) => throw new System.NotImplementedException();

  public virtual System.Double DashAt(System.Int32 dashIndex) => throw new System.NotImplementedException();

  public virtual void AppendDash(System.Double dash) => throw new System.NotImplementedException();

  public virtual void SetDashes(System.Collections.Generic.IEnumerable<System.Double> dashes) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Angle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point2d BasePoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector2d Offset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 DashCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IEnumerable<System.Double> GetDashes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double PatternLength
  {
    get => throw new System.NotImplementedException();
  }
}

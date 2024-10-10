namespace Rhino.FileIO;

public partial class File3dmShutLining
{
  public File3dmShutLining() { }

  public virtual System.Guid[] GetCurves() => throw new System.NotImplementedException();

  public virtual System.Guid AddCurve() => throw new System.NotImplementedException();

  public virtual void DeleteAllCurves() => throw new System.NotImplementedException();

  public virtual System.Boolean CurveEnabled(System.Guid curve_id) => throw new System.NotImplementedException();

  public virtual void SetCurveEnabled(System.Guid curve_id, System.Boolean enabled) =>
    throw new System.NotImplementedException();

  public virtual System.Double CurveRadius(System.Guid curve_id) => throw new System.NotImplementedException();

  public virtual void SetCurveRadius(System.Guid curve_id, System.Double radius) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CurveProfile(System.Guid curve_id) => throw new System.NotImplementedException();

  public virtual void SetCurveProfile(System.Guid curve_id, System.Int32 profile) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CurvePull(System.Guid curve_id) => throw new System.NotImplementedException();

  public virtual void SetCurvePull(System.Guid curve_id, System.Boolean pull) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CurveIsBump(System.Guid curve_id) => throw new System.NotImplementedException();

  public virtual void SetCurveIsBump(System.Guid curve_id, System.Boolean b) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean On
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Faceted
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean AutoUpdate
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ForceUpdate
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

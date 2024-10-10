namespace Rhino;

public partial class UnitsChangedWithScalingEventArgs : System.EventArgs
{
  public UnitsChangedWithScalingEventArgs() { }

  public virtual System.UInt32 DocumentSerialNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.RhinoDoc Document
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Scale
  {
    get => throw new System.NotImplementedException();
  }
}

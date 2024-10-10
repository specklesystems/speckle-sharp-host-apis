namespace Rhino.Display;

public partial class PageViewPropertiesChangeEventArgs : System.EventArgs
{
  public PageViewPropertiesChangeEventArgs() { }

  public virtual System.UInt32 DocumentSerialNumber
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.UInt32 PageViewSerialNumber
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.RhinoDoc Document
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Display.RhinoPageView PageView
  {
    get => throw new System.NotImplementedException();
  }
}

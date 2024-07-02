namespace Rhino.Runtime;

public partial class LicenseStateChangedEventArgs : System.EventArgs
{
  public LicenseStateChangedEventArgs() { }

  public LicenseStateChangedEventArgs(System.Boolean callingRhinoCommonAllowed) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CallingRhinoCommonAllowed
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

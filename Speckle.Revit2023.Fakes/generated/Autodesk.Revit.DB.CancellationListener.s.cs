namespace Autodesk.Revit.DB;

public partial class CancellationListener : System.IDisposable
{
  public virtual System.Boolean IsCancelled() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB;

public partial class ReferenceWithContext : System.IDisposable
{
  public ReferenceWithContext() { }

  public virtual Autodesk.Revit.DB.Reference GetReference() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetInstanceTransform() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Proximity
  {
    get => throw new System.NotImplementedException();
  }
}

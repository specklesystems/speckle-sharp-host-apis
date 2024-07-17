namespace Autodesk.Revit.DB;

public partial class RelinquishedItems : System.IDisposable
{
  public RelinquishedItems() { }

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetRelinquishedElements() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.WorksetId> GetRelinquishedWorksets() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

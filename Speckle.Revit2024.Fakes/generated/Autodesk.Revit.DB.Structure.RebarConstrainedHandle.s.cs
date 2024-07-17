namespace Autodesk.Revit.DB.Structure;

public partial class RebarConstrainedHandle : System.IDisposable
{
  public RebarConstrainedHandle() { }

  public virtual Autodesk.Revit.DB.Structure.RebarHandleType GetHandleType() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetEdgeNumber() => throw new System.NotImplementedException();

  public virtual System.Int32 GetCustomHandleTag() => throw new System.NotImplementedException();

  public virtual System.String GetHandleName() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValid() => throw new System.NotImplementedException();

  public virtual System.Boolean IsEdgeHandle() => throw new System.NotImplementedException();

  public virtual System.Boolean IsCustomHandle() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

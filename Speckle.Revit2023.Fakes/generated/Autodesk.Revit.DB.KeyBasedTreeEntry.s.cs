namespace Autodesk.Revit.DB;

public partial class KeyBasedTreeEntry : System.IDisposable
{
  public virtual System.Collections.Generic.IList<System.String> GetChildrenKeys() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String ParentKey
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Key
  {
    get => throw new System.NotImplementedException();
  }
}

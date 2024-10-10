namespace Rhino.FileIO;

public partial interface ICommonComponentTable<T>
{
  public T FindId(System.Guid id);
  public T FindNameHash(Rhino.FileIO.NameHash nameHash);
  public Rhino.DocObjects.ModelComponentType ComponentType { get; }
}

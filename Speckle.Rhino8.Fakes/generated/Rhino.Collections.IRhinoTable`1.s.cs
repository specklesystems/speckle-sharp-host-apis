namespace Rhino.Collections;

public partial interface IRhinoTable<T>
{
  public System.Int32 Count { get; }
  public T this[System.Int32 index] { get; }
}

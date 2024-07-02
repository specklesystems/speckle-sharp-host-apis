namespace Rhino;

public partial struct IndexPair
{
  int System.Collections.Generic.IList<System.Int32>.this[int x]
  {
    get => throw new System.NotImplementedException();
    set { }
  }

  int System.Collections.Generic.IReadOnlyList<int>.this[int x]
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Rhino.Geometry;

public partial class ComponentIndex
{
  public ComponentIndex() { }

  public ComponentIndex(Rhino.Geometry.ComponentIndexType type, System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsUnset() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.ComponentIndexType ComponentIndexType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Index
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.ComponentIndex Unset
  {
    get => throw new System.NotImplementedException();
  }
}

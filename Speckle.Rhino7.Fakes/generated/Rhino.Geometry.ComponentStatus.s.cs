namespace Rhino.Geometry;

public partial class ComponentStatus : System.IEquatable<Rhino.Geometry.ComponentStatus>
{
  public ComponentStatus() { }

  public virtual Rhino.Geometry.ComponentStatus WithStates(Rhino.Geometry.ComponentStatus additionalStatus) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasSomeEqualStates(
    Rhino.Geometry.ComponentStatus statesFilter,
    Rhino.Geometry.ComponentStatus comparand
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasAllEqualStates(
    Rhino.Geometry.ComponentStatus statesFilter,
    Rhino.Geometry.ComponentStatus comparand
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasNoEqualStates(
    Rhino.Geometry.ComponentStatus statesFilter,
    Rhino.Geometry.ComponentStatus comparand
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.ComponentStatus other) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.ComponentStatus Clear
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.ComponentStatus Selected
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.ComponentStatus SelectedPersistent
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.ComponentStatus Highlighted
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.ComponentStatus Hidden
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.ComponentStatus Locked
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.ComponentStatus Damaged
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.ComponentStatus AllSet
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsClear
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsDamaged
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsHighlighted
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsHidden
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsLocked
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSelected
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSelectedPersistent
  {
    get => throw new System.NotImplementedException();
  }
}

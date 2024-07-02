namespace Rhino.DocObjects;

public partial class Linetype : Rhino.DocObjects.ModelComponent
{
  public Linetype() { }

  public virtual System.Boolean CommitChanges() => throw new System.NotImplementedException();

  public virtual void Default() => throw new System.NotImplementedException();

  public virtual System.Int32 AppendSegment(System.Double length, System.Boolean isSolid) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean RemoveSegment(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Boolean SetSegments(System.Collections.Generic.IEnumerable<System.Double> segments) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetSegment(System.Int32 index, System.Double length, System.Boolean isSolid) =>
    throw new System.NotImplementedException();

  public virtual void GetSegment(System.Int32 index, out System.Double length, out System.Boolean isSolid) =>
    throw new System.NotImplementedException();

  public static Rhino.DocObjects.Linetype[] ReadFromFile(System.String path) =>
    throw new System.NotImplementedException();

  public static Rhino.DocObjects.Linetype CreateFromPatternString(
    System.String patternString,
    System.Boolean millimeters
  ) => throw new System.NotImplementedException();

  public virtual System.String PatternString(System.Boolean millimeters) => throw new System.NotImplementedException();

  public new System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 LinetypeIndex
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PatternLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 SegmentCount
  {
    get => throw new System.NotImplementedException();
  }
  public new Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsDeleted
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsReference
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsModified
  {
    get => throw new System.NotImplementedException();
  }
}

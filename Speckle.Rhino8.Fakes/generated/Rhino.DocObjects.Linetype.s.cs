namespace Rhino.DocObjects;

public partial class Linetype : Rhino.DocObjects.ModelComponent
{
  public Linetype() { }

  public Linetype(Rhino.DocObjects.Linetype other) => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Linetype DuplicateLinetype() => throw new System.NotImplementedException();

  public virtual System.Boolean CommitChanges() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point2d[] GetTaperPoints() => throw new System.NotImplementedException();

  public virtual void SetTaper(System.Double startWidth, System.Double endWidth) =>
    throw new System.NotImplementedException();

  public virtual void SetTaper(System.Double startWidth, Rhino.Geometry.Point2d taperPoint, System.Double endWidth) =>
    throw new System.NotImplementedException();

  public virtual void RemoveTaper() => throw new System.NotImplementedException();

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

  public virtual System.Boolean SetUserString(System.String key, System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.String GetUserString(System.String key) => throw new System.NotImplementedException();

  public virtual System.Collections.Specialized.NameValueCollection GetUserStrings() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DeleteUserString(System.String key) => throw new System.NotImplementedException();

  public virtual void DeleteAllUserStrings() => throw new System.NotImplementedException();

  public new Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  public new System.Boolean IsDeleted
  {
    get => throw new System.NotImplementedException();
  }
  public new System.Boolean IsReference
  {
    get => throw new System.NotImplementedException();
  }
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
  public virtual System.Boolean IsModified
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean InUse
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.LineCapStyle LineCapStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.LineJoinStyle LineJoinStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Width
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.UnitSystem WidthUnits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean AlwaysModelDistances
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPatternLocked
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 UserStringCount
  {
    get => throw new System.NotImplementedException();
  }
}

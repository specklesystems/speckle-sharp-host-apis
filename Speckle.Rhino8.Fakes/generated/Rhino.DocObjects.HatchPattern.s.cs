namespace Rhino.DocObjects;

public partial class HatchPattern : Rhino.DocObjects.ModelComponent
{
  public HatchPattern() { }

  public static Rhino.DocObjects.HatchPattern[] ReadFromFile(System.String filename, System.Boolean quiet) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line[] CreatePreviewGeometry(
    System.Int32 width,
    System.Int32 height,
    System.Double angle
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 AddHatchLine(Rhino.DocObjects.HatchLine hatchLine) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.HatchLine HatchLineAt(System.Int32 hatchLineIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean RemoveHatchLine(System.Int32 hatchLineIndex) =>
    throw new System.NotImplementedException();

  public virtual void RemoveAllHatchLines() => throw new System.NotImplementedException();

  public virtual System.Int32 SetHatchLines(
    System.Collections.Generic.IEnumerable<Rhino.DocObjects.HatchLine> hatchLines
  ) => throw new System.NotImplementedException();

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
  public new System.Int32 Index
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.HatchPatternFillType FillType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 HatchLineCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IEnumerable<Rhino.DocObjects.HatchLine> HatchLines
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 UserStringCount
  {
    get => throw new System.NotImplementedException();
  }
}

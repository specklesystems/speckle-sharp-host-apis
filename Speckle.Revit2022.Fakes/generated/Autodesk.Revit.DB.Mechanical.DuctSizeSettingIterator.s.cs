namespace Autodesk.Revit.DB.Mechanical;

public partial class DuctSizeSettingIterator
  : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<
    Autodesk.Revit.DB.Mechanical.DuctShape,
    Autodesk.Revit.DB.Mechanical.DuctSizes
  >>,
    System.IDisposable,
    System.Collections.IEnumerator
{
  public DuctSizeSettingIterator() { }

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual System.Boolean IsDone() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual System.Boolean HasCurrent() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.KeyValuePair<
    Autodesk.Revit.DB.Mechanical.DuctShape,
    Autodesk.Revit.DB.Mechanical.DuctSizes
  > Current
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

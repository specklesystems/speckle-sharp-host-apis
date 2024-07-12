namespace Autodesk.Revit.DB.Mechanical;

public partial class DuctSizes
  : System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.MEPSize>,
    System.Collections.IEnumerable,
    System.IDisposable
{
  public DuctSizes() { }

  public virtual Autodesk.Revit.DB.Mechanical.DuctSizeIterator GetDuctSizeIterator() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Contains(System.Double nominalDiameter) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.MEPSize> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
}

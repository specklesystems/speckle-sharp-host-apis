namespace Autodesk.Revit.DB.PointClouds;

public partial class PointCollection
  : System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.PointClouds.CloudPoint>,
    System.Collections.IEnumerable,
    System.IDisposable
{
  public PointCollection() { }

  public virtual Autodesk.Revit.DB.PointClouds.PointIterator GetPointIterator() =>
    throw new System.NotImplementedException();

  public virtual System.IntPtr GetPointBufferPointer() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.PointClouds.CloudPoint> GetEnumerator() =>
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

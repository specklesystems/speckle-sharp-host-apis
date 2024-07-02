namespace Autodesk.Revit.DB.PointClouds;

public partial class PointIterator : System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.PointClouds.CloudPoint>
{
  public PointIterator() { }

  public virtual System.Boolean MoveNext() => throw new System.NotImplementedException();

  public virtual System.Boolean IsDone() => throw new System.NotImplementedException();

  public virtual void Reset() => throw new System.NotImplementedException();

  public virtual void Free() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Object CurrentObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.PointClouds.CloudPoint Current
  {
    get => throw new System.NotImplementedException();
  }
}

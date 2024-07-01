namespace Autodesk.Revit.DB.Analysis;

public partial class Polyloop : System.IDisposable
{
  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetPoints() =>
    throw new System.NotImplementedException();

  public virtual System.Double ComputeArea() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Direction
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Centroid
  {
    get => throw new System.NotImplementedException();
  }
}

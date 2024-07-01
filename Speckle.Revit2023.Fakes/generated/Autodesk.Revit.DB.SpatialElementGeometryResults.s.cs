namespace Autodesk.Revit.DB;

public partial class SpatialElementGeometryResults : System.IDisposable
{
  public virtual Autodesk.Revit.DB.Solid GetGeometry() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.SpatialElementBoundarySubface> GetBoundaryFaceInfo(
    Autodesk.Revit.DB.Face face
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

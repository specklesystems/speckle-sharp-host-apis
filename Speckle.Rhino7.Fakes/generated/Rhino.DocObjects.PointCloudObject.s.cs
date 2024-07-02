namespace Rhino.DocObjects;

public partial class PointCloudObject : Rhino.DocObjects.RhinoObject
{
  public PointCloudObject() { }

  public virtual Rhino.Geometry.PointCloud DuplicatePointCloudGeometry() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.PointCloud PointCloudGeometry
  {
    get => throw new System.NotImplementedException();
  }
}

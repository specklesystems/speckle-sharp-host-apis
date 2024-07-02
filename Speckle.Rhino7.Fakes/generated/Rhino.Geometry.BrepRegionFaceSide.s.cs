namespace Rhino.Geometry;

public partial class BrepRegionFaceSide : Rhino.Runtime.CommonObject
{
  public BrepRegionFaceSide() { }

  public virtual Rhino.Geometry.Brep Brep
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BrepRegion Region
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean SurfaceNormalPointsIntoRegion
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BrepFace Face
  {
    get => throw new System.NotImplementedException();
  }
}

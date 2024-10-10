namespace Rhino.Geometry;

public partial class BrepRegion : Rhino.Runtime.CommonObject
{
  public BrepRegion() { }

  public virtual Rhino.Geometry.Brep BoundaryBrep() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepRegionFaceSide[] GetFaceSides() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep Brep
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Index
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsFinite
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.BoundingBox BoundingBox
  {
    get => throw new System.NotImplementedException();
  }
}

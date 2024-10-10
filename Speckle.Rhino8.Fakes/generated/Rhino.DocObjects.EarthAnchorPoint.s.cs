namespace Rhino.DocObjects;

public partial class EarthAnchorPoint : System.IDisposable
{
  public EarthAnchorPoint() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean EarthLocationIsSet() => throw new System.NotImplementedException();

  public virtual System.Boolean ModelLocationIsSet() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane GetModelCompass() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Transform GetModelToEarthTransform(Rhino.UnitSystem modelUnitSystem) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane GetEarthAnchorPlane(out Rhino.Geometry.Vector3d anchorNorth) =>
    throw new System.NotImplementedException();

  public virtual System.Double EarthBasepointLatitude
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double EarthBasepointLongitude
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double EarthBasepointElevation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.EarthCoordinateSystem EarthBasepointElevationCoordinateSystem
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.BasepointZero EarthBasepointElevationZero
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double KMLOrientationHeadingAngleDegrees
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double KMLOrientationTiltAngleDegrees
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double KMLOrientationRollAngleDegrees
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double KMLOrientationHeadingAngleRadians
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double KMLOrientationTiltAngleRadians
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double KMLOrientationRollAngleRadians
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d ModelBasePoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d ModelNorth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d ModelEast
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

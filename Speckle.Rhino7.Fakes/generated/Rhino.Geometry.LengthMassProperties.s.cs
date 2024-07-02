namespace Rhino.Geometry;

public partial class LengthMassProperties : System.IDisposable
{
  public LengthMassProperties() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public static Rhino.Geometry.LengthMassProperties Compute(Rhino.Geometry.Curve curve) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.LengthMassProperties Compute(
    Rhino.Geometry.Curve curve,
    System.Boolean length,
    System.Boolean firstMoments,
    System.Boolean secondMoments,
    System.Boolean productMoments
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.LengthMassProperties Compute(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.LengthMassProperties Compute(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,
    System.Boolean length,
    System.Boolean firstMoments,
    System.Boolean secondMoments,
    System.Boolean productMoments
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean WorldCoordinatesPrincipalMoments(
    out System.Double x,
    out Rhino.Geometry.Vector3d xaxis,
    out System.Double y,
    out Rhino.Geometry.Vector3d yaxis,
    out System.Double z,
    out Rhino.Geometry.Vector3d zaxis
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean WorldCoordinatesPrincipalMomentsOfInertia(
    out System.Double x,
    out Rhino.Geometry.Vector3d xaxis,
    out System.Double y,
    out Rhino.Geometry.Vector3d yaxis,
    out System.Double z,
    out Rhino.Geometry.Vector3d zaxis
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CentroidCoordinatesPrincipalMoments(
    out System.Double x,
    out Rhino.Geometry.Vector3d xaxis,
    out System.Double y,
    out Rhino.Geometry.Vector3d yaxis,
    out System.Double z,
    out Rhino.Geometry.Vector3d zaxis
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CentroidCoordinatesPrincipalMomentsOfInertia(
    out System.Double x,
    out Rhino.Geometry.Vector3d xaxis,
    out System.Double y,
    out Rhino.Geometry.Vector3d yaxis,
    out System.Double z,
    out Rhino.Geometry.Vector3d zaxis
  ) => throw new System.NotImplementedException();

  public virtual System.Double Length
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double LengthError
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d Centroid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CentroidError
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d WorldCoordinatesFirstMoments
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d WorldCoordinatesFirstMomentsError
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d WorldCoordinatesSecondMoments
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d WorldCoordinatesSecondMomentsError
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d WorldCoordinatesProductMoments
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d WorldCoordinatesProductMomentsError
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d WorldCoordinatesMomentsOfInertia
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d WorldCoordinatesMomentsOfInertiaError
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d WorldCoordinatesRadiiOfGyration
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CentroidCoordinatesSecondMoments
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CentroidCoordinatesSecondMomentsError
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CentroidCoordinatesProductMoments
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CentroidCoordinatesProductMomentsError
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CentroidCoordinatesMomentsOfInertia
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CentroidCoordinatesMomentsOfInertiaError
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CentroidCoordinatesRadiiOfGyration
  {
    get => throw new System.NotImplementedException();
  }
}

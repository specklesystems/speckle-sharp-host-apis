namespace Rhino.Geometry;

public partial class Light : Rhino.Geometry.GeometryBase
{
  public Light() { }

  public static Rhino.Geometry.Light CreateSunLight(
    System.Double northAngleDegrees,
    System.Double azimuthDegrees,
    System.Double altitudeDegrees
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Light CreateSunLight(
    System.Double northAngleDegrees,
    System.DateTime when,
    System.Double latitudeDegrees,
    System.Double longitudeDegrees
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Light CreateSunLight(Rhino.Render.Sun sun) => throw new System.NotImplementedException();

  public virtual void SetAttenuation(System.Double a0, System.Double a1, System.Double a2) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetAttenuation(System.Double d) => throw new System.NotImplementedException();

  public virtual System.Boolean GetSpotLightRadii(out System.Double innerRadius, out System.Double outerRadius) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.LightStyle LightStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPointLight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsDirectionalLight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSpotLight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsLinearLight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsRectangularLight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSunLight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.CoordinateSystem CoordinateSystem
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d Location
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d Direction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d PerpendicularDirection
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Intensity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PowerWatts
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PowerLumens
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PowerCandela
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color Ambient
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color Diffuse
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color Specular
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d AttenuationVector
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SpotAngleRadians
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SpotExponent
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double HotSpot
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d Length
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d Width
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double SpotLightShadowIntensity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ShadowIntensity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid Id
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Light.Attenuation AttenuationType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

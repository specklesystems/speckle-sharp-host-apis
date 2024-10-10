namespace Rhino.Geometry;

public partial class SubDDisplayParameters : System.IDisposable, System.Runtime.Serialization.ISerializable
{
  public SubDDisplayParameters() { }

  public SubDDisplayParameters(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public static System.UInt32 ClampDisplayDensity(System.UInt32 displayDensity) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters Empty() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters ExtraCoarse() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters Coarse() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters Medium() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters Fine() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters ExtraFine() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters Default() => throw new System.NotImplementedException();

  public static System.UInt32 AbsoluteDisplayDensityFromSubDFaceCount(
    System.UInt32 adaptiveSubDDisplayDensity,
    System.UInt32 subDFaceCount
  ) => throw new System.NotImplementedException();

  public static System.UInt32 AbsoluteDisplayDensityFromSubD(
    System.UInt32 adaptiveSubDDisplayDensity,
    Rhino.Geometry.SubD subd
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters CreateFromDisplayDensity(
    System.UInt32 adaptiveSubDDisplayDensity
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters CreateFromAbsoluteDisplayDensity(
    System.UInt32 absoluteSubDDisplayDensity
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters CreateFromMeshDensity(System.Double normalizedMeshDensity) =>
    throw new System.NotImplementedException();

  public virtual System.UInt32 DisplayDensity(Rhino.Geometry.SubD subd) => throw new System.NotImplementedException();

  public virtual void SetAdaptiveDisplayDensity(System.UInt32 adaptiveDisplayDensity) =>
    throw new System.NotImplementedException();

  public virtual void SetAbsoluteDisplayDensity(System.UInt32 absoluteDisplayDensity) =>
    throw new System.NotImplementedException();

  public virtual void GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  public virtual System.String ToEncodedString() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDDisplayParameters FromEncodedString(System.String value) =>
    throw new System.NotImplementedException();

  public static System.UInt32 AdaptiveDisplayMeshQuadMaximum
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean DisplayDensityIsAdaptive
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean DisplayDensityIsAbsolute
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.SubDComponentLocation MeshLocation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

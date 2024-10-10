namespace Rhino.Geometry;

public partial class MeshingParameters
  : System.IDisposable,
    System.Runtime.Serialization.ISerializable,
    System.IEquatable<Rhino.Geometry.MeshingParameters>
{
  public MeshingParameters() { }

  public MeshingParameters(Rhino.Geometry.MeshingParameters source) => throw new System.NotImplementedException();

  public MeshingParameters(System.Double density) => throw new System.NotImplementedException();

  public MeshingParameters(System.Double density, System.Double minimumEdgeLength) =>
    throw new System.NotImplementedException();

  public MeshingParameters(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  public virtual void GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  public virtual System.String ToEncodedString() => throw new System.NotImplementedException();

  public static Rhino.Geometry.MeshingParameters FromEncodedString(System.String value) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Geometry.MeshingParameters other) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.MeshingParameters DocumentCurrentSetting(Rhino.RhinoDoc doc) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.SubDDisplayParameters SubDDisplayParameters() =>
    throw new System.NotImplementedException();

  public virtual void SetSubDDisplayParameters(Rhino.Geometry.SubDDisplayParameters subDDisplayParameters) =>
    throw new System.NotImplementedException();

  public virtual void CopyFrom(Rhino.Geometry.MeshingParameters source) => throw new System.NotImplementedException();

  public static Rhino.Geometry.MeshingParameters Minimal
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.MeshingParameters Default
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.MeshingParameters Coarse
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.MeshingParameters FastRenderMesh
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.MeshingParameters Smooth
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.MeshingParameters QualityRenderMesh
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.MeshingParameters DefaultAnalysisMesh
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.MeshingParameterTextureRange TextureRange
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean JaggedSeams
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean RefineGrid
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DoublePrecision
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SimplePlanes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ComputeCurvature
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ClosedObjectPostProcess
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 GridMinCount
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 GridMaxCount
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double GridAngle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double GridAspectRatio
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double GridAmplification
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Tolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double MinimumTolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double RelativeTolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double MinimumEdgeLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double MaximumEdgeLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double RefineAngle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double RefineAngleInDegrees
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

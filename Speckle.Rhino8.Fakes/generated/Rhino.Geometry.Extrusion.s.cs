namespace Rhino.Geometry;

public partial class Extrusion : Rhino.Geometry.Surface
{
  public Extrusion() { }

  public static Rhino.Geometry.Extrusion Create(
    Rhino.Geometry.Curve planarCurve,
    System.Double height,
    System.Boolean cap
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Extrusion Create(
    Rhino.Geometry.Curve curve,
    Rhino.Geometry.Plane plane,
    System.Double height,
    System.Boolean cap
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Extrusion CreateBoxExtrusion(Rhino.Geometry.Box box, System.Boolean cap) =>
    throw new System.NotImplementedException();

  public static Rhino.Geometry.Extrusion CreateCylinderExtrusion(
    Rhino.Geometry.Cylinder cylinder,
    System.Boolean capBottom,
    System.Boolean capTop
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Extrusion CreatePipeExtrusion(
    Rhino.Geometry.Cylinder cylinder,
    System.Double otherRadius,
    System.Boolean capTop,
    System.Boolean capBottom
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep ToBrep(System.Boolean splitKinkyFaces) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.ComponentIndex GetBrepFormComponentIndex(
    Rhino.Geometry.ComponentIndex extrusionComponentIndex
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetPathAndUp(
    Rhino.Geometry.Point3d a,
    Rhino.Geometry.Point3d b,
    Rhino.Geometry.Vector3d up
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Transform GetProfileTransformation(System.Double s) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane GetProfilePlane(System.Double s) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane GetPathPlane(System.Double s) => throw new System.NotImplementedException();

  public virtual System.Boolean SetOuterProfile(Rhino.Geometry.Curve outerProfile, System.Boolean cap) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean AddInnerProfile(Rhino.Geometry.Curve innerProfile) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve Profile3d(System.Int32 profileIndex, System.Double s) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve Profile3d(Rhino.Geometry.ComponentIndex ci) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve WallEdge(Rhino.Geometry.ComponentIndex ci) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Surface WallSurface(Rhino.Geometry.ComponentIndex ci) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.LineCurve PathLineCurve() => throw new System.NotImplementedException();

  public virtual System.Int32 ProfileIndex(System.Double profileParameter) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh GetMesh(Rhino.Geometry.MeshType meshType) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetMesh(Rhino.Geometry.Mesh mesh, Rhino.Geometry.MeshType meshType) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve[] GetWireframe() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d PathStart
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d PathEnd
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d PathTangent
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d MiterPlaneNormalAtStart
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d MiterPlaneNormalAtEnd
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsMiteredAtStart
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsMiteredAtEnd
  {
    get => throw new System.NotImplementedException();
  }
  public new System.Boolean IsSolid
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsCappedAtBottom
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsCappedAtTop
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 CapCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ProfileCount
  {
    get => throw new System.NotImplementedException();
  }
}

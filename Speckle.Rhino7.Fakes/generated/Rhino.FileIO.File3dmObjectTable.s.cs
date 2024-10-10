namespace Rhino.FileIO;

public partial class File3dmObjectTable : Rhino.FileIO.File3dmCommonComponentTable<Rhino.FileIO.File3dmObject>
{
  public File3dmObjectTable() { }

  public virtual Rhino.FileIO.File3dmObject[] FindByLayer(System.String layer) =>
    throw new System.NotImplementedException();

  public virtual Rhino.FileIO.File3dmObject[] FindByLayer(Rhino.DocObjects.Layer layer) =>
    throw new System.NotImplementedException();

  public virtual Rhino.FileIO.File3dmObject[] FindByGroup(Rhino.DocObjects.Group group) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BoundingBox GetBoundingBox() => throw new System.NotImplementedException();

  public virtual System.Guid AddPoint(System.Double x, System.Double y, System.Double z) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddPoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();

  public virtual System.Guid AddPoint(Rhino.Geometry.Point3d point, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddPoint(Rhino.Geometry.Point3f point) => throw new System.NotImplementedException();

  public virtual System.Guid AddPoint(Rhino.Geometry.Point3f point, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid[] AddPoints(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) =>
    throw new System.NotImplementedException();

  public virtual System.Guid[] AddPoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid[] AddPoints(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3f> points) =>
    throw new System.NotImplementedException();

  public virtual System.Guid[] AddPoints(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3f> points,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddPointCloud(Rhino.Geometry.PointCloud cloud) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddPointCloud(
    Rhino.Geometry.PointCloud cloud,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddPointCloud(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddPointCloud(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddClippingPlane(
    Rhino.Geometry.Plane plane,
    System.Double uMagnitude,
    System.Double vMagnitude,
    System.Guid clippedViewportId
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddClippingPlane(
    Rhino.Geometry.Plane plane,
    System.Double uMagnitude,
    System.Double vMagnitude,
    System.Collections.Generic.IEnumerable<System.Guid> clippedViewportIds
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddClippingPlane(
    Rhino.Geometry.Plane plane,
    System.Double uMagnitude,
    System.Double vMagnitude,
    System.Collections.Generic.IEnumerable<System.Guid> clippedViewportIds,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddLinearDimension(Rhino.Geometry.LinearDimension dimension) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddLinearDimension(
    Rhino.Geometry.LinearDimension dimension,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddAngularDimension(Rhino.Geometry.AngularDimension dimension) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddAngularDimension(
    Rhino.Geometry.AngularDimension dimension,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddLine(Rhino.Geometry.Point3d from, Rhino.Geometry.Point3d to) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddLine(
    Rhino.Geometry.Point3d from,
    Rhino.Geometry.Point3d to,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddLine(Rhino.Geometry.Line line) => throw new System.NotImplementedException();

  public virtual System.Guid AddLine(Rhino.Geometry.Line line, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddPolyline(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddPolyline(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddArc(Rhino.Geometry.Arc arc) => throw new System.NotImplementedException();

  public virtual System.Guid AddArc(Rhino.Geometry.Arc arc, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddCircle(Rhino.Geometry.Circle circle) => throw new System.NotImplementedException();

  public virtual System.Guid AddCircle(Rhino.Geometry.Circle circle, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddEllipse(Rhino.Geometry.Ellipse ellipse) => throw new System.NotImplementedException();

  public virtual System.Guid AddEllipse(Rhino.Geometry.Ellipse ellipse, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddSphere(Rhino.Geometry.Sphere sphere) => throw new System.NotImplementedException();

  public virtual System.Guid AddSphere(Rhino.Geometry.Sphere sphere, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddCurve(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();

  public virtual System.Guid AddCurve(Rhino.Geometry.Curve curve, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddTextDot(System.String text, Rhino.Geometry.Point3d location) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddTextDot(
    System.String text,
    Rhino.Geometry.Point3d location,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddTextDot(Rhino.Geometry.TextDot dot) => throw new System.NotImplementedException();

  public virtual System.Guid AddTextDot(Rhino.Geometry.TextDot dot, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddInstanceObject(Rhino.Geometry.InstanceReferenceGeometry instanceReference) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddInstanceObject(
    Rhino.Geometry.InstanceReferenceGeometry instanceReference,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddInstanceObject(
    System.Int32 instanceDefinitionIndex,
    Rhino.Geometry.Transform instanceXform
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddInstanceObject(
    System.Int32 instanceDefinitionIndex,
    Rhino.Geometry.Transform instanceXform,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddText(Rhino.Display.Text3d text3d) => throw new System.NotImplementedException();

  public virtual System.Guid AddText(Rhino.Display.Text3d text3d, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddText(
    System.String text,
    Rhino.Geometry.Plane plane,
    System.Double height,
    System.String fontName,
    System.Boolean bold,
    System.Boolean italic
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddText(
    System.String text,
    Rhino.Geometry.Plane plane,
    System.Double height,
    System.String fontName,
    System.Boolean bold,
    System.Boolean italic,
    Rhino.Geometry.TextJustification justification
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddText(
    System.String text,
    Rhino.Geometry.Plane plane,
    System.Double height,
    System.String fontName,
    System.Boolean bold,
    System.Boolean italic,
    Rhino.Geometry.TextJustification justification,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddText(
    System.String text,
    Rhino.Geometry.Plane plane,
    System.Double height,
    System.String fontName,
    System.Boolean bold,
    System.Boolean italic,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddSurface(Rhino.Geometry.Surface surface) => throw new System.NotImplementedException();

  public virtual System.Guid AddSurface(Rhino.Geometry.Surface surface, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddExtrusion(Rhino.Geometry.Extrusion extrusion) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddExtrusion(
    Rhino.Geometry.Extrusion extrusion,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddMesh(Rhino.Geometry.Mesh mesh) => throw new System.NotImplementedException();

  public virtual System.Guid AddMesh(Rhino.Geometry.Mesh mesh, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddBrep(Rhino.Geometry.Brep brep) => throw new System.NotImplementedException();

  public virtual System.Guid AddBrep(Rhino.Geometry.Brep brep, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddLeader(
    Rhino.Geometry.Plane plane,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> points
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddLeader(
    Rhino.Geometry.Plane plane,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> points,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddLeader(
    System.String text,
    Rhino.Geometry.Plane plane,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> points,
    Rhino.DocObjects.ObjectAttributes attributes
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddLeader(
    System.String text,
    Rhino.Geometry.Plane plane,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point2d> points
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddLeader(
    System.String text,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points
  ) => throw new System.NotImplementedException();

  public virtual System.Guid AddLeader(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddHatch(Rhino.Geometry.Hatch hatch) => throw new System.NotImplementedException();

  public virtual System.Guid AddHatch(Rhino.Geometry.Hatch hatch, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Guid AddSubD(Rhino.Geometry.SubD subd) => throw new System.NotImplementedException();

  public virtual System.Guid AddSubD(Rhino.Geometry.SubD subd, Rhino.DocObjects.ObjectAttributes attributes) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Delete(System.Guid objectId) => throw new System.NotImplementedException();

  public virtual System.Int32 Delete(System.Collections.Generic.IEnumerable<System.Guid> objectIds) =>
    throw new System.NotImplementedException();

  public override Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  public override System.Int32 Count
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Rhino.DocObjects;

public partial class ObjRef : System.IDisposable
{
  public ObjRef() { }

  public ObjRef(Rhino.DocObjects.ObjRef other) => throw new System.NotImplementedException();

  public ObjRef(System.Guid id) => throw new System.NotImplementedException();

  public ObjRef(Rhino.RhinoDoc doc, System.Guid id) => throw new System.NotImplementedException();

  public ObjRef(System.Guid id, Rhino.Geometry.ComponentIndex ci) => throw new System.NotImplementedException();

  public ObjRef(Rhino.RhinoDoc doc, System.Guid id, Rhino.Geometry.ComponentIndex ci) =>
    throw new System.NotImplementedException();

  public ObjRef(Rhino.DocObjects.RhinoObject rhinoObject) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.GeometryBase Geometry() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.ClippingPlaneSurface ClippingPlaneSurface() =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve Curve() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepEdge Edge() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepFace Face() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BrepTrim Trim() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep Brep() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Surface Surface() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.TextDot TextDot() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Mesh Mesh() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.SubD SubD() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.SubDFace SubDFace() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point Point() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.PointCloud PointCloud() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.TextEntity TextEntity() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Light Light() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Hatch Hatch() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.RhinoObject Object() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.RhinoObject InstanceDefinitionPart() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.SelectionMethod SelectionMethod() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d SelectionPoint() => throw new System.NotImplementedException();

  public virtual System.UInt32 SelectionViewDetailSerialNumber() => throw new System.NotImplementedException();

  public virtual Rhino.Display.RhinoView SelectionView() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve CurveParameter(out System.Double parameter) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Surface SurfaceParameter(out System.Double u, out System.Double v) =>
    throw new System.NotImplementedException();

  public virtual void SetSelectionComponent(Rhino.Geometry.ComponentIndex componentIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Guid ObjectId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt32 RuntimeSerialNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.ComponentIndex GeometryComponentIndex
  {
    get => throw new System.NotImplementedException();
  }
}

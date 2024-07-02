namespace Rhino.Collections;

public partial class CurveList : Rhino.Collections.RhinoList<Rhino.Geometry.Curve>
{
  public CurveList() { }

  public CurveList(System.Int32 initialCapacity) => throw new System.NotImplementedException();

  public CurveList(System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> collection) =>
    throw new System.NotImplementedException();

  public virtual void Add(Rhino.Geometry.Line line) => throw new System.NotImplementedException();

  public virtual void Add(Rhino.Geometry.Circle circle) => throw new System.NotImplementedException();

  public virtual void Add(Rhino.Geometry.Arc arc) => throw new System.NotImplementedException();

  public virtual void Add(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> polyline) =>
    throw new System.NotImplementedException();

  public virtual void Add(Rhino.Geometry.Ellipse ellipse) => throw new System.NotImplementedException();

  public virtual void Insert(System.Int32 index, Rhino.Geometry.Line line) =>
    throw new System.NotImplementedException();

  public virtual void Insert(System.Int32 index, Rhino.Geometry.Circle circle) =>
    throw new System.NotImplementedException();

  public virtual void Insert(System.Int32 index, Rhino.Geometry.Arc arc) => throw new System.NotImplementedException();

  public virtual void Insert(
    System.Int32 index,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> polyline
  ) => throw new System.NotImplementedException();

  public virtual void Insert(System.Int32 index, Rhino.Geometry.Ellipse ellipse) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Transform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
}

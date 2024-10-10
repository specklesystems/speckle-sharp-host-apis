namespace Rhino.Geometry;

public partial class HiddenLineDrawingParameters
{
  public HiddenLineDrawingParameters() { }

  public virtual void SetViewport(Rhino.DocObjects.ViewportInfo viewport) => throw new System.NotImplementedException();

  public virtual void SetViewport(Rhino.Display.RhinoViewport viewport) => throw new System.NotImplementedException();

  public virtual void AddClippingPlane(Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();

  public virtual System.Boolean AddGeometry(Rhino.Geometry.GeometryBase geometry, System.Object tag) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean AddGeometry(
    Rhino.Geometry.GeometryBase geometry,
    System.Object tag,
    System.Boolean occluding_sections
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AddGeometry(
    Rhino.Geometry.GeometryBase geometry,
    Rhino.Geometry.Transform xform,
    System.Object tag
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AddGeometry(
    Rhino.Geometry.GeometryBase geometry,
    Rhino.Geometry.Transform xform,
    System.Object tag,
    System.Boolean occluding_sections
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AddGeometryAndPlanes(
    Rhino.Geometry.GeometryBase geometry,
    System.Object tag,
    System.Collections.Generic.List<Rhino.Geometry.Plane> clips
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AddGeometryAndPlanes(
    Rhino.Geometry.GeometryBase geometry,
    System.Object tag,
    System.Boolean occluding_sections,
    System.Collections.Generic.List<Rhino.Geometry.Plane> clips
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AddGeometryAndPlanes(
    Rhino.Geometry.GeometryBase geometry,
    Rhino.Geometry.Transform xform,
    System.Object tag,
    System.Collections.Generic.List<Rhino.Geometry.Plane> clips
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean AddGeometryAndPlanes(
    Rhino.Geometry.GeometryBase geometry,
    Rhino.Geometry.Transform xform,
    System.Object tag,
    System.Boolean occluding_sections,
    System.Collections.Generic.List<Rhino.Geometry.Plane> clips
  ) => throw new System.NotImplementedException();

  public virtual System.Double AbsoluteTolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Flatten
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IncludeTangentEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IncludeTangentSeams
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IncludeHiddenCurves
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean OccludingSectionOption
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

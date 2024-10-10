namespace Rhino.Geometry;

public partial class Hatch : Rhino.Geometry.GeometryBase
{
  public Hatch() { }

  public static Rhino.Geometry.Hatch CreateFromBrep(
    Rhino.Geometry.Brep brep,
    System.Int32 brepFaceIndex,
    System.Int32 hatchPatternIndex,
    System.Double rotationRadians,
    System.Double scale,
    Rhino.Geometry.Point3d basePoint
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Hatch Create(
    Rhino.Geometry.Plane hatchPlane,
    Rhino.Geometry.Curve outerLoop,
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> innerLoops,
    System.Int32 hatchPatternIndex,
    System.Double rotationRadians,
    System.Double scale
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Hatch[] Create(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,
    System.Int32 hatchPatternIndex,
    System.Double rotationRadians,
    System.Double scale
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Hatch[] Create(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Curve> curves,
    System.Int32 hatchPatternIndex,
    System.Double rotationRadians,
    System.Double scale,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Hatch[] Create(
    Rhino.Geometry.Curve curve,
    System.Int32 hatchPatternIndex,
    System.Double rotationRadians,
    System.Double scale
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.Hatch[] Create(
    Rhino.Geometry.Curve curve,
    System.Int32 hatchPatternIndex,
    System.Double rotationRadians,
    System.Double scale,
    System.Double tolerance
  ) => throw new System.NotImplementedException();

  public virtual void CreateDisplayGeometry(
    Rhino.DocObjects.HatchPattern pattern,
    System.Double patternScale,
    out Rhino.Geometry.Curve[] bounds,
    out Rhino.Geometry.Line[] lines,
    out Rhino.Geometry.Brep solidBrep
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.GeometryBase[] Explode() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Curve[] Get3dCurves(System.Boolean outer) => throw new System.NotImplementedException();

  public virtual void ScalePattern(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();

  public virtual Rhino.Display.ColorGradient GetGradientFill() => throw new System.NotImplementedException();

  public virtual void SetGradientFill(Rhino.Display.ColorGradient fill) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Brep ToBrep() => throw new System.NotImplementedException();

  public virtual System.Int32 PatternIndex
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PatternRotation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d BasePoint
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Plane Plane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double PatternScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

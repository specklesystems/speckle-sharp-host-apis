namespace Rhino.Geometry;

public partial class SurfaceFilletBase : System.IDisposable
{
  public SurfaceFilletBase() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean TrimBreps(
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> TrimmedBreps0,
    System.Collections.Generic.List<Rhino.Geometry.Brep> TrimmedBreps1
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean RationalArcs(
    System.Int32 railDegree,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean NonRationalQuinticArcs(
    System.Int32 railDegree,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean NonRationalQuintic(
    System.Int32 railDegree,
    System.Double TanSlider,
    System.Double InnerSlider,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean NonRationalQuarticArcs(
    System.Int32 railDegree,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean NonRationalQuartic(
    System.Int32 railDegree,
    System.Double TanSlider,
    System.Double InnerSlider,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean NonRationalCubicArcs(
    System.Int32 railDegree,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean NonRationalCubic(
    System.Int32 railDegree,
    System.Double TanSlider,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean G2ChordalQuintic(
    System.Int32 railDegree,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public static System.Boolean CreateRationalArcsFilletSrf(
    Rhino.Geometry.BrepFace faceA,
    Rhino.Geometry.Point2d uvA,
    Rhino.Geometry.BrepFace faceB,
    Rhino.Geometry.Point2d uvB,
    System.Double radius,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsA,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsB,
    System.Int32 rail_degree,
    System.Boolean bTrim,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public static System.Boolean CreateNonRationalQuinticArcsFilletSrf(
    Rhino.Geometry.BrepFace faceA,
    Rhino.Geometry.Point2d uvA,
    Rhino.Geometry.BrepFace faceB,
    Rhino.Geometry.Point2d uvB,
    System.Double radius,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsA,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsB,
    System.Int32 rail_degree,
    System.Boolean bTrim,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public static System.Boolean CreateNonRationalQuinticFilletSrf(
    Rhino.Geometry.BrepFace faceA,
    Rhino.Geometry.Point2d uvA,
    Rhino.Geometry.BrepFace faceB,
    Rhino.Geometry.Point2d uvB,
    System.Double radius,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsA,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsB,
    System.Int32 rail_degree,
    System.Double TanSlider,
    System.Double InnerSlider,
    System.Boolean bTrim,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public static System.Boolean CreateNonRationalQuarticArcsFilletSrf(
    Rhino.Geometry.BrepFace faceA,
    Rhino.Geometry.Point2d uvA,
    Rhino.Geometry.BrepFace faceB,
    Rhino.Geometry.Point2d uvB,
    System.Double radius,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsA,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsB,
    System.Int32 rail_degree,
    System.Boolean bTrim,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public static System.Boolean CreateNonRationalQuarticFilletSrf(
    Rhino.Geometry.BrepFace faceA,
    Rhino.Geometry.Point2d uvA,
    Rhino.Geometry.BrepFace faceB,
    Rhino.Geometry.Point2d uvB,
    System.Double radius,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsA,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsB,
    System.Int32 rail_degree,
    System.Double TanSlider,
    System.Double InnerSlider,
    System.Boolean bTrim,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public static System.Boolean CreateNonRationalCubicArcsFilletSrf(
    Rhino.Geometry.BrepFace faceA,
    Rhino.Geometry.Point2d uvA,
    Rhino.Geometry.BrepFace faceB,
    Rhino.Geometry.Point2d uvB,
    System.Double radius,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsA,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsB,
    System.Int32 rail_degree,
    System.Boolean bTrim,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public static System.Boolean CreateNonRationalCubicFilletSrf(
    Rhino.Geometry.BrepFace faceA,
    Rhino.Geometry.Point2d uvA,
    Rhino.Geometry.BrepFace faceB,
    Rhino.Geometry.Point2d uvB,
    System.Double radius,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsA,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsB,
    System.Int32 rail_degree,
    System.Double TanSlider,
    System.Boolean bTrim,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public static System.Boolean CreateG2ChordalQuinticFilletSrf(
    Rhino.Geometry.BrepFace faceA,
    Rhino.Geometry.Point2d uvA,
    Rhino.Geometry.BrepFace faceB,
    Rhino.Geometry.Point2d uvB,
    System.Double radius,
    System.Double tolerance,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsA,
    System.Collections.Generic.List<Rhino.Geometry.Brep> trimmedBrepsB,
    System.Int32 rail_degree,
    System.Boolean bTrim,
    System.Boolean bExtend,
    System.Collections.Generic.List<Rhino.Geometry.Brep> Fillets
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsInitialized() => throw new System.NotImplementedException();
}

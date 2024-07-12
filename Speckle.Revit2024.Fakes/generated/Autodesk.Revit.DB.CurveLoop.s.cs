namespace Autodesk.Revit.DB;

public partial class CurveLoop
  : System.Collections.Generic.IEnumerable<Autodesk.Revit.DB.Curve>,
    System.Collections.IEnumerable,
    System.IDisposable
{
  public CurveLoop() { }

  public static Autodesk.Revit.DB.CurveLoop Create(System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves) =>
    throw new System.NotImplementedException();

  public virtual void Append(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Plane GetPlane() => throw new System.NotImplementedException();

  public virtual System.Boolean HasPlane() => throw new System.NotImplementedException();

  public virtual System.Double GetExactLength() => throw new System.NotImplementedException();

  public virtual System.Boolean IsRectangular(Autodesk.Revit.DB.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetRectangularWidth(Autodesk.Revit.DB.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetRectangularHeight(Autodesk.Revit.DB.Plane plane) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.CurveLoop CreateViaThicken(
    Autodesk.Revit.DB.CurveLoop curveLoop,
    System.Double thickness,
    Autodesk.Revit.DB.XYZ normal
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.CurveLoop CreateViaThicken(
    Autodesk.Revit.DB.Curve pCurve,
    System.Double thickness,
    Autodesk.Revit.DB.XYZ normal
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.CurveLoop CreateViaTransform(
    Autodesk.Revit.DB.CurveLoop curveLoop,
    Autodesk.Revit.DB.Transform transform
  ) => throw new System.NotImplementedException();

  public virtual void Transform(Autodesk.Revit.DB.Transform transform) => throw new System.NotImplementedException();

  public virtual System.Boolean IsOpen() => throw new System.NotImplementedException();

  public virtual System.Boolean IsCounterclockwise(Autodesk.Revit.DB.XYZ normal) =>
    throw new System.NotImplementedException();

  public virtual void Flip() => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.CurveLoop CreateViaCopy(Autodesk.Revit.DB.CurveLoop original) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.CurveLoop CreateViaOffset(
    Autodesk.Revit.DB.CurveLoop original,
    System.Collections.Generic.IList<System.Double> offsetDists,
    Autodesk.Revit.DB.XYZ normal
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.CurveLoop CreateViaOffset(
    Autodesk.Revit.DB.CurveLoop original,
    System.Double offsetDist,
    Autodesk.Revit.DB.XYZ normal
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveLoopIterator GetCurveLoopIterator() =>
    throw new System.NotImplementedException();

  public virtual System.Int32 NumberOfCurves() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerator<Autodesk.Revit.DB.Curve> GetEnumerator() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

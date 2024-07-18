namespace Autodesk.Revit.DB;

public partial class CurveElement : Autodesk.Revit.DB.Element
{
  public CurveElement() { }

  public virtual void SetGeometryCurve(Autodesk.Revit.DB.Curve curve, System.Boolean overrideJoins) =>
    throw new System.NotImplementedException();

  public virtual void SetSketchPlaneAndCurve(
    Autodesk.Revit.DB.SketchPlane sketchPlane,
    Autodesk.Revit.DB.Curve curve
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetLineStyleIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAdjoinedCurveElements(
    System.Int32 end
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsAdjoinedCurveElement(System.Int32 end, Autodesk.Revit.DB.ElementId other) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasTangentJoin(System.Int32 end, Autodesk.Revit.DB.ElementId other) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasTangentLocks(System.Int32 end) => throw new System.NotImplementedException();

  public virtual System.Boolean GetTangentLock(System.Int32 end, Autodesk.Revit.DB.ElementId other) =>
    throw new System.NotImplementedException();

  public virtual void SetTangentLock(System.Int32 end, Autodesk.Revit.DB.ElementId other, System.Boolean state) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SupportsTangentLocks
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.CurveElementType CurveElementType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Element LineStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.SketchPlane SketchPlane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Reference CenterPointReference
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Curve GeometryCurve
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

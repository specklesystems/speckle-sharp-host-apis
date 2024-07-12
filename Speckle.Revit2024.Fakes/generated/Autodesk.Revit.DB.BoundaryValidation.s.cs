namespace Autodesk.Revit.DB;

public partial class BoundaryValidation : System.IDisposable
{
  public BoundaryValidation() { }

  public static System.Boolean IsValidHorizontalBoundary(
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> curveLoops
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidBoundaryOnView(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewId,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> curveLoops
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidBoundaryOnSketchPlane(
    Autodesk.Revit.DB.SketchPlane sketchPlane,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> curveLoops
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

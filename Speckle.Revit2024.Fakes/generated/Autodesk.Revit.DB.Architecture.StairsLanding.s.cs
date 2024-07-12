namespace Autodesk.Revit.DB.Architecture;

public partial class StairsLanding : Autodesk.Revit.DB.Element
{
  public StairsLanding() { }

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> CreateAutomaticLanding(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId firstRunId,
    Autodesk.Revit.DB.ElementId secondRunId
  ) => throw new System.NotImplementedException();

  public static System.Boolean CanCreateAutomaticLanding(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId firstRunId,
    Autodesk.Revit.DB.ElementId secondRunId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Architecture.StairsLanding CreateSketchedLanding(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId stairsId,
    Autodesk.Revit.DB.CurveLoop curveLoop,
    System.Double baseElevation
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Architecture.StairsLanding CreateSketchedLandingWithSlopeData(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId stairsId,
    System.Collections.Generic.IList<Autodesk.Revit.DB.SketchedStairsCurveData> curveLoop,
    System.Double baseElevation
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveLoop GetFootprintBoundary() => throw new System.NotImplementedException();

  public virtual void SetSketchedLandingBoundaryAndPath(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.CurveLoop boundaryCurveLoop,
    Autodesk.Revit.DB.CurveLoop pathCurveLoop
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Stairs GetStairs() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetAllSupports() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveLoop GetStairsPath() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Architecture.StairsComponentConnection> GetConnections() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsAutomaticLanding
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double BaseElevation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Thickness
  {
    get => throw new System.NotImplementedException();
  }
}

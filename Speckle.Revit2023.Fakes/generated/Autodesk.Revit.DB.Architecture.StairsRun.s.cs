namespace Autodesk.Revit.DB.Architecture;

public partial class StairsRun : Autodesk.Revit.DB.Element
{
  public static System.Boolean SetLocationPathForStraightRun(
    Autodesk.Revit.DB.Architecture.StairsRun stairsRun,
    Autodesk.Revit.DB.Line locationPath
  ) => throw new System.NotImplementedException();

  public static System.Boolean SetLocationPathForSpiralRun(
    Autodesk.Revit.DB.Architecture.StairsRun stairsRun,
    Autodesk.Revit.DB.XYZ center,
    System.Double radius,
    System.Double startAngle,
    System.Double includedAngle,
    System.Boolean clockwise,
    Autodesk.Revit.DB.Architecture.StairsRunJustification justification
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetNumberSystemReference(
    Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption referenceOption
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Architecture.StairsComponentConnection> GetConnections() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetLeftSupports() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetRightSupports() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetAllSupports() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.Stairs GetStairs() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveLoop GetStairsPath() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveLoop GetFootprintBoundary() => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Architecture.StairsRun CreateSketchedRun(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId stairsId,
    System.Double baseElevation,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> boundaryCurves,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> riserCurves,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> stairsPath
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Architecture.StairsRun CreateSketchedRunWithSlopeData(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId stairsId,
    System.Double baseElevation,
    System.Collections.Generic.IList<Autodesk.Revit.DB.SketchedStairsCurveData> boundaryCurves,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> riserCurves,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> stairsPath
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Architecture.StairsRun CreateStraightRun(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId stairsId,
    Autodesk.Revit.DB.Line locationPath,
    Autodesk.Revit.DB.Architecture.StairsRunJustification justification
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Architecture.StairsRun CreateSpiralRun(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId stairsId,
    Autodesk.Revit.DB.XYZ center,
    System.Double radius,
    System.Double startAngle,
    System.Double includedAngle,
    System.Boolean clockwise,
    Autodesk.Revit.DB.Architecture.StairsRunJustification justification
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Architecture.StairsRunJustification LocationLineJustification
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean EndsWithRiser
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean BeginsWithRiser
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ExtensionBelowTreadBase
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ExtensionBelowRiserBase
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ActualTreadsNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 ActualRisersNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ActualRunWidth
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double TopElevation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BaseElevation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Architecture.StairsRunStyle StairsRunStyle
  {
    get => throw new System.NotImplementedException();
  }
}

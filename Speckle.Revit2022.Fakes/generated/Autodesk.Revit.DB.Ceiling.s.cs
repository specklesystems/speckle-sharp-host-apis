namespace Autodesk.Revit.DB;

public partial class Ceiling : Autodesk.Revit.DB.CeilingAndFloor
{
  public Ceiling() { }

  public static Autodesk.Revit.DB.Ceiling Create(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> curveLoops,
    Autodesk.Revit.DB.ElementId ceilingTypeId,
    Autodesk.Revit.DB.ElementId levelId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Ceiling Create(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> curveLoops,
    Autodesk.Revit.DB.ElementId ceilingTypeId,
    Autodesk.Revit.DB.ElementId levelId,
    Autodesk.Revit.DB.Line slopeArrow,
    System.Double slope
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId SketchId
  {
    get => throw new System.NotImplementedException();
  }
}

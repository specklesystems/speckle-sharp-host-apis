namespace Autodesk.Revit.DB;

public partial class MultiSegmentGrid : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.ElementId Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId typeId,
    Autodesk.Revit.DB.CurveLoop curveLoop,
    Autodesk.Revit.DB.ElementId sketchPlaneId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetMultiSegementGridId(Autodesk.Revit.DB.Grid grid) =>
    throw new System.NotImplementedException();

  public static System.Boolean AreGridsInSameMultiSegmentGrid(
    Autodesk.Revit.DB.Grid grid1,
    Autodesk.Revit.DB.Grid grid2
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidSketchPlaneId(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elemId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidCurveLoop(Autodesk.Revit.DB.CurveLoop curveLoop) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetGridIds() =>
    throw new System.NotImplementedException();

  public virtual System.String Text
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

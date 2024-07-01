namespace Autodesk.Revit.DB;

public partial class Floor : Autodesk.Revit.DB.CeilingAndFloor
{
  public virtual Autodesk.Revit.DB.XYZ GetVerticalProjectionPoint(
    Autodesk.Revit.DB.XYZ modelLocation,
    Autodesk.Revit.DB.FloorFace floorFace
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ GetNormalAtVerticalProjectionPoint(
    Autodesk.Revit.DB.XYZ modelLocation,
    Autodesk.Revit.DB.FloorFace floorFace
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetSpanDirectionSymbolIds() =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Floor Create(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profile,
    Autodesk.Revit.DB.ElementId floorTypeId,
    Autodesk.Revit.DB.ElementId levelId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Floor Create(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> profile,
    Autodesk.Revit.DB.ElementId floorTypeId,
    Autodesk.Revit.DB.ElementId levelId,
    System.Boolean isStructural,
    Autodesk.Revit.DB.Line slopeArrow,
    System.Double slope
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElementId GetDefaultFloorType(
    Autodesk.Revit.DB.Document document,
    System.Boolean isFoundation
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId SketchId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double SpanDirectionAngle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.FloorType FloorType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.SlabShapeEditor SlabShapeEditor
  {
    get => throw new System.NotImplementedException();
  }
}

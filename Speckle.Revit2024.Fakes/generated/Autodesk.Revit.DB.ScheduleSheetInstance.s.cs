namespace Autodesk.Revit.DB;

public partial class ScheduleSheetInstance : Autodesk.Revit.DB.Element
{
  public ScheduleSheetInstance() { }

  public static Autodesk.Revit.DB.ScheduleSheetInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewSheetId,
    Autodesk.Revit.DB.ElementId scheduleId,
    Autodesk.Revit.DB.XYZ origin,
    System.Int32 segmentIndex
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ScheduleSheetInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewSheetId,
    Autodesk.Revit.DB.ElementId scheduleId,
    Autodesk.Revit.DB.XYZ origin
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsTitleblockRevisionSchedule
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 SegmentIndex
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ViewportRotation Rotation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Point
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId ScheduleId
  {
    get => throw new System.NotImplementedException();
  }
}

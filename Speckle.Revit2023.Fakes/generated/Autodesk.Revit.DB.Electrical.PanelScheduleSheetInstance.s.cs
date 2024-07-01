namespace Autodesk.Revit.DB.Electrical;

public partial class PanelScheduleSheetInstance : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.Electrical.PanelScheduleSheetInstance Create(
    Autodesk.Revit.DB.Document ADoc,
    Autodesk.Revit.DB.ElementId scheduleId,
    Autodesk.Revit.DB.View DBView
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.PanelScheduleView GetSchedule() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SplitSegment(System.Int32 iSeg) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId ScheduleId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Origin
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

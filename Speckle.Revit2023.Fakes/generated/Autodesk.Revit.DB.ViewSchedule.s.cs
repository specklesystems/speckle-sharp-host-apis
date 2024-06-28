namespace Autodesk.Revit.DB;

public partial class ViewSchedule : Autodesk.Revit.DB.TableView
{
	public virtual Autodesk.Revit.DB.ScheduleHeightsOnSheet GetScheduleHeightsOnSheet() => throw new System.NotImplementedException();
	public virtual void RestoreImageSize() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Color GetStripedRowsColor(Autodesk.Revit.DB.StripedRowPattern index) => throw new System.NotImplementedException();
	public virtual void SetStripedRowsColor(Autodesk.Revit.DB.StripedRowPattern index,Autodesk.Revit.DB.Color color) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TableData GetTableData() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleDefinition EmbeddedDefinition
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ScheduleDefinition Definition
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId BodyTextTypeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId HeaderTextTypeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId TitleTextTypeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

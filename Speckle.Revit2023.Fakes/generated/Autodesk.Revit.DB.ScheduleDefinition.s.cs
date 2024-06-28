namespace Autodesk.Revit.DB;

public partial class ScheduleDefinition : System.Object
{
	public virtual void AddEmbeddedSchedule(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual void RemoveEmbeddedSchedule() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField AddField(Autodesk.Revit.DB.ScheduleFieldType fieldType,Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField AddField(Autodesk.Revit.DB.ScheduleFieldType fieldType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField AddField(Autodesk.Revit.DB.SchedulableField schedulableField) => throw new System.NotImplementedException();
	public virtual void RemoveField(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual void ClearFields() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField GetField(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual void AddSortGroupField(Autodesk.Revit.DB.ScheduleSortGroupField sortGroupField) => throw new System.NotImplementedException();
	public virtual void ClearSortGroupFields() => throw new System.NotImplementedException();
	public virtual void AddFilter(Autodesk.Revit.DB.ScheduleFilter filter) => throw new System.NotImplementedException();
	public virtual void ClearFilters() => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.ScheduleDefinition EmbeddedDefinition
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId FamilyId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId AreaSchemeId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId CategoryId
	{
		get => throw new System.NotImplementedException();
	}
}

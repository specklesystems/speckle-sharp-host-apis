namespace Autodesk.Revit.DB;

public partial class ScheduleDefinition : System.Object
{
	public virtual System.Boolean CanIncludeLinkedFiles() => throw new System.NotImplementedException();
	public virtual void AddEmbeddedSchedule(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual void RemoveEmbeddedSchedule() => throw new System.NotImplementedException();
	public virtual System.Boolean CanHaveEmbeddedSchedule() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidCategoryForEmbeddedSchedule(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetValidCategoriesForEmbeddedSchedule() => throw new System.NotImplementedException();
	public virtual System.Int32 GetFieldCount() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField AddField(Autodesk.Revit.DB.ScheduleFieldType fieldType,Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField AddField(Autodesk.Revit.DB.ScheduleFieldType fieldType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField AddField(Autodesk.Revit.DB.SchedulableField schedulableField) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField InsertField(Autodesk.Revit.DB.ScheduleFieldType fieldType,Autodesk.Revit.DB.ElementId parameterId,System.Int32 index) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField InsertField(Autodesk.Revit.DB.ScheduleFieldType fieldType,System.Int32 index) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField InsertField(Autodesk.Revit.DB.SchedulableField schedulableField,System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidCombinedParameters(IList<Autodesk.Revit.DB.TableCellCombinedParameterData> data) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField InsertCombinedParameterField(IList<Autodesk.Revit.DB.TableCellCombinedParameterData> data,System.String fieldName,System.Int32 index) => throw new System.NotImplementedException();
	public virtual void RemoveField(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual void RemoveField(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void ClearFields() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField GetField(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleField GetField(System.Int32 index) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ScheduleFieldId> GetFieldOrder() => throw new System.NotImplementedException();
	public virtual void SetFieldOrder(IList<Autodesk.Revit.DB.ScheduleFieldId> fieldIds) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleFieldId GetFieldId(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Int32 GetFieldIndex(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidFieldIndex(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidFieldId(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual System.Int32 GetSortGroupFieldCount() => throw new System.NotImplementedException();
	public virtual void AddSortGroupField(Autodesk.Revit.DB.ScheduleSortGroupField sortGroupField) => throw new System.NotImplementedException();
	public virtual void InsertSortGroupField(Autodesk.Revit.DB.ScheduleSortGroupField sortGroupField,System.Int32 index) => throw new System.NotImplementedException();
	public virtual void RemoveSortGroupField(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void ClearSortGroupFields() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleSortGroupField GetSortGroupField(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void SetSortGroupField(System.Int32 index,Autodesk.Revit.DB.ScheduleSortGroupField sortGroupField) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ScheduleSortGroupField> GetSortGroupFields() => throw new System.NotImplementedException();
	public virtual void SetSortGroupFields(IList<Autodesk.Revit.DB.ScheduleSortGroupField> sortGroupFields) => throw new System.NotImplementedException();
	public virtual System.Boolean CanSortByField(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidCategoryForFilterBySheet() => throw new System.NotImplementedException();
	public virtual System.Int32 GetFilterCount() => throw new System.NotImplementedException();
	public virtual void AddFilter(Autodesk.Revit.DB.ScheduleFilter filter) => throw new System.NotImplementedException();
	public virtual void InsertFilter(Autodesk.Revit.DB.ScheduleFilter filter,System.Int32 index) => throw new System.NotImplementedException();
	public virtual void RemoveFilter(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void ClearFilters() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ScheduleFilter GetFilter(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void SetFilter(System.Int32 index,Autodesk.Revit.DB.ScheduleFilter filter) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ScheduleFilter> GetFilters() => throw new System.NotImplementedException();
	public virtual void SetFilters(IList<Autodesk.Revit.DB.ScheduleFilter> filters) => throw new System.NotImplementedException();
	public virtual System.Boolean CanFilter() => throw new System.NotImplementedException();
	public virtual System.Boolean CanFilterByParameterExistence(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanFilterByValue(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanFilterByValuePresence(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanFilterBySubstring(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanFilterByGlobalParameters(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.SchedulableField> GetSchedulableFields() => throw new System.NotImplementedException();
	public virtual System.Boolean IsSchedulableField(Autodesk.Revit.DB.SchedulableField schedulableField) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsFilteredBySheet
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowGridLines
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowHeaders
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowTitle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String GrandTotalTitle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowGrandTotalCount
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowGrandTotalTitle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowGrandTotal
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsEmbedded
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasEmbeddedSchedule
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ScheduleDefinition EmbeddedDefinition
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsItemized
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IncludeLinkedFiles
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsMaterialTakeoff
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsKeySchedule
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

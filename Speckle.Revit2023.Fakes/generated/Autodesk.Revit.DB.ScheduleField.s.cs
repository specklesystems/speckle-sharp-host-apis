namespace Autodesk.Revit.DB;

public partial class ScheduleField : System.IDisposable
{
	public ScheduleField() {}
	public virtual System.Boolean IsValidCombinedParameters(System.Collections.Generic.IList<Autodesk.Revit.DB.TableCellCombinedParameterData> data) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.TableCellCombinedParameterData> GetCombinedParameters() => throw new System.NotImplementedException();
	public virtual void SetCombinedParameters(System.Collections.Generic.IList<Autodesk.Revit.DB.TableCellCombinedParameterData> data) => throw new System.NotImplementedException();
	public virtual System.Boolean CreatesCircularReferences(Autodesk.Revit.DB.ScheduleFieldId fieldId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanTotal() => throw new System.NotImplementedException();
	public virtual System.Boolean CanTotalByAssemblyType() => throw new System.NotImplementedException();
	public virtual System.Boolean CanDisplayMinMax() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TableCellStyle GetStyle() => throw new System.NotImplementedException();
	public virtual void SetStyle(Autodesk.Revit.DB.TableCellStyle style) => throw new System.NotImplementedException();
	public virtual void ResetOverride() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormatOptions GetFormatOptions() => throw new System.NotImplementedException();
	public virtual void SetFormatOptions(Autodesk.Revit.DB.FormatOptions formatOptions) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ForgeTypeId GetSpecTypeId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SchedulableField GetSchedulableField() => throw new System.NotImplementedException();
	public virtual System.String GetName() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 FieldIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ScheduleFieldId FieldId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ScheduleDefinition Definition
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ViewSchedule Schedule
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasSchedulableField
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsCombinedParameterField
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsCalculatedField
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String MultipleValuesCustomText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String MultipleValuesText
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ScheduleFieldMultipleValuesDisplayType MultipleValuesDisplayType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double GridColumnWidth
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SheetColumnWidth
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsOverridden
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ScheduleHeadingOrientation HeadingOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ScheduleHorizontalAlignment HorizontalAlignment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ScheduleFieldDisplayType DisplayType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean TotalByAssemblyType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String ColumnHeading
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsHidden
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ScheduleFieldId PercentageBy
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ScheduleFieldId PercentageOf
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ParameterId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ScheduleFieldType FieldType
	{
		get => throw new System.NotImplementedException();
	}
}

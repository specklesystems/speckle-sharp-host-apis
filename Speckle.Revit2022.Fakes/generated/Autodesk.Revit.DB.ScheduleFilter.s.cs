namespace Autodesk.Revit.DB;

public partial class ScheduleFilter : System.IDisposable
{
	public ScheduleFilter() {}
	public ScheduleFilter(Autodesk.Revit.DB.ScheduleFieldId fieldId,Autodesk.Revit.DB.ScheduleFilterType filterType,Autodesk.Revit.DB.ElementId value) => throw new System.NotImplementedException();
	public ScheduleFilter(Autodesk.Revit.DB.ScheduleFieldId fieldId,Autodesk.Revit.DB.ScheduleFilterType filterType,System.String value) => throw new System.NotImplementedException();
	public ScheduleFilter(Autodesk.Revit.DB.ScheduleFieldId fieldId,Autodesk.Revit.DB.ScheduleFilterType filterType,System.Double value) => throw new System.NotImplementedException();
	public ScheduleFilter(Autodesk.Revit.DB.ScheduleFieldId fieldId,Autodesk.Revit.DB.ScheduleFilterType filterType,System.Int32 value) => throw new System.NotImplementedException();
	public ScheduleFilter(Autodesk.Revit.DB.ScheduleFieldId fieldId,Autodesk.Revit.DB.ScheduleFilterType filterType) => throw new System.NotImplementedException();
	public virtual System.Int32 GetIntegerValue() => throw new System.NotImplementedException();
	public virtual System.Double GetDoubleValue() => throw new System.NotImplementedException();
	public virtual System.String GetStringValue() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetElementIdValue() => throw new System.NotImplementedException();
	public virtual void SetNullValue() => throw new System.NotImplementedException();
	public virtual void SetValue(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual void SetValue(System.String @string) => throw new System.NotImplementedException();
	public virtual void SetValue(System.Double value) => throw new System.NotImplementedException();
	public virtual void SetValue(System.Int32 value) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsElementIdValue
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsDoubleValue
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsStringValue
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsIntegerValue
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsNullValue
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ScheduleFilterType FilterType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ScheduleFieldId FieldId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

namespace Autodesk.Revit.DB;

public enum ScheduleFilterType
{
	Invalid,
	HasParameter,
	Equal,
	NotEqual,
	GreaterThan,
	GreaterThanOrEqual,
	LessThan,
	LessThanOrEqual,
	Contains,
	NotContains,
	BeginsWith,
	NotBeginsWith,
	EndsWith,
	NotEndsWith,
	IsAssociatedWithGlobalParameter,
	IsNotAssociatedWithGlobalParameter,
	HasValue,
	HasNoValue,
}

namespace Autodesk.Revit.DB;

public partial class SchedulableField : System.Object
{
	public virtual System.String GetName(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId ParameterId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ScheduleFieldType FieldType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

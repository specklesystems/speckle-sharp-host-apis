namespace Autodesk.Revit.DB;

public partial class SchedulableField : System.IDisposable
{
  public SchedulableField() { }

  public SchedulableField(System.Guid customFieldId) => throw new System.NotImplementedException();

  public SchedulableField(Autodesk.Revit.DB.ScheduleFieldType fieldType, Autodesk.Revit.DB.ElementId parameterId) =>
    throw new System.NotImplementedException();

  public SchedulableField(Autodesk.Revit.DB.ScheduleFieldType fieldType) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CustomFieldData GetCustomFieldData() => throw new System.NotImplementedException();

  public virtual System.String GetName(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId ParameterId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ScheduleFieldType FieldType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

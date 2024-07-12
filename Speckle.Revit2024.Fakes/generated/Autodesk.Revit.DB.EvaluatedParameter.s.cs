namespace Autodesk.Revit.DB;

public partial class EvaluatedParameter : System.IDisposable
{
  public EvaluatedParameter() { }

  public virtual System.String AsValueString(Autodesk.Revit.DB.Document doc, Autodesk.Revit.DB.FormatOptions options) =>
    throw new System.NotImplementedException();

  public virtual System.String AsValueString(Autodesk.Revit.DB.Document doc) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.StorageType StorageType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasValue
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ParameterValue Value
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.InternalDefinition Definition
  {
    get => throw new System.NotImplementedException();
  }
}

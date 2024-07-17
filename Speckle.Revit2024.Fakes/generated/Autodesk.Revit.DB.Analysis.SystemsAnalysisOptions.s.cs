namespace Autodesk.Revit.DB.Analysis;

public partial class SystemsAnalysisOptions : System.IDisposable
{
  public SystemsAnalysisOptions() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String OutputFolder
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String WeatherFile
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String WorkflowFile
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

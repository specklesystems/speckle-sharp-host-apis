namespace Autodesk.Revit.DB;

public partial class EditScope : System.IDisposable
{
  public virtual void Cancel() => throw new System.NotImplementedException();

  public virtual void Commit(Autodesk.Revit.DB.IFailuresPreprocessor failurePreprocessor) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsPermitted
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsActive
  {
    get => throw new System.NotImplementedException();
  }
}

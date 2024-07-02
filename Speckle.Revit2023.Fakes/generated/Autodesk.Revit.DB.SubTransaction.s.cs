namespace Autodesk.Revit.DB;

public partial class SubTransaction : System.IDisposable
{
  public SubTransaction() { }

  public SubTransaction(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus Start() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus Commit() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus RollBack() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus GetStatus() => throw new System.NotImplementedException();

  public virtual System.Boolean HasStarted() => throw new System.NotImplementedException();

  public virtual System.Boolean HasEnded() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

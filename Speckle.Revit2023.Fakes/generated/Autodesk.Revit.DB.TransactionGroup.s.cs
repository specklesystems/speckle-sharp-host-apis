namespace Autodesk.Revit.DB;

public partial class TransactionGroup : System.IDisposable
{
  public TransactionGroup(Autodesk.Revit.DB.Document document, System.String transGroupName) =>
    throw new System.NotImplementedException();

  public TransactionGroup(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus Start(System.String transGroupName) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus Start() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus Commit() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus Assimilate() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus RollBack() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TransactionStatus GetStatus() => throw new System.NotImplementedException();

  public virtual System.Boolean HasStarted() => throw new System.NotImplementedException();

  public virtual System.Boolean HasEnded() => throw new System.NotImplementedException();

  public virtual void SetName(System.String name) => throw new System.NotImplementedException();

  public virtual System.String GetName() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsFailureHandlingForcedModal
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

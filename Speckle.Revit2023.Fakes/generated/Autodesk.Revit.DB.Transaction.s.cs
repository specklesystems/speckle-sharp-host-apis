namespace Autodesk.Revit.DB;

public partial class Transaction : System.Object
{
	public virtual Autodesk.Revit.DB.TransactionStatus Start() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus Commit(Autodesk.Revit.DB.FailureHandlingOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus Commit() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus RollBack(Autodesk.Revit.DB.FailureHandlingOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus RollBack() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus GetStatus() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureHandlingOptions GetFailureHandlingOptions() => throw new System.NotImplementedException();
	public virtual void SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions options) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
}

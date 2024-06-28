namespace Autodesk.Revit.DB;

public partial class FailuresAccessor : System.Object
{
	public virtual Autodesk.Revit.DB.Document GetDocument() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureSeverity GetSeverity() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureHandlingOptions GetFailureHandlingOptions() => throw new System.NotImplementedException();
	public virtual void SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions options) => throw new System.NotImplementedException();
	public virtual void ReplaceFailures(Autodesk.Revit.DB.FailureMessage failure) => throw new System.NotImplementedException();
	public virtual void PostFailure(Autodesk.Revit.DB.FailureMessage failure) => throw new System.NotImplementedException();
	public virtual void DeleteWarning(Autodesk.Revit.DB.FailureMessageAccessor failure) => throw new System.NotImplementedException();
	public virtual void DeleteAllWarnings() => throw new System.NotImplementedException();
	public virtual void ResolveFailure(Autodesk.Revit.DB.FailureMessageAccessor failure) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus CommitPendingTransaction() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus RollBackPendingTransaction() => throw new System.NotImplementedException();
	}

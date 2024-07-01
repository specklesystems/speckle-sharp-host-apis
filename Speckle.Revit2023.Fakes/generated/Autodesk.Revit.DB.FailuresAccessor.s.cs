namespace Autodesk.Revit.DB;

public partial class FailuresAccessor : System.IDisposable
{
	public virtual System.Boolean IsActive() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Document GetDocument() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureSeverity GetSeverity() => throw new System.NotImplementedException();
	public virtual System.String GetTransactionName() => throw new System.NotImplementedException();
	public virtual void SetTransactionName(System.String transactionName) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.FailureMessageAccessor> GetFailureMessages(Autodesk.Revit.DB.FailureSeverity severity) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.FailureMessageAccessor> GetFailureMessages() => throw new System.NotImplementedException();
	public virtual System.Boolean IsTransactionBeingCommitted() => throw new System.NotImplementedException();
	public virtual System.Boolean IsFailureResolutionPermitted(Autodesk.Revit.DB.FailureMessageAccessor failure,Autodesk.Revit.DB.FailureResolutionType resolutionType) => throw new System.NotImplementedException();
	public virtual System.Boolean IsFailureResolutionPermitted(Autodesk.Revit.DB.FailureMessageAccessor failure) => throw new System.NotImplementedException();
	public virtual System.Boolean IsFailureResolutionPermitted() => throw new System.NotImplementedException();
	public virtual System.Boolean IsElementsDeletionPermitted(IList<Autodesk.Revit.DB.ElementId> idsToDelete) => throw new System.NotImplementedException();
	public virtual System.Boolean IsElementsDeletionPermitted() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureHandlingOptions GetFailureHandlingOptions() => throw new System.NotImplementedException();
	public virtual void SetFailureHandlingOptions(Autodesk.Revit.DB.FailureHandlingOptions options) => throw new System.NotImplementedException();
	public virtual void ReplaceFailures(Autodesk.Revit.DB.FailureMessage failure) => throw new System.NotImplementedException();
	public virtual void PostFailure(Autodesk.Revit.DB.FailureMessage failure) => throw new System.NotImplementedException();
	public virtual void DeleteWarning(Autodesk.Revit.DB.FailureMessageAccessor failure) => throw new System.NotImplementedException();
	public virtual void DeleteAllWarnings() => throw new System.NotImplementedException();
	public virtual void ResolveFailure(Autodesk.Revit.DB.FailureMessageAccessor failure) => throw new System.NotImplementedException();
	public virtual void ResolveFailures(IList<Autodesk.Revit.DB.FailureMessageAccessor> failures) => throw new System.NotImplementedException();
	public virtual void DeleteElements(IList<Autodesk.Revit.DB.ElementId> idsToDelete) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.FailureResolutionType> GetAttemptedResolutionTypes(Autodesk.Revit.DB.FailureMessageAccessor failure) => throw new System.NotImplementedException();
	public virtual System.Boolean CanCommitPendingTransaction() => throw new System.NotImplementedException();
	public virtual System.Boolean CanRollBackPendingTransaction() => throw new System.NotImplementedException();
	public virtual System.Boolean IsPending() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus CommitPendingTransaction() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus RollBackPendingTransaction() => throw new System.NotImplementedException();
	public virtual void JournalFailures(IList<Autodesk.Revit.DB.FailureMessageAccessor> failures) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}

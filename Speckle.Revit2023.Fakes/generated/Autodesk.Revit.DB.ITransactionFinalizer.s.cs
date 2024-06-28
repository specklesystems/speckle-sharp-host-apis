namespace Autodesk.Revit.DB;

public partial class ITransactionFinalizer
{
	public virtual void OnCommitted(Autodesk.Revit.DB.Document document,System.String strTransactionName) => throw new System.NotImplementedException();
	public virtual void OnRolledBack(Autodesk.Revit.DB.Document document,System.String strTransactionName) => throw new System.NotImplementedException();
}

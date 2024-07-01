namespace Autodesk.Revit.DB;

public partial interface ITransactionFinalizer
{
	public  void OnCommitted(Autodesk.Revit.DB.Document document,System.String strTransactionName);
	public  void OnRolledBack(Autodesk.Revit.DB.Document document,System.String strTransactionName);
}

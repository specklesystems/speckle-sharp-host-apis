namespace Autodesk.Revit.DB;

public partial class TransactionGroup : System.Object
{
	public virtual Autodesk.Revit.DB.TransactionStatus Start() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus Commit() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus Assimilate() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus RollBack() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus GetStatus() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
}

namespace Autodesk.Revit.DB;

public partial class SubTransaction : System.Object
{
	public virtual Autodesk.Revit.DB.TransactionStatus Start() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus Commit() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus RollBack() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TransactionStatus GetStatus() => throw new System.NotImplementedException();
	}
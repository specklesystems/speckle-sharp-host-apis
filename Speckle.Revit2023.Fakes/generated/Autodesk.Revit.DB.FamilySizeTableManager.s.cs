namespace Autodesk.Revit.DB;

public partial class FamilySizeTableManager : System.Object
{
	public virtual IList<System.String> GetAllSizeTableNames() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilySizeTable GetSizeTable(System.String tableName) => throw new System.NotImplementedException();
	public virtual System.Boolean HasSizeTable(System.String tableName) => throw new System.NotImplementedException();
	public virtual System.Boolean ImportSizeTable(Autodesk.Revit.DB.Document document,System.String filePath,Autodesk.Revit.DB.FamilySizeTableErrorInfo errorInfo) => throw new System.NotImplementedException();
	public virtual System.Boolean ExportSizeTable(System.String tableName,System.String filePath) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveSizeTable(System.String tableName) => throw new System.NotImplementedException();
	public static System.Boolean CreateFamilySizeTableManager(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId familyId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.FamilySizeTableManager GetFamilySizeTableManager(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId familyId) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NumberOfSizeTables
	{
		get => throw new System.NotImplementedException();
	}
}

namespace Autodesk.Revit.DB;

public partial interface IExtension
{
	public  System.Boolean get_Extended(System.Int32 index);
	public  void set_Extended(System.Int32 index,System.Boolean extended);
	public  System.Boolean get_SymbolicExtended(System.Int32 index);
	public  void set_SymbolicExtended(System.Int32 index,System.Boolean symbolicExtended);
	public  System.Boolean get_HasMiter(System.Int32 index);
	public  System.Boolean get_IsMiterLocked(System.Int32 index);
	public  void set_IsMiterLocked(System.Int32 index,System.Boolean miterLocked);
}

namespace Autodesk.Revit.DB;

public partial interface IFamilyLoadOptions
{
	public  System.Boolean OnFamilyFound(System.Boolean familyInUse,out System.Boolean overwriteParameterValues);
	public  System.Boolean OnSharedFamilyFound(Autodesk.Revit.DB.Family sharedFamily,System.Boolean familyInUse,out Autodesk.Revit.DB.FamilySource source,out System.Boolean overwriteParameterValues);
}

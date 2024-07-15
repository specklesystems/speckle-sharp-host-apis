namespace Autodesk.Revit.DB;

public partial class FamilyInstanceFilter : Autodesk.Revit.DB.ElementSlowFilter
{
	public FamilyInstanceFilter() {}
	public FamilyInstanceFilter(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId familySymbolId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId FamilySymbolId
	{
		get => throw new System.NotImplementedException();
	}
}

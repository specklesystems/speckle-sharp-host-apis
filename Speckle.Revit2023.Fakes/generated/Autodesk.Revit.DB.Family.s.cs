namespace Autodesk.Revit.DB;

public partial class Family : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.FamilyPlacementType FamilyPlacementType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId FamilyCategoryId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Category FamilyCategory
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.TilePatternsBuiltIn CurtainPanelTilePattern
	{
		get => throw new System.NotImplementedException();
	}
}

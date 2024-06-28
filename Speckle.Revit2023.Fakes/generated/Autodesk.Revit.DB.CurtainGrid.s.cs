namespace Autodesk.Revit.DB;

public partial class CurtainGrid : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.Element ChangePanelType(Autodesk.Revit.DB.Element panel,Autodesk.Revit.DB.ElementType newSymbol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Panel GetPanel(Autodesk.Revit.DB.ElementId uGridLineId,Autodesk.Revit.DB.ElementId vGridLineId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurtainCell GetCell(Autodesk.Revit.DB.ElementId uGridLineId,Autodesk.Revit.DB.ElementId vGridLineId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurtainGridAlignType Grid2Justification
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.CurtainGridAlignType Grid1Justification
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

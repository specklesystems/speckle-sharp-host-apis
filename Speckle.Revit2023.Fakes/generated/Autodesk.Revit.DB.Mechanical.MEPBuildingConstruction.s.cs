namespace Autodesk.Revit.DB.Mechanical;

public partial class MEPBuildingConstruction : Autodesk.Revit.DB.ElementType
{
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.Construction> GetConstructions(Autodesk.Revit.DB.Analysis.ConstructionType constructionType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Construction GetBuildingConstruction(Autodesk.Revit.DB.Analysis.ConstructionType constructionType) => throw new System.NotImplementedException();
	public virtual void SetBuildingConstruction(Autodesk.Revit.DB.Analysis.ConstructionType constructionType,Autodesk.Revit.DB.Construction buildingConstruction) => throw new System.NotImplementedException();
	public virtual void SetBuildingConstructionOverride(Autodesk.Revit.DB.Analysis.ConstructionType constructionType,System.Boolean @override) => throw new System.NotImplementedException();
	public virtual System.Boolean GetBuildingConstructionOverride(Autodesk.Revit.DB.Analysis.ConstructionType constructionType) => throw new System.NotImplementedException();
}

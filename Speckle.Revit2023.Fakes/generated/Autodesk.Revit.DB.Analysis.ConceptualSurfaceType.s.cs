namespace Autodesk.Revit.DB.Analysis;

public partial class ConceptualSurfaceType : Autodesk.Revit.DB.Element
{
	public ConceptualSurfaceType() {}
	public static Autodesk.Revit.DB.Analysis.ConceptualSurfaceType GetByMassSubCategoryId(Autodesk.Revit.DB.Document cda,Autodesk.Revit.DB.ElementId massSubCategoryId) => throw new System.NotImplementedException();
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetAllMassSubCategoryIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetConstructionTypeIds() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId DefaultConstructionTypeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId MassSubCategoryId
	{
		get => throw new System.NotImplementedException();
	}
}

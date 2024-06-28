namespace Autodesk.Revit.DB;

public partial class Family : Autodesk.Revit.DB.Element
{
	public virtual void ExtractPartAtom(System.String xmlFilePath) => throw new System.NotImplementedException();
	public virtual System.Boolean CanHaveStructuralSection() => throw new System.NotImplementedException();
	public virtual System.Boolean IsAppropriateCategoryId(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetFamilySymbolIds() => throw new System.NotImplementedException();
	public virtual ISet<Autodesk.Revit.DB.ElementId> GetFamilyTypeParameterValues(Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public virtual System.Boolean HasLargeSketches() => throw new System.NotImplementedException();
	public static System.Boolean CanLoadFamilies(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual System.Boolean IsParametric
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsUserCreated
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FamilyPlacementType FamilyPlacementType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsOwnerFamily
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId FamilyCategoryId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String StructuralCodeName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String StructuralFamilyNameKey
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsEditable
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsInPlace
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Category FamilyCategory
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowSpatialElementCalculationPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double CurtainPanelVerticalSpacing
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double CurtainPanelHorizontalSpacing
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.TilePatternsBuiltIn CurtainPanelTilePattern
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsCurtainPanelFamily
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsConceptualMassFamily
	{
		get => throw new System.NotImplementedException();
	}
}

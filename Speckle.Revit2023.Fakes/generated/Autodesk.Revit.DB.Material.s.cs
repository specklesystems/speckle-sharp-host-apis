namespace Autodesk.Revit.DB;

public partial class Material : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.ElementId Create(Autodesk.Revit.DB.Document document,System.String name) => throw new System.NotImplementedException();
	public static System.Boolean IsMaterialOrValidDefault(Autodesk.Revit.DB.Element pElem,Autodesk.Revit.DB.ElementId materialId) => throw new System.NotImplementedException();
	public static System.Boolean IsNameUnique(Autodesk.Revit.DB.Document aDocument,System.String name) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Material Duplicate(System.String name) => throw new System.NotImplementedException();
	public virtual void SetMaterialAspectByPropertySet(Autodesk.Revit.DB.MaterialAspect aspect,Autodesk.Revit.DB.ElementId propertySetId) => throw new System.NotImplementedException();
	public virtual void ClearMaterialAspect(Autodesk.Revit.DB.MaterialAspect aspect) => throw new System.NotImplementedException();
	public virtual System.String MaterialCategory
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String MaterialClass
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ThermalAssetId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId StructuralAssetId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId AppearanceAssetId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId SurfaceBackgroundPatternId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId CutBackgroundPatternId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId SurfaceForegroundPatternId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId CutForegroundPatternId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Color CutBackgroundPatternColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Color SurfaceBackgroundPatternColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Color CutForegroundPatternColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Color SurfaceForegroundPatternColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Color Color
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Transparency
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Smoothness
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Shininess
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean UseRenderAppearanceForShading
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

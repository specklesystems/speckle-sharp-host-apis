namespace Autodesk.Revit.UI;

public partial class UIDocument : System.Object
{
	public static Autodesk.Revit.DB.IFamilyLoadOptions GetRevitUIFamilyLoadOptions() => throw new System.NotImplementedException();
	public virtual System.Boolean SaveAndClose() => throw new System.NotImplementedException();
	public virtual void ShowElements(ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public virtual void ShowElements(Autodesk.Revit.DB.ElementSet elements) => throw new System.NotImplementedException();
	public virtual void ShowElements(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual void ShowElements(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void RefreshActiveView() => throw new System.NotImplementedException();
	public virtual void RequestViewChange(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol familySymbol,Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions options) => throw new System.NotImplementedException();
	public virtual void PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol familySymbol) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.UI.UIView> GetOpenUIViews() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.UI.SketchGalleryOptions> GetSketchGalleryOptions(Autodesk.Revit.DB.FamilySymbol familySymbol) => throw new System.NotImplementedException();
	public virtual void PromptToPlaceViewOnSheet(Autodesk.Revit.DB.View view,System.Boolean allowReplaceExistingSheetViewport) => throw new System.NotImplementedException();
	public virtual void PostRequestForElementTypePlacement(Autodesk.Revit.DB.ElementType elementType) => throw new System.NotImplementedException();
	public virtual void PromptToPlaceElementTypeOnLegendView(Autodesk.Revit.DB.ElementType elementType) => throw new System.NotImplementedException();
	public virtual void PromptToMatchElementType(Autodesk.Revit.DB.ElementType elementType) => throw new System.NotImplementedException();
	public virtual System.Boolean CanPlaceElementType(Autodesk.Revit.DB.ElementType elementType) => throw new System.NotImplementedException();
	public virtual void SaveAs(Autodesk.Revit.UI.UISaveAsOptions options) => throw new System.NotImplementedException();
	public virtual void SaveAs() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.UI.FaceBasedPlacementType> GetPlacementTypes(Autodesk.Revit.DB.FamilySymbol familySymbol,Autodesk.Revit.DB.View pDBView) => throw new System.NotImplementedException();
	public virtual void UpdateAllOpenViews() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.View ActiveGraphicalView
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.UI.UIApplication Application
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Document Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.View ActiveView
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

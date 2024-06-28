namespace Autodesk.Revit.UI;

public partial class UIDocument : System.Object
{
	public virtual void ShowElements(Autodesk.Revit.DB.ElementSet elements) => throw new System.NotImplementedException();
	public virtual void ShowElements(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual void ShowElements(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void RefreshActiveView() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.View get_ActiveView() => throw new System.NotImplementedException();
	public virtual void set_ActiveView(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Document get_Document() => throw new System.NotImplementedException();
	public virtual void RequestViewChange(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol familySymbol,Autodesk.Revit.UI.PromptForFamilyInstancePlacementOptions options) => throw new System.NotImplementedException();
	public virtual void PromptForFamilyInstancePlacement(Autodesk.Revit.DB.FamilySymbol familySymbol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.UIApplication get_Application() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.View get_ActiveGraphicalView() => throw new System.NotImplementedException();
	public virtual void PostRequestForElementTypePlacement(Autodesk.Revit.DB.ElementType elementType) => throw new System.NotImplementedException();
	public virtual void PromptToPlaceElementTypeOnLegendView(Autodesk.Revit.DB.ElementType elementType) => throw new System.NotImplementedException();
	public virtual void PromptToMatchElementType(Autodesk.Revit.DB.ElementType elementType) => throw new System.NotImplementedException();
	public virtual void SaveAs(Autodesk.Revit.UI.UISaveAsOptions options) => throw new System.NotImplementedException();
	public virtual void SaveAs() => throw new System.NotImplementedException();
	public virtual void UpdateAllOpenViews() => throw new System.NotImplementedException();
	}

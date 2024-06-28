namespace Autodesk.Revit.DB;

public partial class TemporaryViewModes : Autodesk.Revit.DB.APIObject
{
	public virtual void DeactivateMode(Autodesk.Revit.DB.TemporaryViewMode mode) => throw new System.NotImplementedException();
	public virtual void DeactivateAllModes() => throw new System.NotImplementedException();
	public virtual void RemoveCustomization() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Color CustomColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.WorksharingDisplayMode WorksharingDisplay
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.PreviewFamilyVisibilityMode PreviewFamilyVisibility
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

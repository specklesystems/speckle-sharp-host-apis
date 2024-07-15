namespace Autodesk.Revit.DB;

public partial class View3D : Autodesk.Revit.DB.View
{
	public View3D() {}
	public virtual Autodesk.Revit.DB.RenderingSettings GetRenderingSettings() => throw new System.NotImplementedException();
	public virtual void SetRenderingSettings(Autodesk.Revit.DB.RenderingSettings settings) => throw new System.NotImplementedException();
	public virtual System.Boolean CanResetCameraTarget() => throw new System.NotImplementedException();
	public virtual void ResetCameraTarget() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.View3D CreateIsometric(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewFamilyTypeId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.View3D CreatePerspective(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewFamilyTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewOrientation3D GetOrientation() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewOrientation3D GetSavedOrientation() => throw new System.NotImplementedException();
	public virtual void SetOrientation(Autodesk.Revit.DB.ViewOrientation3D newViewOrientation3D) => throw new System.NotImplementedException();
	public virtual void OrientTo(Autodesk.Revit.DB.XYZ forwardDirection) => throw new System.NotImplementedException();
	public virtual void SaveOrientation() => throw new System.NotImplementedException();
	public virtual System.Boolean CanSaveOrientation() => throw new System.NotImplementedException();
	public virtual void SaveOrientationAndLock() => throw new System.NotImplementedException();
	public virtual void RestoreOrientationAndLock() => throw new System.NotImplementedException();
	public virtual System.Boolean HasBeenLocked() => throw new System.NotImplementedException();
	public virtual void Unlock() => throw new System.NotImplementedException();
	public virtual void SetSectionBox(Autodesk.Revit.DB.BoundingBoxXYZ boundingBoxXYZ) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxXYZ GetSectionBox() => throw new System.NotImplementedException();
	public virtual System.Boolean CanToggleBetweenPerspectiveAndIsometric() => throw new System.NotImplementedException();
	public virtual void ToggleToPerspective() => throw new System.NotImplementedException();
	public virtual void ToggleToIsometric() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetLevelsThatShowGrids() => throw new System.NotImplementedException();
	public virtual void ShowGridsOnLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual void HideGridsOnLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual void ShowGridsOnLevels(System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> levelsIds) => throw new System.NotImplementedException();
	public virtual System.Boolean ProjectGridsOnSectionBox
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsSectionBoxActive
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsPerspective
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsLocked
	{
		get => throw new System.NotImplementedException();
	}
}

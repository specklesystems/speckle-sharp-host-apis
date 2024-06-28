namespace Autodesk.Revit.DB;

public partial class View3D : Autodesk.Revit.DB.View
{
	public virtual Autodesk.Revit.DB.RenderingSettings GetRenderingSettings() => throw new System.NotImplementedException();
	public virtual void SetRenderingSettings(Autodesk.Revit.DB.RenderingSettings settings) => throw new System.NotImplementedException();
	public virtual void ResetCameraTarget() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewOrientation3D GetOrientation() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewOrientation3D GetSavedOrientation() => throw new System.NotImplementedException();
	public virtual void SetOrientation(Autodesk.Revit.DB.ViewOrientation3D newViewOrientation3D) => throw new System.NotImplementedException();
	public virtual void OrientTo(Autodesk.Revit.DB.XYZ forwardDirection) => throw new System.NotImplementedException();
	public virtual void SaveOrientation() => throw new System.NotImplementedException();
	public virtual void SaveOrientationAndLock() => throw new System.NotImplementedException();
	public virtual void RestoreOrientationAndLock() => throw new System.NotImplementedException();
	public virtual void Unlock() => throw new System.NotImplementedException();
	public virtual void SetSectionBox(Autodesk.Revit.DB.BoundingBoxXYZ boundingBoxXYZ) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxXYZ GetSectionBox() => throw new System.NotImplementedException();
	public virtual void ToggleToPerspective() => throw new System.NotImplementedException();
	public virtual void ToggleToIsometric() => throw new System.NotImplementedException();
	public virtual void ShowGridsOnLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
	public virtual void HideGridsOnLevel(Autodesk.Revit.DB.ElementId levelId) => throw new System.NotImplementedException();
}

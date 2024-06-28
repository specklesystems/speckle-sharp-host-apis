namespace Autodesk.Revit.DB;

public partial class View : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.OverrideGraphicSettings GetFilterOverrides(Autodesk.Revit.DB.ElementId filterElementId) => throw new System.NotImplementedException();
	public virtual void SetFilterOverrides(Autodesk.Revit.DB.ElementId filterElementId,Autodesk.Revit.DB.OverrideGraphicSettings overrideGraphicSettings) => throw new System.NotImplementedException();
	public virtual void AddFilter(Autodesk.Revit.DB.ElementId filterElementId) => throw new System.NotImplementedException();
	public virtual void RemoveFilter(Autodesk.Revit.DB.ElementId filterElementId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.OverrideGraphicSettings GetElementOverrides(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void SetElementOverrides(Autodesk.Revit.DB.ElementId elementId,Autodesk.Revit.DB.OverrideGraphicSettings overrideGraphicSettings) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewDisplayBackground GetBackground() => throw new System.NotImplementedException();
	public virtual void SetBackground(Autodesk.Revit.DB.ViewDisplayBackground background) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewDisplaySketchyLines GetSketchyLines() => throw new System.NotImplementedException();
	public virtual void SetSketchyLines(Autodesk.Revit.DB.ViewDisplaySketchyLines sketchyLines) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewDisplayDepthCueing GetDepthCueing() => throw new System.NotImplementedException();
	public virtual void SetDepthCueing(Autodesk.Revit.DB.ViewDisplayDepthCueing depthCueing) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewDisplayModel GetViewDisplayModel() => throw new System.NotImplementedException();
	public virtual void SetViewDisplayModel(Autodesk.Revit.DB.ViewDisplayModel viewDisplayModel) => throw new System.NotImplementedException();
	public virtual void SetColorFillSchemeId(Autodesk.Revit.DB.ElementId categoryId,Autodesk.Revit.DB.ElementId schemeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetColorFillSchemeId(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual void ApplyViewTemplateParameters(Autodesk.Revit.DB.View otherView) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.View CreateViewTemplate() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxUV get_Outline() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewType get_ViewType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxXYZ get_CropBox() => throw new System.NotImplementedException();
	public virtual void set_CropBox(Autodesk.Revit.DB.BoundingBoxXYZ cropBox) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_Origin() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_ViewDirection() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_RightDirection() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_UpDirection() => throw new System.NotImplementedException();
	public virtual void Print(Autodesk.Revit.DB.View viewTemplate) => throw new System.NotImplementedException();
	public virtual void Print() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Level get_GenLevel() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SketchPlane get_SketchPlane() => throw new System.NotImplementedException();
	public virtual void set_SketchPlane(Autodesk.Revit.DB.SketchPlane sketchPlane) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SunAndShadowSettings get_SunAndShadowSettings() => throw new System.NotImplementedException();
	public virtual void ShowActiveWorkPlane() => throw new System.NotImplementedException();
	public virtual void HideActiveWorkPlane() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_AssociatedAssemblyInstanceId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PartsVisibility get_PartsVisibility() => throw new System.NotImplementedException();
	public virtual void set_PartsVisibility(Autodesk.Revit.DB.PartsVisibility partsVisibility) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewDetailLevel get_DetailLevel() => throw new System.NotImplementedException();
	public virtual void set_DetailLevel(Autodesk.Revit.DB.ViewDetailLevel detailLevel) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_AnalysisDisplayStyleId() => throw new System.NotImplementedException();
	public virtual void set_AnalysisDisplayStyleId(Autodesk.Revit.DB.ElementId value) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TemporaryViewModes get_TemporaryViewModes() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DisplayStyle get_DisplayStyle() => throw new System.NotImplementedException();
	public virtual void set_DisplayStyle(Autodesk.Revit.DB.DisplayStyle displayStyle) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewDiscipline get_Discipline() => throw new System.NotImplementedException();
	public virtual void set_Discipline(Autodesk.Revit.DB.ViewDiscipline viewDiscipline) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_ViewTemplateId() => throw new System.NotImplementedException();
	public virtual void set_ViewTemplateId(Autodesk.Revit.DB.ElementId val) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewCropRegionShapeManager GetCropRegionShapeManager() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCalloutParentId() => throw new System.NotImplementedException();
	public virtual void RemoveCalloutParent() => throw new System.NotImplementedException();
	public virtual void RestoreCalloutParent() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId Duplicate(Autodesk.Revit.DB.ViewDuplicateOption duplicateOption) => throw new System.NotImplementedException();
	public virtual void ConvertToIndependent() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksetVisibility GetWorksetVisibility(Autodesk.Revit.DB.WorksetId worksetId) => throw new System.NotImplementedException();
	public virtual void SetWorksetVisibility(Autodesk.Revit.DB.WorksetId worksetId,Autodesk.Revit.DB.WorksetVisibility visible) => throw new System.NotImplementedException();
	public virtual void DisableTemporaryViewMode(Autodesk.Revit.DB.TemporaryViewMode mode) => throw new System.NotImplementedException();
	public virtual void EnableRevealHiddenMode() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetTemporaryViewPropertiesId() => throw new System.NotImplementedException();
	public virtual void HideElementTemporary(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void HideCategoryTemporary(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void IsolateElementTemporary(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void IsolateCategoryTemporary(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void ConvertTemporaryHideIsolateToPermanent() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewPlacementOnSheetStatus GetPlacementOnSheetStatus() => throw new System.NotImplementedException();
	public virtual void SetWorksharingDisplayMode(Autodesk.Revit.DB.WorksharingDisplayMode displayMode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksharingDisplayMode GetWorksharingDisplayMode() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetPrimaryViewId() => throw new System.NotImplementedException();
	public virtual void SetCategoryOverrides(Autodesk.Revit.DB.ElementId categoryId,Autodesk.Revit.DB.OverrideGraphicSettings overrideGraphicSettings) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.OverrideGraphicSettings GetCategoryOverrides(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
}

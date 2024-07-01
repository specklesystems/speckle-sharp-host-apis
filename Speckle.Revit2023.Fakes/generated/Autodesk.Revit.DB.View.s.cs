namespace Autodesk.Revit.DB;

public partial class View : Autodesk.Revit.DB.Element
{
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetFilters() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetOrderedFilters() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.OverrideGraphicSettings GetFilterOverrides(Autodesk.Revit.DB.ElementId filterElementId) => throw new System.NotImplementedException();
	public virtual void SetFilterOverrides(Autodesk.Revit.DB.ElementId filterElementId,Autodesk.Revit.DB.OverrideGraphicSettings overrideGraphicSettings) => throw new System.NotImplementedException();
	public virtual void AddFilter(Autodesk.Revit.DB.ElementId filterElementId) => throw new System.NotImplementedException();
	public virtual void RemoveFilter(Autodesk.Revit.DB.ElementId filterElementId) => throw new System.NotImplementedException();
	public virtual System.Boolean GetFilterVisibility(Autodesk.Revit.DB.ElementId filterElementId) => throw new System.NotImplementedException();
	public virtual void SetFilterVisibility(Autodesk.Revit.DB.ElementId filterElementId,System.Boolean visibility) => throw new System.NotImplementedException();
	public virtual System.Boolean GetIsFilterEnabled(Autodesk.Revit.DB.ElementId filterElementId) => throw new System.NotImplementedException();
	public virtual void SetIsFilterEnabled(Autodesk.Revit.DB.ElementId filterElementId,System.Boolean enable) => throw new System.NotImplementedException();
	public virtual System.Boolean IsFilterApplied(Autodesk.Revit.DB.ElementId filterElementId) => throw new System.NotImplementedException();
	public virtual System.Boolean AreGraphicsOverridesAllowed() => throw new System.NotImplementedException();
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
	public virtual Autodesk.Revit.DB.PointClouds.PointCloudOverrides GetPointCloudOverrides() => throw new System.NotImplementedException();
	public virtual void SetColorFillSchemeId(Autodesk.Revit.DB.ElementId categoryId,Autodesk.Revit.DB.ElementId schemeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetColorFillSchemeId(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> SupportedColorFillCategoryIds() => throw new System.NotImplementedException();
	public virtual System.Boolean CanApplyColorFillScheme(Autodesk.Revit.DB.ElementId categoryId,Autodesk.Revit.DB.ElementId schemeId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetTemplateParameterIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetNonControlledTemplateParameterIds() => throw new System.NotImplementedException();
	public virtual void SetNonControlledTemplateParameterIds(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> newSet) => throw new System.NotImplementedException();
	public virtual void ApplyViewTemplateParameters(Autodesk.Revit.DB.View otherView) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidViewTemplate(Autodesk.Revit.DB.ElementId templateId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsViewValidForTemplateCreation() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.View CreateViewTemplate() => throw new System.NotImplementedException();
	public virtual void Print(Autodesk.Revit.DB.View viewTemplate) => throw new System.NotImplementedException();
	public virtual void Print() => throw new System.NotImplementedException();
	public virtual void Print(Autodesk.Revit.DB.View viewTemplate,System.Boolean useCurrentPrintSettings) => throw new System.NotImplementedException();
	public virtual void Print(System.Boolean useCurrentPrintSettings) => throw new System.NotImplementedException();
	public virtual void HideElements(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIdSet) => throw new System.NotImplementedException();
	public virtual void UnhideElements(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIdSet) => throw new System.NotImplementedException();
	public virtual void ShowActiveWorkPlane() => throw new System.NotImplementedException();
	public virtual void HideActiveWorkPlane() => throw new System.NotImplementedException();
	public virtual System.Boolean HasViewTransforms() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.TransformWithBoundary> GetModelToProjectionTransforms() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewCropRegionShapeManager GetCropRegionShapeManager() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ViewCropRegionShapeManager GetCropRegionShapeManagerForReferenceCallout(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.ElementId callout) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetReferenceCallouts() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetReferenceSections() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetReferenceElevations() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCalloutParentId() => throw new System.NotImplementedException();
	public virtual void RemoveCalloutParent() => throw new System.NotImplementedException();
	public virtual void RestoreCalloutParent() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId Duplicate(Autodesk.Revit.DB.ViewDuplicateOption duplicateOption) => throw new System.NotImplementedException();
	public virtual void ConvertToIndependent() => throw new System.NotImplementedException();
	public virtual System.Boolean CanViewBeDuplicated(Autodesk.Revit.DB.ViewDuplicateOption duplicateOption) => throw new System.NotImplementedException();
	public virtual System.Boolean IsElementVisibleInTemporaryViewMode(Autodesk.Revit.DB.TemporaryViewMode mode,Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksetVisibility GetWorksetVisibility(Autodesk.Revit.DB.WorksetId worksetId) => throw new System.NotImplementedException();
	public virtual void SetWorksetVisibility(Autodesk.Revit.DB.WorksetId worksetId,Autodesk.Revit.DB.WorksetVisibility visible) => throw new System.NotImplementedException();
	public virtual System.Boolean IsWorksetVisible(Autodesk.Revit.DB.WorksetId worksetId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsInTemporaryViewMode(Autodesk.Revit.DB.TemporaryViewMode mode) => throw new System.NotImplementedException();
	public virtual void DisableTemporaryViewMode(Autodesk.Revit.DB.TemporaryViewMode mode) => throw new System.NotImplementedException();
	public virtual void EnableRevealHiddenMode() => throw new System.NotImplementedException();
	public virtual System.Boolean CanEnableTemporaryViewPropertiesMode() => throw new System.NotImplementedException();
	public virtual System.Boolean EnableTemporaryViewPropertiesMode(Autodesk.Revit.DB.ElementId viewTemplateId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetTemporaryViewPropertiesId() => throw new System.NotImplementedException();
	public virtual System.Boolean IsTemporaryViewPropertiesModeEnabled() => throw new System.NotImplementedException();
	public virtual System.String GetTemporaryViewPropertiesName() => throw new System.NotImplementedException();
	public virtual void HideElementTemporary(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void HideElementsTemporary(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIdSet) => throw new System.NotImplementedException();
	public virtual System.Boolean CanCategoryBeHiddenTemporary(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void HideCategoryTemporary(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void HideCategoriesTemporary(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public virtual void IsolateElementsTemporary(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public virtual void IsolateElementTemporary(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void IsolateCategoryTemporary(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void IsolateCategoriesTemporary(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public virtual System.Boolean CanCategoryBeHidden(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual void SetCategoryHidden(Autodesk.Revit.DB.ElementId categoryId,System.Boolean hide) => throw new System.NotImplementedException();
	public virtual System.Boolean GetCategoryHidden(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual void ConvertTemporaryHideIsolateToPermanent() => throw new System.NotImplementedException();
	public virtual System.Boolean IsTemporaryHideIsolateActive() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewPlacementOnSheetStatus GetPlacementOnSheetStatus() => throw new System.NotImplementedException();
	public virtual void SetWorksharingDisplayMode(Autodesk.Revit.DB.WorksharingDisplayMode displayMode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksharingDisplayMode GetWorksharingDisplayMode() => throw new System.NotImplementedException();
	public virtual System.Boolean SupportsWorksharingDisplayMode(Autodesk.Revit.DB.WorksharingDisplayMode mode) => throw new System.NotImplementedException();
	public virtual System.Boolean CanModifyDetailLevel() => throw new System.NotImplementedException();
	public virtual System.Boolean HasDetailLevel() => throw new System.NotImplementedException();
	public virtual System.Boolean AllowsAnalysisDisplay() => throw new System.NotImplementedException();
	public static System.Boolean IsValidViewScale(System.Int32 viewScale) => throw new System.NotImplementedException();
	public virtual System.Boolean SupportsRevealConstraints() => throw new System.NotImplementedException();
	public virtual System.Boolean CanModifyDisplayStyle() => throw new System.NotImplementedException();
	public virtual System.Boolean HasDisplayStyle() => throw new System.NotImplementedException();
	public virtual System.Boolean CanUseDepthCueing() => throw new System.NotImplementedException();
	public virtual System.Boolean CanUseTemporaryVisibilityModes() => throw new System.NotImplementedException();
	public virtual System.Boolean HasViewDiscipline() => throw new System.NotImplementedException();
	public virtual System.Boolean CanModifyViewDiscipline() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetPrimaryViewId() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetDependentViewIds() => throw new System.NotImplementedException();
	public virtual void SetCategoryOverrides(Autodesk.Revit.DB.ElementId categoryId,Autodesk.Revit.DB.OverrideGraphicSettings overrideGraphicSettings) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.OverrideGraphicSettings GetCategoryOverrides(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCategoryOverridable(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId ViewTemplateId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 SunlightIntensity
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 ShadowIntensity
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ViewDiscipline Discipline
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DisplayStyle DisplayStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean RevealConstraintsMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.TemporaryViewModes TemporaryViewModes
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId AnalysisDisplayStyleId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AreCoordinationModelHandlesHidden
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ArePointCloudsHidden
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AreImportCategoriesHidden
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AreAnalyticalModelCategoriesHidden
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AreAnnotationCategoriesHidden
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AreModelCategoriesHidden
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ViewDetailLevel DetailLevel
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.PartsVisibility PartsVisibility
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Title
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsAssemblyView
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId AssociatedAssemblyInstanceId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsCallout
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.SunAndShadowSettings SunAndShadowSettings
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.SketchPlane SketchPlane
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean CropBoxVisible
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean CropBoxActive
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Level GenLevel
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsTemplate
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CanBePrinted
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ UpDirection
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ RightDirection
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ ViewDirection
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 Scale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ Origin
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.BoundingBoxXYZ CropBox
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ViewType ViewType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.BoundingBoxUV Outline
	{
		get => throw new System.NotImplementedException();
	}
}

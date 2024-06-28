namespace Autodesk.Revit.DB;

public partial class Document : System.Object
{
	public virtual void Save() => throw new System.NotImplementedException();
	public virtual void SaveAs(Autodesk.Revit.DB.ModelPath path,Autodesk.Revit.DB.SaveAsOptions options) => throw new System.NotImplementedException();
	public virtual void SaveCloudModel() => throw new System.NotImplementedException();
	public virtual void EnableCloudWorksharing() => throw new System.NotImplementedException();
	public virtual void ExportImage(Autodesk.Revit.DB.ImageExportOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId SaveToProjectAsImage(Autodesk.Revit.DB.ImageExportOptions options) => throw new System.NotImplementedException();
	public virtual void UnpostFailure(Autodesk.Revit.DB.FailureMessageKey messageKey) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FailureMessageKey PostFailure(Autodesk.Revit.DB.FailureMessage failure) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelPath GetWorksharingCentralModelPath() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelPath GetCloudModelPath() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetDefaultElementTypeId(Autodesk.Revit.DB.ElementTypeGroup defaultTypeId) => throw new System.NotImplementedException();
	public virtual void SetDefaultElementTypeId(Autodesk.Revit.DB.ElementTypeGroup defaultTypeId,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetDefaultFamilyTypeId(Autodesk.Revit.DB.ElementId familyCategoryId) => throw new System.NotImplementedException();
	public virtual void SetDefaultFamilyTypeId(Autodesk.Revit.DB.ElementId familyCategoryId,Autodesk.Revit.DB.ElementId familyTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DocumentPreviewSettings GetDocumentPreviewSettings() => throw new System.NotImplementedException();
	public virtual void MakeTransientElements(Autodesk.Revit.DB.ITransientElementMaker maker) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element GetElement(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element GetElement(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Subelement GetSubelement(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual void ReloadLatest(Autodesk.Revit.DB.ReloadLatestOptions reloadOptions) => throw new System.NotImplementedException();
	public virtual void SynchronizeWithCentral(Autodesk.Revit.DB.TransactWithCentralOptions transactOptions,Autodesk.Revit.DB.SynchronizeWithCentralOptions syncOptions) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetPaintedMaterial(Autodesk.Revit.DB.ElementId elementId,Autodesk.Revit.DB.Face face) => throw new System.NotImplementedException();
	public virtual void RemovePaint(Autodesk.Revit.DB.ElementId elementId,Autodesk.Revit.DB.Face face) => throw new System.NotImplementedException();
	public virtual void AcquireCoordinates(Autodesk.Revit.DB.ElementId linkInstanceId) => throw new System.NotImplementedException();
	public virtual void PublishCoordinates(Autodesk.Revit.DB.LinkElementId locationId) => throw new System.NotImplementedException();
	public virtual void ResetSharedCoordinates() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.StorageType GetTypeOfStorage(Autodesk.Revit.DB.ForgeTypeId parameterTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Family LoadFamily(Autodesk.Revit.DB.Document targetDocument,Autodesk.Revit.DB.IFamilyLoadOptions familyLoadOptions) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Family LoadFamily(Autodesk.Revit.DB.Document targetDocument) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Document EditFamily(Autodesk.Revit.DB.Family loadedFamily) => throw new System.NotImplementedException();
	public virtual void Print(Autodesk.Revit.DB.ViewSet views,Autodesk.Revit.DB.View viewTemplate) => throw new System.NotImplementedException();
	public virtual void Print(Autodesk.Revit.DB.ViewSet views) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.Room GetRoomAtPoint(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.Room GetRoomAtPoint(Autodesk.Revit.DB.XYZ point,Autodesk.Revit.DB.Phase phase) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeomCombination CombineElements(Autodesk.Revit.DB.CombinableElementArray members) => throw new System.NotImplementedException();
	public virtual void SeparateElements(Autodesk.Revit.DB.CombinableElementArray members) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DetailCurveArray ConvertModelToDetailCurves(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.ModelCurveArray modelCurves) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelCurveArray ConvertDetailToModelCurves(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.DetailCurveArray detailCurves) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SymbolicCurveArray ConvertModelToSymbolicCurves(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.ModelCurveArray modelCurves) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelCurveArray ConvertSymbolicToModelCurves(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.SymbolicCurveArray symbolicCurve) => throw new System.NotImplementedException();
	public virtual void Regenerate() => throw new System.NotImplementedException();
	public virtual void AutoJoinElements() => throw new System.NotImplementedException();
	public virtual void Paint(Autodesk.Revit.DB.ElementId elementId,Autodesk.Revit.DB.Face face,Autodesk.Revit.DB.ElementId materialId) => throw new System.NotImplementedException();
	public virtual void Paint(Autodesk.Revit.DB.ElementId elementId,Autodesk.Revit.DB.Face face,Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksetTable GetWorksetTable() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Units GetUnits() => throw new System.NotImplementedException();
	public virtual void SetUnits(Autodesk.Revit.DB.Units units) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksetId GetWorksetId(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual void Save(Autodesk.Revit.DB.SaveOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.MassDisplayTemporaryOverrideType MassDisplayTemporaryOverride
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Family OwnerFamily
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PrintManager PrintManager
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.SiteLocation SiteLocation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ProjectLocation ActiveProjectLocation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ProjectLocationSet ProjectLocations
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.View ActiveView
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FamilyManager FamilyManager
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PlanTopologySet PlanTopologies
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ProjectInfo ProjectInformation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PhaseArray Phases
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PanelTypeSet PanelTypes
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.MullionTypeSet MullionTypes
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.BindingMap ParameterBindings
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.DisplayUnit DisplayUnitSystem
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Settings Settings
	{
		get => throw new System.NotImplementedException();
	}
}

namespace Autodesk.Revit.DB;

public partial class Element : System.Object
{
	public virtual Autodesk.Revit.DB.Parameter GetParameter(Autodesk.Revit.DB.ForgeTypeId parameterTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementOnPhaseStatus GetPhaseStatus(Autodesk.Revit.DB.ElementId phaseId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetTypeId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId ChangeTypeId(Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryObject GetGeometryObjectFromReference(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalFileReference GetExternalFileReference() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalResourceReference GetExternalResourceReference(Autodesk.Revit.DB.ExternalResourceType resourceType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormatOptions GetParameterFormatOptions(Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId DemolishedPhaseId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId CreatedPhaseId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId OwnerViewId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId AssemblyInstanceId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId LevelId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId GroupId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.WorksetId WorksetId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.DesignOption DesignOption
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Document Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Location Location
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ParameterMap ParametersMap
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ParameterSet Parameters
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Category Category
	{
		get => throw new System.NotImplementedException();
	}
}

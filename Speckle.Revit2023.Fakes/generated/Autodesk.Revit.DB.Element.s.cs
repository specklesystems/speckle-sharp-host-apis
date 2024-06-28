namespace Autodesk.Revit.DB;

public partial class Element : System.Object
{
			public virtual Autodesk.Revit.DB.Category get_Category() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Parameter get_Parameter(Autodesk.Revit.DB.BuiltInParameter parameterId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Parameter get_Parameter(Autodesk.Revit.DB.Definition definition) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Parameter GetParameter(Autodesk.Revit.DB.ForgeTypeId parameterTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ParameterSet get_Parameters() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ParameterMap get_ParametersMap() => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.Document get_Document() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DesignOption get_DesignOption() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement get_Geometry(Autodesk.Revit.DB.Options options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxXYZ get_BoundingBox(Autodesk.Revit.DB.View A_0) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.WorksetId get_WorksetId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_GroupId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_Id() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_LevelId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_AssemblyInstanceId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_OwnerViewId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_CreatedPhaseId() => throw new System.NotImplementedException();
	public virtual void set_CreatedPhaseId(Autodesk.Revit.DB.ElementId createdPhaseId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_DemolishedPhaseId() => throw new System.NotImplementedException();
	public virtual void set_DemolishedPhaseId(Autodesk.Revit.DB.ElementId demolishedPhaseId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementOnPhaseStatus GetPhaseStatus(Autodesk.Revit.DB.ElementId phaseId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetTypeId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId ChangeTypeId(Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryObject GetGeometryObjectFromReference(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalFileReference GetExternalFileReference() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ExternalResourceReference GetExternalResourceReference(Autodesk.Revit.DB.ExternalResourceType resourceType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormatOptions GetParameterFormatOptions(Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	}

namespace Rhino;

public partial class RhinoDoc : System.IDisposable
{
	public RhinoDoc() {}
	public virtual System.Collections.Generic.IEnumerable<Rhino.Render.RenderPrimitive> GetRenderPrimitives(System.Boolean forceTriangleMeshes,System.Boolean quietly) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerable<Rhino.Render.RenderPrimitive> GetRenderPrimitives(Rhino.DocObjects.ViewportInfo viewport,System.Boolean forceTriangleMeshes,System.Boolean quietly) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IEnumerable<Rhino.Render.RenderPrimitive> GetRenderPrimitives(System.Guid plugInId,Rhino.DocObjects.ViewportInfo viewport,System.Boolean forceTriangleMeshes,System.Boolean quietly) => throw new System.NotImplementedException();
	public virtual System.String[] GetEmbeddedFilesList(System.Boolean missingOnly) => throw new System.NotImplementedException();
	public virtual void ClearUndoRecords(System.Boolean purgeDeletedObjects) => throw new System.NotImplementedException();
	public virtual void ClearUndoRecords(System.UInt32 undoSerialNumber,System.Boolean purgeDeletedObjects) => throw new System.NotImplementedException();
	public virtual void ClearRedoRecords() => throw new System.NotImplementedException();
	public virtual System.UInt32 BeginUndoRecord(System.String description) => throw new System.NotImplementedException();
	public virtual System.Boolean Undo() => throw new System.NotImplementedException();
	public virtual System.Boolean Redo() => throw new System.NotImplementedException();
	public virtual System.Boolean AddCustomUndoEvent(System.String description,System.EventHandler<Rhino.Commands.CustomUndoEventArgs> handler) => throw new System.NotImplementedException();
	public virtual System.Boolean AddCustomUndoEvent(System.String description,System.EventHandler<Rhino.Commands.CustomUndoEventArgs> handler,System.Object tag) => throw new System.NotImplementedException();
	public virtual System.Boolean EndUndoRecord(System.UInt32 undoRecordSerialNumber) => throw new System.NotImplementedException();
	public virtual System.Boolean SupportsRenderPrimitiveList(Rhino.DocObjects.ViewportInfo viewport,Rhino.Display.DisplayPipelineAttributes attrs) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderPrimitiveList GetRenderPrimitiveList(Rhino.DocObjects.ViewportInfo viewport,Rhino.Display.DisplayPipelineAttributes attrs) => throw new System.NotImplementedException();
	public static Rhino.RhinoDoc FromFilePath(System.String filePath) => throw new System.NotImplementedException();
	public static System.Boolean OpenFile(System.String path) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public static Rhino.RhinoDoc CreateHeadless(System.String file3dmTemplatePath) => throw new System.NotImplementedException();
	public static Rhino.RhinoDoc OpenHeadless(System.String file3dmPath) => throw new System.NotImplementedException();
	public virtual System.Boolean Import(System.String filePath) => throw new System.NotImplementedException();
	public virtual System.Boolean Save() => throw new System.NotImplementedException();
	public virtual System.Boolean SaveAs(System.String file3dmPath) => throw new System.NotImplementedException();
	public virtual System.Boolean SaveAs(System.String file3dmPath,System.Int32 version) => throw new System.NotImplementedException();
	public virtual System.Boolean SaveAsTemplate(System.String file3dmTemplatePath) => throw new System.NotImplementedException();
	public virtual System.Boolean SaveAsTemplate(System.String file3dmTemplatePath,System.Int32 version) => throw new System.NotImplementedException();
	public virtual System.Boolean Export(System.String filePath) => throw new System.NotImplementedException();
	public virtual System.Boolean ExportSelected(System.String filePath) => throw new System.NotImplementedException();
	public virtual System.String FindFile(System.String filename) => throw new System.NotImplementedException();
	public static Rhino.RhinoDoc Create(System.String modelTemplateFileName) => throw new System.NotImplementedException();
	public static Rhino.RhinoDoc[] OpenDocuments() => throw new System.NotImplementedException();
	public static Rhino.RhinoDoc[] OpenDocuments(System.Boolean includeHeadless) => throw new System.NotImplementedException();
	public static Rhino.RhinoDoc FromId(System.Int32 docId) => throw new System.NotImplementedException();
	public static Rhino.RhinoDoc FromRuntimeSerialNumber(System.UInt32 serialNumber) => throw new System.NotImplementedException();
	public virtual System.Int32 ReadFileVersion() => throw new System.NotImplementedException();
	public virtual System.String GetUnitSystemName(System.Boolean modelUnits,System.Boolean capitalize,System.Boolean singular,System.Boolean abbreviate) => throw new System.NotImplementedException();
	public virtual void AdjustModelUnitSystem(Rhino.UnitSystem newUnitSystem,System.Boolean scale) => throw new System.NotImplementedException();
	public virtual void AdjustPageUnitSystem(Rhino.UnitSystem newUnitSystem,System.Boolean scale) => throw new System.NotImplementedException();
	public virtual System.Boolean SetCustomUnitSystem(System.Boolean modelUnits,System.String customUnitName,System.Double metersPerCustomUnit,System.Boolean scale) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.MeshingParameters GetMeshingParameters(Rhino.Geometry.MeshingParameterStyle style) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.MeshingParameters GetAnalysisMeshingParameters() => throw new System.NotImplementedException();
	public virtual void SetCustomMeshingParameters(Rhino.Geometry.MeshingParameters mp) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.MeshingParameters GetCurrentMeshingParameters() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.ObjectAttributes CreateDefaultAttributes() => throw new System.NotImplementedException();
	public virtual System.Boolean IsHeadless
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.RhinoDoc ActiveDoc
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Path
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Notes
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.DateTime DateCreated
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.DateTime DateLastEdited
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ModelAbsoluteTolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ModelAngleToleranceRadians
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ModelAngleToleranceDegrees
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ModelRelativeTolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 ModelDistanceDisplayPrecision
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 PageDistanceDisplayPrecision
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PageAbsoluteTolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PageAngleToleranceRadians
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PageAngleToleranceDegrees
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PageRelativeTolerance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point3d ModelBasepoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean Modified
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.SubDComponentLocation SubDAppearance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.UnitSystem ModelUnitSystem
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.UnitSystem PageUnitSystem
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 DistanceDisplayPrecision
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsReadOnly
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsLocked
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsInitializing
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsCreating
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsOpening
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsAvailable
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsClosing
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 DocumentId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 RuntimeSerialNumber
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.EarthAnchorPoint EarthAnchorPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Render.RenderSettings RenderSettings
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.AnimationProperties AnimationProperties
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.MeshingParameterStyle MeshingParameterStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ModelSpaceHatchScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ModelSpaceHatchScalingEnabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ModelSpaceTextScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ModelSpaceAnnotationScalingEnabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean LayoutSpaceAnnotationScalingEnabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.Worksession Worksession
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderMaterialTable RenderMaterials
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderEnvironmentTable RenderEnvironments
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderTextureTable RenderTextures
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.ICurrentEnvironment CurrentEnvironment
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.GroundPlane GroundPlane
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSendingMail
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String TemplateFileUsed
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean UndoRecordingEnabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean UndoRecordingIsActive
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 NextUndoRecordSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 CurrentUndoRecordSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean UndoActive
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean RedoActive
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsCommandRunning
	{
		get => throw new System.NotImplementedException();
	}
}

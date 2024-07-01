namespace Autodesk.Revit.DB;

public partial class CompoundStructure : System.IDisposable
{
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CompoundStructureLayer> GetLayers() => throw new System.NotImplementedException();
	public virtual System.Boolean IsEqual(Autodesk.Revit.DB.CompoundStructure otherStructure) => throw new System.NotImplementedException();
	public virtual System.Boolean IsVerticallyHomogeneous() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CompoundStructure GetSimpleCompoundStructure(System.Double wallHeight,System.Double distAboveBase) => throw new System.NotImplementedException();
	public virtual System.Boolean DeleteLayer(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual void SetMaterialId(System.Int32 layerIdx,Autodesk.Revit.DB.ElementId materialId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetMaterialId(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual System.Double GetLayerWidth(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual void SetLayerWidth(System.Int32 layerIdx,System.Double width) => throw new System.NotImplementedException();
	public virtual System.Boolean CanLayerWidthBeNonZero(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual System.Double GetWidth() => throw new System.NotImplementedException();
	public virtual System.Double GetWidth(System.Int32 regionId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.MaterialFunctionAssignment GetLayerFunction(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual void SetLayerFunction(System.Int32 layerIdx,Autodesk.Revit.DB.MaterialFunctionAssignment function) => throw new System.NotImplementedException();
	public virtual System.Boolean IsStructuralDeck(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetDeckProfileId(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual void SetDeckProfileId(System.Int32 layerIdx,Autodesk.Revit.DB.ElementId profileId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.StructDeckEmbeddingType GetDeckEmbeddingType(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual void SetDeckEmbeddingType(System.Int32 layerIdx,Autodesk.Revit.DB.StructDeckEmbeddingType embedType) => throw new System.NotImplementedException();
	public virtual void SetLayers(System.Collections.Generic.IList<Autodesk.Revit.DB.CompoundStructureLayer> layers) => throw new System.NotImplementedException();
	public virtual void SetLayer(System.Int32 layerIdx,Autodesk.Revit.DB.CompoundStructureLayer layer) => throw new System.NotImplementedException();
	public virtual System.Boolean ParticipatesInWrapping(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual void SetParticipatesInWrapping(System.Int32 layerIdx,System.Boolean participatesInWrapping) => throw new System.NotImplementedException();
	public virtual System.Int32 GetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType shellLayerType) => throw new System.NotImplementedException();
	public virtual void SetNumberOfShellLayers(Autodesk.Revit.DB.ShellLayerType shellLayerType,System.Int32 numLayers) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCoreLayer(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual System.Boolean IsLayerValid(System.Int32 layerIdx,Autodesk.Revit.DB.CompoundStructureLayer layer) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidSampleHeight(System.Double height) => throw new System.NotImplementedException();
	public virtual System.Boolean CanSplitAndMergeRegionsBeUsed() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<System.Int32> GetRegionsAssociatedToLayer(System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual System.Int32 GetLayerAssociatedToRegion(System.Int32 regionId) => throw new System.NotImplementedException();
	public virtual void AssociateRegionWithLayer(System.Int32 regionId,System.Int32 layerIdx) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<System.Int32> GetRegionIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<System.Int32> GetSegmentIds() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidRegionId(System.Int32 regionId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSimpleRegion(System.Int32 regionId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsRectangularRegion(System.Int32 regionId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidSegmentId(System.Int32 segmentId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<System.Int32> GetAdjacentRegions(System.Int32 segmentId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RectangularGridSegmentOrientation GetSegmentOrientation(System.Int32 segmentId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxUV GetRegionEnvelope(System.Int32 regionId) => throw new System.NotImplementedException();
	public virtual System.Double GetSegmentCoordinate(System.Int32 segmentId) => throw new System.NotImplementedException();
	public virtual System.Int32 MergeRegionsAdjacentToSegment(System.Int32 segmentId,System.Int32 layerIdxForMergedRegion) => throw new System.NotImplementedException();
	public virtual System.Int32 SplitRegion(Autodesk.Revit.DB.UV gridUV,Autodesk.Revit.DB.RectangularGridSegmentOrientation splitDirection) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<System.Int32> GetExtendableRegionIds(System.Boolean top) => throw new System.NotImplementedException();
	public virtual void SetExtendableRegionIds(System.Boolean top,System.Collections.Generic.IList<System.Int32> regionIds) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<System.Int32> GetRegionsAlongLevel(System.Double height) => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeRegionWidth(System.Int32 regionId,System.Double newWidth) => throw new System.NotImplementedException();
	public virtual void RemoveWallSweep(Autodesk.Revit.DB.WallSweepType wallSweepType,System.Int32 id) => throw new System.NotImplementedException();
	public virtual void ClearWallSweeps(Autodesk.Revit.DB.WallSweepType wallSweepType) => throw new System.NotImplementedException();
	public virtual System.Int32 GetPreviousNonZeroLayerIndex(System.Int32 thisIdx) => throw new System.NotImplementedException();
	public virtual System.Int32 GetCoreBoundaryLayerIndex(Autodesk.Revit.DB.ShellLayerType shellLayerType) => throw new System.NotImplementedException();
	public virtual System.Double GetOffsetForLocationLine(Autodesk.Revit.DB.WallLocationLine wallLocationLine) => throw new System.NotImplementedException();
	public virtual System.Int32 GetFirstCoreLayerIndex() => throw new System.NotImplementedException();
	public virtual System.Int32 GetLastCoreLayerIndex() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.CompoundStructure CreateSimpleCompoundStructure(System.Collections.Generic.IList<Autodesk.Revit.DB.CompoundStructureLayer> layers) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.CompoundStructure CreateSingleLayerCompoundStructure(System.Double sampleHeight,Autodesk.Revit.DB.MaterialFunctionAssignment layerFunction,System.Double width,Autodesk.Revit.DB.ElementId materialId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.CompoundStructure CreateSingleLayerCompoundStructure(Autodesk.Revit.DB.MaterialFunctionAssignment layerFunction,System.Double width,Autodesk.Revit.DB.ElementId materialId) => throw new System.NotImplementedException();
	public static System.Double GetMinimumLayerThickness() => throw new System.NotImplementedException();
	public virtual System.Boolean CanLayerBeVariable(System.Int32 variableLayerIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean CanLayerBeStructuralMaterial(System.Int32 layerIndex) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double MinimumSampleHeight
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double CutoffHeight
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SampleHeight
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 StructuralMaterialIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 VariableLayerIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.OpeningWrappingCondition OpeningWrapping
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.EndCapCondition EndCap
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HasStructuralDeck
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsVerticallyCompound
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 LayerCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsEmpty
	{
		get => throw new System.NotImplementedException();
	}
}

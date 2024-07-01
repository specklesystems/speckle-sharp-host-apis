namespace Autodesk.Revit.DB;

public partial class TessellatedShapeBuilder : Autodesk.Revit.DB.ShapeBuilder
{
	public TessellatedShapeBuilder() => throw new System.NotImplementedException();
	public virtual void OpenConnectedFaceSet(System.Boolean isSolid) => throw new System.NotImplementedException();
	public virtual void CloseConnectedFaceSet() => throw new System.NotImplementedException();
	public virtual void CancelConnectedFaceSet() => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual System.Boolean DoesFaceHaveEnoughLoopsAndVertices(Autodesk.Revit.DB.TessellatedFace face) => throw new System.NotImplementedException();
	public virtual void AddFace(Autodesk.Revit.DB.TessellatedFace face) => throw new System.NotImplementedException();
	public virtual System.Boolean AreTargetAndFallbackCompatible(Autodesk.Revit.DB.TessellatedShapeBuilderTarget target,Autodesk.Revit.DB.TessellatedShapeBuilderFallback fallback) => throw new System.NotImplementedException();
	public virtual void Build() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.MeshFromGeometryOperationResult CreateMeshByExtrusion(IList<Autodesk.Revit.DB.CurveLoop> profileLoops,Autodesk.Revit.DB.XYZ extrusionDirection,System.Double extrusionDistance,Autodesk.Revit.DB.ElementId materialId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TessellatedShapeBuilderResult GetBuildResult() => throw new System.NotImplementedException();
	public virtual System.Int32 NumberOfCompletedFaceSets
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String OwnerInfo
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 LogInteger
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String LogString
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId GraphicsStyleId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.TessellatedShapeBuilderFallback Fallback
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.TessellatedShapeBuilderTarget Target
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsFaceSetOpen
	{
		get => throw new System.NotImplementedException();
	}
}

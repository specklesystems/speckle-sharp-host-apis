namespace Autodesk.Revit.DB;

public partial class TessellatedShapeBuilder : Autodesk.Revit.DB.ShapeBuilder
{
	public virtual void CloseConnectedFaceSet() => throw new System.NotImplementedException();
	public virtual void CancelConnectedFaceSet() => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual void AddFace(Autodesk.Revit.DB.TessellatedFace face) => throw new System.NotImplementedException();
	public virtual void Build() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TessellatedShapeBuilderResult GetBuildResult() => throw new System.NotImplementedException();
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
}

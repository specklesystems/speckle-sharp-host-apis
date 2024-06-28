namespace Autodesk.Revit.DB;

public partial class TessellatedShapeBuilder : Autodesk.Revit.DB.ShapeBuilder
{
	public virtual Autodesk.Revit.DB.TessellatedShapeBuilderTarget get_Target() => throw new System.NotImplementedException();
	public virtual void set_Target(Autodesk.Revit.DB.TessellatedShapeBuilderTarget target) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TessellatedShapeBuilderFallback get_Fallback() => throw new System.NotImplementedException();
	public virtual void set_Fallback(Autodesk.Revit.DB.TessellatedShapeBuilderFallback fallback) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_GraphicsStyleId() => throw new System.NotImplementedException();
	public virtual void set_GraphicsStyleId(Autodesk.Revit.DB.ElementId graphicsStyleId) => throw new System.NotImplementedException();
	public virtual void CloseConnectedFaceSet() => throw new System.NotImplementedException();
	public virtual void CancelConnectedFaceSet() => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual void AddFace(Autodesk.Revit.DB.TessellatedFace face) => throw new System.NotImplementedException();
	public virtual void Build() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TessellatedShapeBuilderResult GetBuildResult() => throw new System.NotImplementedException();
}

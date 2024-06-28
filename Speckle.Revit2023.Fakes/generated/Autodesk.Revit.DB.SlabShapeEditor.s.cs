namespace Autodesk.Revit.DB;

public partial class SlabShapeEditor : System.Object
{
	public virtual void Enable() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SlabShapeVertexArray get_SlabShapeVertices() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SlabShapeCreaseArray get_SlabShapeCreases() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SlabShapeVertex DrawPoint(Autodesk.Revit.DB.XYZ location) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SlabShapeCreaseArray DrawSplitLine(Autodesk.Revit.DB.SlabShapeVertex startVertex,Autodesk.Revit.DB.SlabShapeVertex endVertex) => throw new System.NotImplementedException();
	public virtual void ResetSlabShape() => throw new System.NotImplementedException();
	public virtual void PickSupport(Autodesk.Revit.DB.Line gLine) => throw new System.NotImplementedException();
	}

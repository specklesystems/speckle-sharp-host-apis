namespace Autodesk.Revit.DB;

public partial class SlabShapeEditor : System.IDisposable
{
	public virtual void Enable() => throw new System.NotImplementedException();
	public virtual void ModifySubElement(Autodesk.Revit.DB.SlabShapeCrease crease,System.Double offset) => throw new System.NotImplementedException();
	public virtual void ModifySubElement(Autodesk.Revit.DB.SlabShapeVertex vertex,System.Double offset) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SlabShapeVertex DrawPoint(Autodesk.Revit.DB.XYZ location) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SlabShapeCreaseArray DrawSplitLine(Autodesk.Revit.DB.SlabShapeVertex startVertex,Autodesk.Revit.DB.SlabShapeVertex endVertex) => throw new System.NotImplementedException();
	public virtual void ResetSlabShape() => throw new System.NotImplementedException();
	public virtual void PickSupport(Autodesk.Revit.DB.Line gLine) => throw new System.NotImplementedException();
	public virtual void CreateCreasesFromFoldingLines(Autodesk.Revit.DB.Element hostObj,System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> references) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.SlabShapeCreaseArray SlabShapeCreases
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.SlabShapeVertexArray SlabShapeVertices
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsEnabled
	{
		get => throw new System.NotImplementedException();
	}
}

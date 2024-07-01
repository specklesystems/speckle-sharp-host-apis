namespace Autodesk.Revit.DB;

public partial class TessellatedFace : System.IDisposable
{
	public TessellatedFace(IList<IList<Autodesk.Revit.DB.XYZ>> allLoopVertices,Autodesk.Revit.DB.ElementId materialId) => throw new System.NotImplementedException();
	public TessellatedFace(IList<Autodesk.Revit.DB.XYZ> outerLoopVertices,Autodesk.Revit.DB.ElementId materialId) => throw new System.NotImplementedException();
	public virtual IList<IList<Autodesk.Revit.DB.XYZ>> GetBoundaryLoops() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId MaterialId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

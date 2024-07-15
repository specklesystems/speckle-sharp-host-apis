namespace Autodesk.Revit.DB;

public partial class TriangulatedShellComponent : System.IDisposable
{
	public TriangulatedShellComponent() {}
	public virtual Autodesk.Revit.DB.XYZ GetVertex(System.Int32 vertexIndex) => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TriangleInShellComponent GetTriangle(System.Int32 triangleIndex) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 TriangleCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 VertexCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsClosed
	{
		get => throw new System.NotImplementedException();
	}
}

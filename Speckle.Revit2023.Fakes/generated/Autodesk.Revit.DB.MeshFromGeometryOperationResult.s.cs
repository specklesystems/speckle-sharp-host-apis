namespace Autodesk.Revit.DB;

public partial class MeshFromGeometryOperationResult : System.IDisposable
{
	public MeshFromGeometryOperationResult() {}
	public virtual Autodesk.Revit.DB.Mesh GetMesh() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.MeshFromGeometryOperationIssue> GetIssues() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsMeshAvailable
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Tessellated
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasInvalidData
	{
		get => throw new System.NotImplementedException();
	}
}

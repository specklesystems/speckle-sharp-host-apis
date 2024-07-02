namespace Rhino.DocObjects;

public partial class MeshObject : Rhino.DocObjects.RhinoObject
{
	public MeshObject() {}
	public virtual Rhino.Geometry.Mesh DuplicateMeshGeometry() => throw new System.NotImplementedException();
	public virtual System.Boolean IsCustomObject
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Mesh MeshGeometry
	{
		get => throw new System.NotImplementedException();
	}
}

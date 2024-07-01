namespace Autodesk.Revit.DB;

public partial class DirectShapeLibrary : System.IDisposable
{
	public static Autodesk.Revit.DB.DirectShapeLibrary GetDirectShapeLibrary(Autodesk.Revit.DB.Document ADoc) => throw new System.NotImplementedException();
	public virtual void AddDefinition(System.String id,IList<Autodesk.Revit.DB.GeometryObject> GNodes) => throw new System.NotImplementedException();
	public virtual void AddDefinition(System.String id,Autodesk.Revit.DB.GeometryObject GNode) => throw new System.NotImplementedException();
	public virtual void AddDefinitionType(System.String id,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.GeometryObject> FindDefinition(System.String id) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId FindDefinitionType(System.String id) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(System.String id) => throw new System.NotImplementedException();
	public virtual System.Boolean ContainsType(System.String name) => throw new System.NotImplementedException();
	public virtual void Reset() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}

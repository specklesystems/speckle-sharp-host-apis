namespace Autodesk.Revit.DB;

public partial class GeometryElement : Autodesk.Revit.DB.GeometryObject,IEnumerable<Autodesk.Revit.DB.GeometryObject>
{
	public virtual IEnumerator<Autodesk.Revit.DB.GeometryObject> GetEnumerator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxXYZ GetBoundingBox() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetTransformed(Autodesk.Revit.DB.Transform transform) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Material MaterialElement
	{
		get => throw new System.NotImplementedException();
	}
}

namespace Autodesk.Revit.DB;

public partial class GeometryElement : Autodesk.Revit.DB.GeometryObject
{
		public virtual Autodesk.Revit.DB.BoundingBoxXYZ GetBoundingBox() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Material get_MaterialElement() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetTransformed(Autodesk.Revit.DB.Transform transform) => throw new System.NotImplementedException();
}

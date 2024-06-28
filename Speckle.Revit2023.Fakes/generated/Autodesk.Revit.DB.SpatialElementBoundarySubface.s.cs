namespace Autodesk.Revit.DB;

public partial class SpatialElementBoundarySubface : System.Object
{
	public virtual Autodesk.Revit.DB.Face GetSpatialElementFace() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Face GetSubface() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Face GetBoundingElementFace() => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.SubfaceType SubfaceType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.LinkElementId SpatialBoundaryElement
	{
		get => throw new System.NotImplementedException();
	}
}

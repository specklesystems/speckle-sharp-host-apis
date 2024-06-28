namespace Autodesk.Revit.DB;

public partial class PointOnPlane : Autodesk.Revit.DB.PointElementReference
{
	public virtual Autodesk.Revit.DB.Reference GetPlaneReference() => throw new System.NotImplementedException();
	public virtual void SetPlaneReference(Autodesk.Revit.DB.Reference planeReference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV XVec
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.UV Position
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

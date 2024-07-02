namespace Autodesk.Revit.DB;

public partial class PointOnFace : Autodesk.Revit.DB.PointElementReference
{
	public PointOnFace() {}
	public virtual Autodesk.Revit.DB.Reference GetFaceReference() => throw new System.NotImplementedException();
	public virtual void SetFaceReference(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV UV
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

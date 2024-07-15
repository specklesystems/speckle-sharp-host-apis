namespace Autodesk.Revit.DB;

public partial class FreeFormElement : Autodesk.Revit.DB.GenericForm
{
	public FreeFormElement() {}
	public static Autodesk.Revit.DB.FreeFormElement Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Solid geometry) => throw new System.NotImplementedException();
	public virtual void SetFaceOffset(Autodesk.Revit.DB.Face face,System.Double offset) => throw new System.NotImplementedException();
	public virtual System.Boolean CanOffsetFace(Autodesk.Revit.DB.Face face) => throw new System.NotImplementedException();
	public virtual void UpdateSolidGeometry(Autodesk.Revit.DB.Solid newGeometry) => throw new System.NotImplementedException();
}

namespace Autodesk.Revit.DB;

public partial class Reference : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.Reference CreateLinkReference(Autodesk.Revit.DB.RevitLinkInstance revitLinkInstance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference CreateReferenceInLink() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_ElementId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_LinkedElementId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementReferenceType get_ElementReferenceType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_GlobalPoint() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV get_UVPoint() => throw new System.NotImplementedException();
}

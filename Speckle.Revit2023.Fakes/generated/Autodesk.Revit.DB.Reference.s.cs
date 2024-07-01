namespace Autodesk.Revit.DB;

public partial class Reference : Autodesk.Revit.DB.APIObject
{
	public Reference(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference CreateLinkReference(Autodesk.Revit.DB.RevitLinkInstance revitLinkInstance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference CreateReferenceInLink() => throw new System.NotImplementedException();
	public virtual System.String ConvertToStableRepresentation(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Reference ParseFromStableRepresentation(Autodesk.Revit.DB.Document document,System.String representation) => throw new System.NotImplementedException();
	public virtual System.Boolean EqualTo(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV UVPoint
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ GlobalPoint
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementReferenceType ElementReferenceType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId LinkedElementId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId ElementId
	{
		get => throw new System.NotImplementedException();
	}
}

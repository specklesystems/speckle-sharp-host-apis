namespace Autodesk.Revit.DB;

public partial class RadialArray : Autodesk.Revit.DB.BaseArray
{
	public RadialArray() {}
	public static Autodesk.Revit.DB.RadialArray Create(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.View dBView,Autodesk.Revit.DB.ElementId id,System.Int32 count,Autodesk.Revit.DB.Line axis,System.Double angle,Autodesk.Revit.DB.ArrayAnchorMember anchorMember) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.RadialArray Create(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.View dBView,System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ids,System.Int32 count,Autodesk.Revit.DB.Line axis,System.Double angle,Autodesk.Revit.DB.ArrayAnchorMember anchorMember) => throw new System.NotImplementedException();
	public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ArrayElementsWithoutAssociation(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.View dBView,System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ids,System.Int32 count,Autodesk.Revit.DB.Line axis,System.Double angle,Autodesk.Revit.DB.ArrayAnchorMember anchorMember) => throw new System.NotImplementedException();
	public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ArrayElementWithoutAssociation(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.View dBView,Autodesk.Revit.DB.ElementId id,System.Int32 count,Autodesk.Revit.DB.Line axis,System.Double angle,Autodesk.Revit.DB.ArrayAnchorMember anchorMember) => throw new System.NotImplementedException();
	public static System.Boolean IsValidArraySize(System.Int32 count) => throw new System.NotImplementedException();
	public static System.Boolean IsRotationAngleValid(System.Double angle) => throw new System.NotImplementedException();
	public new System.Int32 NumMembers
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

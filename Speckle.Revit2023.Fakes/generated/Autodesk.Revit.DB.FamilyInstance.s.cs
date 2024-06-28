namespace Autodesk.Revit.DB;

public partial class FamilyInstance : Autodesk.Revit.DB.Instance
{
	public virtual void FlipFromToRoom() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetOriginalGeometry(Autodesk.Revit.DB.Options options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetSpatialElementCalculationPoint() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SweptProfile GetSweptProfile() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyInstanceReferenceType GetReferenceType(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.IExtension ExtensionUtility
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Element SuperComponent
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Architecture.Room ToRoom
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Architecture.Room FromRoom
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ FacingOrientation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ HandOrientation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Reference HostFace
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Element Host
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Architecture.Room Room
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId StructuralMaterialId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.MEPModel MEPModel
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FamilySymbol Symbol
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

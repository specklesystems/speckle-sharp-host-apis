namespace Autodesk.Revit.DB;

public partial class FamilyInstance : Autodesk.Revit.DB.Instance
{
	public virtual Autodesk.Revit.DB.Architecture.Room get_Room(Autodesk.Revit.DB.Phase phase) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Mechanical.Space get_Space(Autodesk.Revit.DB.Phase phase) => throw new System.NotImplementedException();
	public virtual System.Boolean flipHand() => throw new System.NotImplementedException();
	public virtual System.Boolean flipFacing() => throw new System.NotImplementedException();
	public virtual System.Boolean rotate() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId Split(System.Double param) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.Room get_FromRoom(Autodesk.Revit.DB.Phase phase) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Architecture.Room get_ToRoom(Autodesk.Revit.DB.Phase phase) => throw new System.NotImplementedException();
	public virtual void FlipFromToRoom() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetSubComponentIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetCopingIds() => throw new System.NotImplementedException();
	public virtual System.Boolean SetCopingIds(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> cutters) => throw new System.NotImplementedException();
	public virtual System.Boolean AddCoping(Autodesk.Revit.DB.FamilyInstance cutter) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveCoping(Autodesk.Revit.DB.FamilyInstance cutter) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FamilyPointPlacementReference> GetFamilyPointPlacementReferences() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetOriginalGeometry(Autodesk.Revit.DB.Options options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetSpatialElementCalculationPoint() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetSpatialElementFromToCalculationPoints() => throw new System.NotImplementedException();
	public virtual System.Boolean HasModifiedGeometry() => throw new System.NotImplementedException();
	public virtual System.Boolean HasSweptProfile() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SweptProfile GetSweptProfile() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetReferences(Autodesk.Revit.DB.FamilyInstanceReferenceType referenceType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyInstanceReferenceType GetReferenceType(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetReferenceByName(System.String name) => throw new System.NotImplementedException();
	public virtual System.String GetReferenceName(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual System.Boolean HasSpatialElementFromToCalculationPoints
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HasSpatialElementCalculationPoint
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsWorkPlaneFlipped
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean CanFlipWorkPlane
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSlantedColumn
	{
		get => throw new System.NotImplementedException();
	}
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
	public virtual System.Boolean CanSplit
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CanRotate
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CanFlipFacing
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CanFlipHand
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Mirrored
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Invisible
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean FacingFlipped
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HandFlipped
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
	public virtual System.Double HostParameter
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Element Host
	{
		get => throw new System.NotImplementedException();
	}
	public new Autodesk.Revit.DB.Location Location
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Mechanical.Space Space
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Architecture.Room Room
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.StructuralType StructuralType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.StructuralInstanceUsage StructuralUsage
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId StructuralMaterialId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.StructuralMaterialType StructuralMaterialType
	{
		get => throw new System.NotImplementedException();
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

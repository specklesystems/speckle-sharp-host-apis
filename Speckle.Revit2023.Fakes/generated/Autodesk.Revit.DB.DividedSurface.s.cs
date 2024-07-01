namespace Autodesk.Revit.DB;

public partial class DividedSurface : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.UV GetGridNodeUV(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GridNodeLocation GetGridNodeLocation(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetGridNodeReference(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetGridSegmentReference(Autodesk.Revit.DB.GridNode gridNode,Autodesk.Revit.DB.GridSegmentDirection gridSegmentDirection) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSeedNode(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetTileReference(Autodesk.Revit.DB.GridNode gridNode,System.Int32 tileIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyInstance GetTileFamilyInstance(Autodesk.Revit.DB.GridNode gridNode,System.Int32 tileIndex) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.DividedSurface Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Reference faceReference) => throw new System.NotImplementedException();
	public static System.Boolean CanBeDivided(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetReferencesWithDividedSurfaces(Autodesk.Revit.DB.Element host) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.DividedSurface GetDividedSurfaceForReference(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Reference faceReference) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetAllIntersectionElements() => throw new System.NotImplementedException();
	public virtual void AddIntersectionElement(Autodesk.Revit.DB.ElementId newIntersectionElemId) => throw new System.NotImplementedException();
	public virtual void RemoveIntersectionElement(Autodesk.Revit.DB.ElementId referenceElemIdToRemove) => throw new System.NotImplementedException();
	public virtual void RemoveAllIntersectionElements() => throw new System.NotImplementedException();
	public virtual System.Boolean CanBeIntersectionElement(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual System.Int32 NumberOfVGridlines
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NumberOfUGridlines
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsComponentFlipped
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsComponentMirrored
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ComponentRotation ComponentRotation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 VPatternIndent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 UPatternIndent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.BorderTile BorderTile
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AllGridRotation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.SpacingRule VSpacingRule
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.SpacingRule USpacingRule
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Reference HostReference
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Element Host
	{
		get => throw new System.NotImplementedException();
	}
}

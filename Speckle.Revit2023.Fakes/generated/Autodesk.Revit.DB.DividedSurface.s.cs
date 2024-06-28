namespace Autodesk.Revit.DB;

public partial class DividedSurface : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.UV GetGridNodeUV(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GridNodeLocation GetGridNodeLocation(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetGridNodeReference(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetGridSegmentReference(Autodesk.Revit.DB.GridNode gridNode,Autodesk.Revit.DB.GridSegmentDirection gridSegmentDirection) => throw new System.NotImplementedException();
	public virtual void AddIntersectionElement(Autodesk.Revit.DB.ElementId newIntersectionElemId) => throw new System.NotImplementedException();
	public virtual void RemoveIntersectionElement(Autodesk.Revit.DB.ElementId referenceElemIdToRemove) => throw new System.NotImplementedException();
	public virtual void RemoveAllIntersectionElements() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ComponentRotation ComponentRotation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.BorderTile BorderTile
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

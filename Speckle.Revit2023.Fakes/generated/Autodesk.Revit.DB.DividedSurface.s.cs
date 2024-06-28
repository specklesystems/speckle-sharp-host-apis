namespace Autodesk.Revit.DB;

public partial class DividedSurface : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.Element get_Host() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference get_HostReference() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SpacingRule get_USpacingRule() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SpacingRule get_VSpacingRule() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BorderTile get_BorderTile() => throw new System.NotImplementedException();
	public virtual void set_BorderTile(Autodesk.Revit.DB.BorderTile A_0) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ComponentRotation get_ComponentRotation() => throw new System.NotImplementedException();
	public virtual void set_ComponentRotation(Autodesk.Revit.DB.ComponentRotation A_0) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV GetGridNodeUV(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GridNodeLocation GetGridNodeLocation(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetGridNodeReference(Autodesk.Revit.DB.GridNode gridNode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetGridSegmentReference(Autodesk.Revit.DB.GridNode gridNode,Autodesk.Revit.DB.GridSegmentDirection gridSegmentDirection) => throw new System.NotImplementedException();
	public virtual void AddIntersectionElement(Autodesk.Revit.DB.ElementId newIntersectionElemId) => throw new System.NotImplementedException();
	public virtual void RemoveIntersectionElement(Autodesk.Revit.DB.ElementId referenceElemIdToRemove) => throw new System.NotImplementedException();
	public virtual void RemoveAllIntersectionElements() => throw new System.NotImplementedException();
}

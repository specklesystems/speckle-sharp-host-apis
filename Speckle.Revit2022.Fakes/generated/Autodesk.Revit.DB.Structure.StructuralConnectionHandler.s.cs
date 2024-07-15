namespace Autodesk.Revit.DB.Structure;

public partial class StructuralConnectionHandler : Autodesk.Revit.DB.Element
{
	public StructuralConnectionHandler() {}
	public static Autodesk.Revit.DB.Structure.StructuralConnectionHandler Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> idsToConnect,Autodesk.Revit.DB.ElementId typeId,System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.ConnectionInputPoint> additionalInputPoints) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.StructuralConnectionHandler Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> elementIds,System.String typeName) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.StructuralConnectionHandler Create(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> idsToConnect,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.StructuralConnectionHandler CreateGenericConnection(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> idsToConnect) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetConnectedElementIds() => throw new System.NotImplementedException();
	public virtual void AddElementIds(System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> elemIds) => throw new System.NotImplementedException();
	public virtual void AddReferences(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> picks) => throw new System.NotImplementedException();
	public virtual void RemoveElementIds(System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> elemIds) => throw new System.NotImplementedException();
	public virtual void RemoveReferences(System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> picks) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetOrigin() => throw new System.NotImplementedException();
	public virtual System.Boolean IsDetailed() => throw new System.NotImplementedException();
	public virtual System.Boolean IsCustom() => throw new System.NotImplementedException();
	public virtual void SetDefaultElementOrder() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetInputReferences() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.ConnectionInputPoint> GetInputPoints() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.ConnectionInputPoint GetInputPoint(System.Guid id) => throw new System.NotImplementedException();
	public virtual System.Boolean OverrideTypeParams
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ApprovalTypeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.StructuralConnectionCodeCheckingStatus CodeCheckingStatus
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 SingleElementEndIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

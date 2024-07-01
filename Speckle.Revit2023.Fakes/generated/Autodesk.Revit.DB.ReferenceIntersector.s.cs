namespace Autodesk.Revit.DB;

public partial class ReferenceIntersector : System.IDisposable
{
	public ReferenceIntersector(Autodesk.Revit.DB.ElementFilter filter,Autodesk.Revit.DB.FindReferenceTarget targetType,Autodesk.Revit.DB.View3D view3d) => throw new System.NotImplementedException();
	public ReferenceIntersector(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> targetElementIds,Autodesk.Revit.DB.FindReferenceTarget targetType,Autodesk.Revit.DB.View3D view3d) => throw new System.NotImplementedException();
	public ReferenceIntersector(Autodesk.Revit.DB.ElementId targetElementId,Autodesk.Revit.DB.FindReferenceTarget targetType,Autodesk.Revit.DB.View3D view3d) => throw new System.NotImplementedException();
	public ReferenceIntersector(Autodesk.Revit.DB.View3D view3d) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ReferenceWithContext> Find(Autodesk.Revit.DB.XYZ origin,Autodesk.Revit.DB.XYZ direction) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ReferenceWithContext FindNearest(Autodesk.Revit.DB.XYZ origin,Autodesk.Revit.DB.XYZ direction) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementFilter GetFilter() => throw new System.NotImplementedException();
	public virtual void SetFilter(Autodesk.Revit.DB.ElementFilter filter) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetTargetElementIds() => throw new System.NotImplementedException();
	public virtual void SetTargetElementIds(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean FindReferencesInRevitLinks
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.FindReferenceTarget TargetType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ViewId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

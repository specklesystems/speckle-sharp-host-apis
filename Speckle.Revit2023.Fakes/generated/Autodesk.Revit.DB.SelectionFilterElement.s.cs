namespace Autodesk.Revit.DB;

public partial class SelectionFilterElement : Autodesk.Revit.DB.FilterElement
{
	public static Autodesk.Revit.DB.SelectionFilterElement Create(Autodesk.Revit.DB.Document document,System.String name) => throw new System.NotImplementedException();
	public virtual void SetElementIds(ICollection<Autodesk.Revit.DB.ElementId> ids) => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetElementIds() => throw new System.NotImplementedException();
	public virtual System.Boolean IsEmpty() => throw new System.NotImplementedException();
	public virtual void AddSingle(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual void AddSet(ICollection<Autodesk.Revit.DB.ElementId> ids) => throw new System.NotImplementedException();
	public virtual void RemoveSingle(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual System.Int32 RemoveSet(ICollection<Autodesk.Revit.DB.ElementId> ids) => throw new System.NotImplementedException();
	public virtual System.Boolean Contains(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
}

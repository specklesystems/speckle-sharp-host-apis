namespace Autodesk.Revit.DB;

public partial class PartMaker : Autodesk.Revit.DB.Element
{
	public virtual System.Boolean IsSourceElement(Autodesk.Revit.DB.ElementId elemId) => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.LinkElementId> GetSourceElementIds() => throw new System.NotImplementedException();
	public virtual void SetSourceElementIds(ICollection<Autodesk.Revit.DB.ElementId> sourceElementIds) => throw new System.NotImplementedException();
}

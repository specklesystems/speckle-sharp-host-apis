namespace Autodesk.Revit.DB;

public partial class Group : Autodesk.Revit.DB.Element
{
				public virtual Autodesk.Revit.DB.ElementId get_AttachedParentId() => throw new System.NotImplementedException();
	public virtual void ShowAttachedDetailGroups(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.ElementId detailGroupTypeId) => throw new System.NotImplementedException();
	public virtual void ShowAllAttachedDetailGroups(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void HideAttachedDetailGroups(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.ElementId detailGroupTypeId) => throw new System.NotImplementedException();
	public virtual void HideAllAttachedDetailGroups(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
}

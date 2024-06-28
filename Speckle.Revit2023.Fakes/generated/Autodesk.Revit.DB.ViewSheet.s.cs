namespace Autodesk.Revit.DB;

public partial class ViewSheet : Autodesk.Revit.DB.View
{
	public virtual void ConvertToRealSheet(Autodesk.Revit.DB.ElementId titleBlockTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCurrentRevision() => throw new System.NotImplementedException();
	public virtual void DeleteViewport(Autodesk.Revit.DB.Viewport viewport) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId Duplicate(Autodesk.Revit.DB.SheetDuplicateOption duplicateOption) => throw new System.NotImplementedException();
}

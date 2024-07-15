namespace Autodesk.Revit.DB;

public partial class ViewSheet : Autodesk.Revit.DB.View
{
	public ViewSheet() {}
	public virtual void ConvertToRealSheet(Autodesk.Revit.DB.ElementId titleBlockTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCurrentRevision() => throw new System.NotImplementedException();
	public virtual System.String GetRevisionNumberOnSheet(Autodesk.Revit.DB.ElementId revisionId) => throw new System.NotImplementedException();
	public virtual System.String GetRevisionCloudNumberOnSheet(Autodesk.Revit.DB.ElementId revisionCloudId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetAllRevisionIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetAdditionalRevisionIds() => throw new System.NotImplementedException();
	public virtual void SetAdditionalRevisionIds(System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> projectRevisionIds) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ViewSheet CreatePlaceholder(Autodesk.Revit.DB.Document aDoc) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ViewSheet Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId titleBlockTypeId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetAllViewports() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAllPlacedViews() => throw new System.NotImplementedException();
	public virtual void DeleteViewport(Autodesk.Revit.DB.Viewport viewport) => throw new System.NotImplementedException();
	public virtual System.Boolean IsPlaceholder
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String SheetNumber
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

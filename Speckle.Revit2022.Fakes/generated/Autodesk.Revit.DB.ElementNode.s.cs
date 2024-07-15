namespace Autodesk.Revit.DB;

public partial class ElementNode : Autodesk.Revit.DB.RenderNode
{
	public ElementNode() {}
	public virtual Autodesk.Revit.DB.ElementId LinkInstanceId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Document Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId ElementId
	{
		get => throw new System.NotImplementedException();
	}
}

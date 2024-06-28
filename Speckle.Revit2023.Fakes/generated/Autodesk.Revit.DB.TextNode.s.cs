namespace Autodesk.Revit.DB;

public partial class TextNode : Autodesk.Revit.DB.RenderNode
{
	public virtual Autodesk.Revit.DB.Color get_Color() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_Position() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_BaseDirection() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_UpDirection() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.HorizontalTextAlignment get_HorizontalAlignment() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.VerticalTextAlignment get_VerticalAlignment() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormattedText GetFormattedText() => throw new System.NotImplementedException();
}

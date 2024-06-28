namespace Autodesk.Revit.DB;

public partial class Control : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.ControlShape get_Shape() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_Origin() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.View get_View() => throw new System.NotImplementedException();
}

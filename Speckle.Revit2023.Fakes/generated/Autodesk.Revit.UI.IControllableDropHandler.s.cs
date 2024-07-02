namespace Autodesk.Revit.UI;

public partial interface IControllableDropHandler
{
	public  System.Boolean CanExecute(Autodesk.Revit.UI.UIDocument document,System.Object data,Autodesk.Revit.DB.ElementId dropViewId);
}

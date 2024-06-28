namespace Autodesk.Revit.UI;

public partial class TaskDialog : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.UI.TaskDialogResult Show() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.TaskDialogCommonButtons CommonButtons
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.UI.TaskDialogIcon MainIcon
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.UI.TaskDialogResult DefaultButton
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

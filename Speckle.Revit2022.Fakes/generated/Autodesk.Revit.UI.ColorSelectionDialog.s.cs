namespace Autodesk.Revit.UI;

public partial class ColorSelectionDialog : System.IDisposable
{
	public ColorSelectionDialog() {}
	public virtual Autodesk.Revit.UI.ItemSelectionDialogResult Show() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Color OriginalColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Color SelectedColor
	{
		get => throw new System.NotImplementedException();
	}
}

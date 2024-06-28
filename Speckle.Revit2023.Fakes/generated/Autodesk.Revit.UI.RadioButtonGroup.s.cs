namespace Autodesk.Revit.UI;

public partial class RadioButtonGroup : Autodesk.Revit.UI.RibbonItem
{
	public virtual Autodesk.Revit.UI.ToggleButton AddItem(Autodesk.Revit.UI.ToggleButtonData buttonData) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.UI.ToggleButton> AddItems(IList<Autodesk.Revit.UI.ToggleButtonData> buttonData) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.UI.ToggleButton> GetItems() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.ToggleButton Current
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

namespace Autodesk.Revit.UI;

public partial class PulldownButton : Autodesk.Revit.UI.RibbonButton
{
	public virtual IList<Autodesk.Revit.UI.PushButton> GetItems() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.PushButton AddPushButton(Autodesk.Revit.UI.PushButtonData buttonData) => throw new System.NotImplementedException();
	public virtual void AddSeparator() => throw new System.NotImplementedException();
}

namespace Autodesk.Revit.UI;

public partial class ComboBox : Autodesk.Revit.UI.RibbonItem
{
	public virtual Autodesk.Revit.UI.ComboBoxMember get_Current() => throw new System.NotImplementedException();
	public virtual void set_Current(Autodesk.Revit.UI.ComboBoxMember value) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.ComboBoxMember AddItem(Autodesk.Revit.UI.ComboBoxMemberData memberData) => throw new System.NotImplementedException();
	public virtual void AddSeparator() => throw new System.NotImplementedException();
}

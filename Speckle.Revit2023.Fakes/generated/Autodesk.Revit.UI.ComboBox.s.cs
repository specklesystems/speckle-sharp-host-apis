namespace Autodesk.Revit.UI;

public partial class ComboBox : Autodesk.Revit.UI.RibbonItem
{
  public ComboBox() { }

  public virtual Autodesk.Revit.UI.ComboBoxMember AddItem(Autodesk.Revit.UI.ComboBoxMemberData memberData) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.UI.ComboBoxMember> AddItems(
    System.Collections.Generic.IList<Autodesk.Revit.UI.ComboBoxMemberData> memberData
  ) => throw new System.NotImplementedException();

  public virtual void AddSeparator() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.UI.ComboBoxMember> GetItems() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.UI.ComboBoxMember Current
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

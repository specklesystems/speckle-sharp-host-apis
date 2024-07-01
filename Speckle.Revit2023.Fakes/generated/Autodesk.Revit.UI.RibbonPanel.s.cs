namespace Autodesk.Revit.UI;

public partial class RibbonPanel
{
  public virtual System.Collections.Generic.IList<Autodesk.Revit.UI.RibbonItem> GetItems() =>
    throw new System.NotImplementedException();

  public virtual void AddSeparator() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.UI.RibbonItem AddItem(Autodesk.Revit.UI.RibbonItemData itemData) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.UI.RibbonItem> AddStackedItems(
    Autodesk.Revit.UI.RibbonItemData item1,
    Autodesk.Revit.UI.RibbonItemData item2,
    Autodesk.Revit.UI.RibbonItemData item3
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.UI.RibbonItem> AddStackedItems(
    Autodesk.Revit.UI.RibbonItemData item1,
    Autodesk.Revit.UI.RibbonItemData item2
  ) => throw new System.NotImplementedException();

  public virtual void AddSlideOut() => throw new System.NotImplementedException();

  public virtual System.Boolean Enabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Visible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Title
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Autodesk.Revit.UI;

public partial class RibbonItem
{
  public RibbonItem() { }

  public virtual Autodesk.Revit.UI.ContextualHelp GetContextualHelp() => throw new System.NotImplementedException();

  public virtual void SetContextualHelp(Autodesk.Revit.UI.ContextualHelp contextualHelp) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.UI.RibbonItemType ItemType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Visible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean Enabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String LongDescription
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ToolTip
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String ItemText
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
  }
}

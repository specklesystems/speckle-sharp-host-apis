namespace Autodesk.Revit.UI;

public partial class RibbonItemData
{
  public virtual Autodesk.Revit.UI.ContextualHelp GetContextualHelp() => throw new System.NotImplementedException();

  public virtual void SetContextualHelp(Autodesk.Revit.UI.ContextualHelp contextualHelp) =>
    throw new System.NotImplementedException();

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
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

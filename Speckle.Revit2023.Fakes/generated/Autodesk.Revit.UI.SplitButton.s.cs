namespace Autodesk.Revit.UI;

public partial class SplitButton : Autodesk.Revit.UI.PulldownButton
{
  public virtual Autodesk.Revit.UI.PushButton CurrentButton
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsSynchronizedWithCurrentItem
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

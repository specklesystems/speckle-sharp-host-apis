namespace Autodesk.Revit.UI;

public partial class DoubleClickOptions : System.IDisposable
{
  public DoubleClickOptions() { }

  public static Autodesk.Revit.UI.DoubleClickOptions GetDoubleClickOptions() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetRenameOnSlowDoubleClickInProjectBrowser() =>
    throw new System.NotImplementedException();

  public virtual void SetRenameOnSlowDoubleClickInProjectBrowser(
    System.Boolean bRenameOnSlowDoubleClickInProjectBrowser
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.UI.DoubleClickAction GetAction(Autodesk.Revit.UI.DoubleClickTarget target) =>
    throw new System.NotImplementedException();

  public virtual void SetAction(
    Autodesk.Revit.UI.DoubleClickTarget target,
    Autodesk.Revit.UI.DoubleClickAction action
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsSupportedAction(
    Autodesk.Revit.UI.DoubleClickTarget target,
    Autodesk.Revit.UI.DoubleClickAction action
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

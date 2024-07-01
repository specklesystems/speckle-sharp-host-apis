namespace Autodesk.Revit.DB;

public partial class StartingViewSettings : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.StartingViewSettings GetStartingViewSettings(Autodesk.Revit.DB.Document doc) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsAcceptableStartingView(Autodesk.Revit.DB.ElementId viewId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId ViewId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

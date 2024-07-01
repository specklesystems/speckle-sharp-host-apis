namespace Autodesk.Revit.DB;

public partial class LinkLoadContent : Autodesk.Revit.DB.ExternalResourceLoadContent
{
  public LinkLoadContent() { }

  public virtual Autodesk.Revit.DB.ModelPath GetLinkDataPath() => throw new System.NotImplementedException();

  public virtual void SetLinkDataPath(Autodesk.Revit.DB.ModelPath linkPath) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.LinkLoadResult GetLinkLoadResult() => throw new System.NotImplementedException();
}

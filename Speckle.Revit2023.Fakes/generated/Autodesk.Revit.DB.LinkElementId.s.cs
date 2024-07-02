namespace Autodesk.Revit.DB;

public partial class LinkElementId
{
  public LinkElementId() { }

  public LinkElementId(Autodesk.Revit.DB.ElementId linkInstanceId, Autodesk.Revit.DB.ElementId elementId) =>
    throw new System.NotImplementedException();

  public LinkElementId(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId HostElementId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId LinkedElementId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId LinkInstanceId
  {
    get => throw new System.NotImplementedException();
  }
}

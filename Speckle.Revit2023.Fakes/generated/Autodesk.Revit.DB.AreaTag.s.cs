namespace Autodesk.Revit.DB;

public partial class AreaTag : Autodesk.Revit.DB.SpatialElementTag
{
  public AreaTag() { }

  public virtual Autodesk.Revit.DB.AreaTagType AreaTagType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Area Area
  {
    get => throw new System.NotImplementedException();
  }
}

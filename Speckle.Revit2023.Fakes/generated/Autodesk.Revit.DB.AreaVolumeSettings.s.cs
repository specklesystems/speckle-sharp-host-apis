namespace Autodesk.Revit.DB;

public partial class AreaVolumeSettings : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.AreaVolumeSettings GetAreaVolumeSettings(Autodesk.Revit.DB.Document aDoc) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.SpatialElementBoundaryLocation GetSpatialElementBoundaryLocation(
    Autodesk.Revit.DB.SpatialElementType spType
  ) => throw new System.NotImplementedException();

  public virtual void SetSpatialElementBoundaryLocation(
    Autodesk.Revit.DB.SpatialElementBoundaryLocation spatialElementBoundaryLocation,
    Autodesk.Revit.DB.SpatialElementType spType
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean ComputeVolumes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

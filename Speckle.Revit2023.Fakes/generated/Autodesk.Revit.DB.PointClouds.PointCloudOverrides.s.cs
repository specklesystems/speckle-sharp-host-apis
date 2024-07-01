namespace Autodesk.Revit.DB.PointClouds;

public partial class PointCloudOverrides : System.IDisposable
{
  public PointCloudOverrides() => throw new System.NotImplementedException();

  public virtual System.Boolean IsEqual(Autodesk.Revit.DB.PointClouds.PointCloudOverrides other) =>
    throw new System.NotImplementedException();

  public virtual void Assign(Autodesk.Revit.DB.PointClouds.PointCloudOverrides other) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings GetPointCloudScanOverrideSettings(
    Autodesk.Revit.DB.ElementId elementId,
    System.String scanTag,
    Autodesk.Revit.DB.Document doc
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings GetPointCloudScanOverrideSettings(
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings GetPointCloudRegionOverrideSettings(
    Autodesk.Revit.DB.ElementId elementId,
    System.String regionTag,
    Autodesk.Revit.DB.Document doc
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings GetPointCloudRegionOverrideSettings(
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public virtual void SetPointCloudScanOverrideSettings(
    Autodesk.Revit.DB.ElementId elementId,
    Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings newSettings,
    System.String scanTag,
    Autodesk.Revit.DB.Document doc
  ) => throw new System.NotImplementedException();

  public virtual void SetPointCloudScanOverrideSettings(
    Autodesk.Revit.DB.ElementId elementId,
    Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings newSettings
  ) => throw new System.NotImplementedException();

  public virtual void SetPointCloudRegionOverrideSettings(
    Autodesk.Revit.DB.ElementId elementId,
    Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings newSettings,
    System.String regionTag,
    Autodesk.Revit.DB.Document doc
  ) => throw new System.NotImplementedException();

  public virtual void SetPointCloudRegionOverrideSettings(
    Autodesk.Revit.DB.ElementId elementId,
    Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings newSettings
  ) => throw new System.NotImplementedException();

  public static System.Boolean ArePointCloudOverrideSettingsValid(
    System.String tag,
    Autodesk.Revit.DB.PointClouds.PointCloudOverrideSettings settings
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

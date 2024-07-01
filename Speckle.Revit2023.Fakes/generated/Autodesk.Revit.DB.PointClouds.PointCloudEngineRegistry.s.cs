namespace Autodesk.Revit.DB.PointClouds;

public partial class PointCloudEngineRegistry
{
  public PointCloudEngineRegistry() { }

  public static void RegisterPointCloudEngine(
    System.String identifier,
    Autodesk.Revit.DB.PointClouds.IPointCloudEngine engine,
    System.Boolean isFileBased
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<System.String> GetSupportedEngines() =>
    throw new System.NotImplementedException();

  public static System.Boolean IsEngineFileBased(System.String identifier) =>
    throw new System.NotImplementedException();

  public static void UnregisterPointCloudEngine(System.String identifier) => throw new System.NotImplementedException();
}

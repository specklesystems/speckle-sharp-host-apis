namespace Autodesk.Revit.DB.PointClouds;

public partial interface IPointCloudEngine
{
	public  Autodesk.Revit.DB.PointClouds.IPointCloudAccess CreatePointCloudAccess(System.String identifier);
	public  void Free();
}

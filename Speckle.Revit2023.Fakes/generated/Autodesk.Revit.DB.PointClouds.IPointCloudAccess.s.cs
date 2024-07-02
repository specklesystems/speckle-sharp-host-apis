namespace Autodesk.Revit.DB.PointClouds;

public partial interface IPointCloudAccess
{
	public  System.Double GetUnitsToFeetConversionFactor();
	public  Autodesk.Revit.DB.PointClouds.IPointSetIterator CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter rFilter,System.Double density,Autodesk.Revit.DB.ElementId viewId);
	public  Autodesk.Revit.DB.PointClouds.IPointSetIterator CreatePointSetIterator(Autodesk.Revit.DB.PointClouds.PointCloudFilter rFilter,Autodesk.Revit.DB.ElementId viewId);
	public  System.Int32 ReadPoints(Autodesk.Revit.DB.PointClouds.PointCloudFilter rFilter,Autodesk.Revit.DB.ElementId viewId,System.IntPtr buffer,System.Int32 nBufferSize);
	public  Autodesk.Revit.DB.XYZ GetOffset();
	public  Autodesk.Revit.DB.Outline GetExtent();
	public  System.String GetName();
	public  Autodesk.Revit.DB.PointClouds.PointCloudColorEncoding GetColorEncoding();
	public  void Free();
}

namespace Autodesk.Revit.DB.PointClouds;

public partial interface IPointSetIterator
{
  public void Free();
  public System.Int32 ReadPoints(System.IntPtr buffer, System.Int32 bufferSize);
}

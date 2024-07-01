namespace Autodesk.Revit.DB.PointClouds;

public partial class PointCloudFilter : System.IDisposable
{
	public virtual System.Boolean TestPoint(Autodesk.Revit.DB.PointClouds.CloudPoint point) => throw new System.NotImplementedException();
	public virtual System.Int32 TestCell(Autodesk.Revit.DB.XYZ min,Autodesk.Revit.DB.XYZ max) => throw new System.NotImplementedException();
	public virtual void PrepareForCell(Autodesk.Revit.DB.XYZ min,Autodesk.Revit.DB.XYZ max,System.Int32 numTests) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PointClouds.PointCloudFilter Clone() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}

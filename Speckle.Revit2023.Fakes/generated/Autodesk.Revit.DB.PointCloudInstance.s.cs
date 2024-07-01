namespace Autodesk.Revit.DB;

public partial class PointCloudInstance : Autodesk.Revit.DB.Instance
{
	public virtual System.Boolean HasColor() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<System.String> GetScans() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetScanOrigin(System.String scanName) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<System.String> GetRegions() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PointClouds.PointCloudFilter GetSelectionFilter() => throw new System.NotImplementedException();
	public virtual void SetSelectionFilter(Autodesk.Revit.DB.PointClouds.PointCloudFilter pFilter) => throw new System.NotImplementedException();
	public virtual System.Boolean ContainsScan(System.String scanName) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.PointCloudInstance Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId typeId,Autodesk.Revit.DB.Transform transform) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PointClouds.PointCollection GetPoints(Autodesk.Revit.DB.PointClouds.PointCloudFilter filter,System.Double averageDistance,System.Int32 numPoints) => throw new System.NotImplementedException();
	public virtual System.Boolean SupportsOverrides
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.SelectionFilterAction FilterAction
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

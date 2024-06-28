namespace Autodesk.Revit.DB;

public partial class PointCloudType : Autodesk.Revit.DB.ElementType
{
	public virtual Autodesk.Revit.DB.ModelPath GetPath() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PointCloudFoundStatus FoundStatus
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Offset
	{
		get => throw new System.NotImplementedException();
	}
}

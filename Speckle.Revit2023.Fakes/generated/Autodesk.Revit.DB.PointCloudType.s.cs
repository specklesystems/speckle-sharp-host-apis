namespace Autodesk.Revit.DB;

public partial class PointCloudType : Autodesk.Revit.DB.ElementType
{
	public static Autodesk.Revit.DB.PointCloudType Create(Autodesk.Revit.DB.Document document,System.String engineIdentifier,System.String typeIdentifier) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ModelPath GetPath() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PointCloudFoundStatus FoundStatus
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PointClouds.PointCloudColorEncoding ColorEncoding
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Offset
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Scale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String EngineIdentifier
	{
		get => throw new System.NotImplementedException();
	}
}

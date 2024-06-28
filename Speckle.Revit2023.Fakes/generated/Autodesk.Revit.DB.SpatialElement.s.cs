namespace Autodesk.Revit.DB;

public partial class SpatialElement : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.SpatialElementDomainData GetSpatialElementDomainData() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SpatialElementType SpatialElementType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Level Level
	{
		get => throw new System.NotImplementedException();
	}
}

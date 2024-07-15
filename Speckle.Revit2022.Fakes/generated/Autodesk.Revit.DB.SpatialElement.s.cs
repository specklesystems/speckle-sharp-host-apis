namespace Autodesk.Revit.DB;

public partial class SpatialElement : Autodesk.Revit.DB.Element
{
	public SpatialElement() {}
	public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<Autodesk.Revit.DB.BoundarySegment>> GetBoundarySegments(Autodesk.Revit.DB.SpatialElementBoundaryOptions options) => throw new System.NotImplementedException();
	public virtual System.Double Perimeter
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Area
	{
		get => throw new System.NotImplementedException();
	}
	public override Autodesk.Revit.DB.Location Location
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Number
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Level Level
	{
		get => throw new System.NotImplementedException();
	}
	public override System.String Name
	{
		set {}
	}
}

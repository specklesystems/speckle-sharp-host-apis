namespace Autodesk.Revit.DB;

public partial class HostedSweep : Autodesk.Revit.DB.HostObject
{
	public virtual void HorizontalFlip() => throw new System.NotImplementedException();
	public virtual void VerticalFlip() => throw new System.NotImplementedException();
	public virtual void RemoveSegment(Autodesk.Revit.DB.Reference targetRef) => throw new System.NotImplementedException();
	public virtual System.Boolean SetEndPointParameter(Autodesk.Revit.DB.Reference targetRef,System.Int32 endIdx,System.Double param) => throw new System.NotImplementedException();
	public virtual System.Double GetEndPointParameter(Autodesk.Revit.DB.Reference targetRef,System.Int32 endIdx) => throw new System.NotImplementedException();
	public virtual void AddSegment(Autodesk.Revit.DB.Reference targetRef) => throw new System.NotImplementedException();
	public virtual System.Boolean VerticalFlipped
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean HorizontalFlipped
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Angle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double VerticalOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double HorizontalOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Length
	{
		get => throw new System.NotImplementedException();
	}
}

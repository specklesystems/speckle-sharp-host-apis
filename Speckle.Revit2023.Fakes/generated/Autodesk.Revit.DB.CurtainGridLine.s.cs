namespace Autodesk.Revit.DB;

public partial class CurtainGridLine : Autodesk.Revit.DB.HostObject
{
	public virtual void RemoveSegment(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual void AddSegment(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual void AddAllSegments() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementSet AddMullions(Autodesk.Revit.DB.Curve segment,Autodesk.Revit.DB.MullionType mullionType,System.Boolean oneSegmentOnly) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveArray ExistingSegmentCurves
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.CurveArray SkippedSegmentCurves
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.CurveArray AllSegmentCurves
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Curve FullCurve
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsUGridLine
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Lock
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

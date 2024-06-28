namespace Autodesk.Revit.DB;

public partial class CurtainGridLine : Autodesk.Revit.DB.HostObject
{
	public virtual Autodesk.Revit.DB.Curve get_FullCurve() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveArray get_AllSegmentCurves() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveArray get_SkippedSegmentCurves() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveArray get_ExistingSegmentCurves() => throw new System.NotImplementedException();
	public virtual void RemoveSegment(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual void AddSegment(Autodesk.Revit.DB.Curve curve) => throw new System.NotImplementedException();
	public virtual void AddAllSegments() => throw new System.NotImplementedException();
}

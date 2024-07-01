namespace Autodesk.Revit.DB;

public partial class FillGrid : System.IDisposable
{
	public FillGrid(System.Double angle,System.Double offset) => throw new System.NotImplementedException();
	public FillGrid(Autodesk.Revit.DB.FillGrid other) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<System.Double> GetSegments() => throw new System.NotImplementedException();
	public virtual void SetSegments(System.Collections.Generic.IList<System.Double> segArr) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEqual(Autodesk.Revit.DB.FillGrid other) => throw new System.NotImplementedException();
	public virtual System.Double CalculateLengthPerArea() => throw new System.NotImplementedException();
	public virtual System.Double CalculateStrokesPerArea() => throw new System.NotImplementedException();
	public virtual System.Double CalculateLinesPerLength() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV GetHatchingDirection() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.UV GetSegmentDirection() => throw new System.NotImplementedException();
	public virtual System.Int32 GetPointLineZone(Autodesk.Revit.DB.UV point) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Shift
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Offset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.UV Origin
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Angle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

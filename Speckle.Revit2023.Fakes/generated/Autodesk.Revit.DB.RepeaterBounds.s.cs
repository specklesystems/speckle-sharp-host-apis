namespace Autodesk.Revit.DB;

public partial class RepeaterBounds : System.IDisposable
{
	public virtual System.Int32 GetLowerBound(System.Int32 dimension) => throw new System.NotImplementedException();
	public virtual System.Int32 GetUpperBound(System.Int32 dimension) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCyclical(System.Int32 dimension) => throw new System.NotImplementedException();
	public virtual System.Boolean AreCoordinatesInBounds(Autodesk.Revit.DB.RepeaterCoordinates coordinates,System.Boolean treatCyclicalBoundsAsInfinite) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RepeaterCoordinates AdjustForCyclicalBounds(Autodesk.Revit.DB.RepeaterCoordinates coordinates) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 DimensionCount
	{
		get => throw new System.NotImplementedException();
	}
}

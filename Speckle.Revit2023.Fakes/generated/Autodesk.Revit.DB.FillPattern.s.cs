namespace Autodesk.Revit.DB;

public partial class FillPattern : System.IDisposable
{
	public FillPattern(System.String name,Autodesk.Revit.DB.FillPatternTarget target,Autodesk.Revit.DB.FillPatternHostOrientation orientation,System.Double angle,System.Double spacing1,System.Double spacing2) => throw new System.NotImplementedException();
	public FillPattern(System.String name,Autodesk.Revit.DB.FillPatternTarget target,Autodesk.Revit.DB.FillPatternHostOrientation orientation,System.Double angle,System.Double spacing1) => throw new System.NotImplementedException();
	public FillPattern(System.String name,Autodesk.Revit.DB.FillPatternTarget target,Autodesk.Revit.DB.FillPatternHostOrientation orientation) => throw new System.NotImplementedException();
	public FillPattern(Autodesk.Revit.DB.FillPattern other) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FillGrid GetFillGrid(System.Int32 gridIdx) => throw new System.NotImplementedException();
	public virtual void SetFillGrid(System.Int32 gridIdx,Autodesk.Revit.DB.FillGrid fillGrid) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.FillGrid> GetFillGrids() => throw new System.NotImplementedException();
	public virtual void SetFillGrids(IList<Autodesk.Revit.DB.FillGrid> fillGrids) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEqual(Autodesk.Revit.DB.FillPattern other) => throw new System.NotImplementedException();
	public virtual System.Boolean ExpandDots() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Name
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LinesPerLength
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double StrokesPerArea
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double LengthPerArea
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSolidFill
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 GridCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FillPatternTarget Target
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.FillPatternHostOrientation HostOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

namespace Autodesk.Revit.DB;

public partial class Dimension : Autodesk.Revit.DB.Element
{
	public virtual void ResetTextPosition() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ TextPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ Origin
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ LeaderEndPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DimensionSegmentArray Segments
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.DimensionShape DimensionShape
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FamilyParameter FamilyLabel
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DimensionType DimensionType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.View View
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Curve Curve
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ReferenceArray References
	{
		get => throw new System.NotImplementedException();
	}
}

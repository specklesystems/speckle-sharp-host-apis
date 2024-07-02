namespace Autodesk.Revit.DB;

public partial class ViewCropRegionShapeManager : System.IDisposable
{
	public ViewCropRegionShapeManager() {}
	public virtual System.Boolean IsCropRegionShapeValid(Autodesk.Revit.DB.CurveLoop boundary) => throw new System.NotImplementedException();
	public virtual void SetCropShape(Autodesk.Revit.DB.CurveLoop boundary) => throw new System.NotImplementedException();
	public virtual void RemoveCropRegionShape() => throw new System.NotImplementedException();
	public virtual void RemoveSplit() => throw new System.NotImplementedException();
	public virtual void RemoveSplitRegion(System.Int32 regionIndex) => throw new System.NotImplementedException();
	public virtual void SplitRegionVertically(System.Int32 regionIndex,System.Double topPart,System.Double bottomPart) => throw new System.NotImplementedException();
	public virtual void SplitRegionHorizontally(System.Int32 regionIndex,System.Double leftPart,System.Double rightPart) => throw new System.NotImplementedException();
	public virtual System.Double GetSplitRegionMinimum(System.Int32 regionIndex) => throw new System.NotImplementedException();
	public virtual System.Double GetSplitRegionMaximum(System.Int32 regionIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetSplitRegionOffset(System.Int32 regionIndex) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> GetCropShape() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurveLoop GetAnnotationCropShape() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double RightAnnotationCropOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LeftAnnotationCropOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double BottomAnnotationCropOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TopAnnotationCropOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean CanHaveAnnotationCrop
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSplitVertically
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSplitHorizontally
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NumberOfSplitRegions
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ShapeSet
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Split
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CanBeSplit
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CanHaveShape
	{
		get => throw new System.NotImplementedException();
	}
}

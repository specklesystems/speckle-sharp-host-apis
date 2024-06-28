namespace Autodesk.Revit.DB;

public partial class ViewShapeBuilder : Autodesk.Revit.DB.ShapeBuilder
{
	public virtual void Reset() => throw new System.NotImplementedException();
	public virtual void AddCurve(Autodesk.Revit.DB.Curve GCurve) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DirectShapeTargetViewType ViewType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ ViewNormal
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

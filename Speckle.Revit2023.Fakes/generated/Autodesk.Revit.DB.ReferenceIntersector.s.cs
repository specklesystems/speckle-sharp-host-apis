namespace Autodesk.Revit.DB;

public partial class ReferenceIntersector : System.Object
{
	public virtual Autodesk.Revit.DB.ReferenceWithContext FindNearest(Autodesk.Revit.DB.XYZ origin,Autodesk.Revit.DB.XYZ direction) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementFilter GetFilter() => throw new System.NotImplementedException();
	public virtual void SetFilter(Autodesk.Revit.DB.ElementFilter filter) => throw new System.NotImplementedException();
		public virtual Autodesk.Revit.DB.FindReferenceTarget TargetType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ViewId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

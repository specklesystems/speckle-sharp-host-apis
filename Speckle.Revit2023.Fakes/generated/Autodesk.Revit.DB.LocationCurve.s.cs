namespace Autodesk.Revit.DB;

public partial class LocationCurve : Autodesk.Revit.DB.Location
{
	public virtual Autodesk.Revit.DB.ElementArray get_ElementsAtJoin(System.Int32 end) => throw new System.NotImplementedException();
	public virtual void set_ElementsAtJoin(System.Int32 end,Autodesk.Revit.DB.ElementArray elements) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.JoinType get_JoinType(System.Int32 end) => throw new System.NotImplementedException();
	public virtual void set_JoinType(System.Int32 end,Autodesk.Revit.DB.JoinType newType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve Curve
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

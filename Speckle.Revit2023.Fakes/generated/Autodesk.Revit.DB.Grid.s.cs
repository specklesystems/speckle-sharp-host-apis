namespace Autodesk.Revit.DB;

public partial class Grid : Autodesk.Revit.DB.DatumPlane
{
	public virtual Autodesk.Revit.DB.Curve get_Curve() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Outline GetExtents() => throw new System.NotImplementedException();
}

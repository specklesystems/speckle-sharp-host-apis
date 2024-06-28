namespace Autodesk.Revit.DB;

public partial class RuledSurface : Autodesk.Revit.DB.Surface
{
	public virtual Autodesk.Revit.DB.Curve GetFirstProfileCurve() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetFirstProfilePoint() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve GetSecondProfileCurve() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetSecondProfilePoint() => throw new System.NotImplementedException();
}

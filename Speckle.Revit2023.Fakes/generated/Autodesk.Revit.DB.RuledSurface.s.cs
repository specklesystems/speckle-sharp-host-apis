namespace Autodesk.Revit.DB;

public partial class RuledSurface : Autodesk.Revit.DB.Surface
{
	public static Autodesk.Revit.DB.Surface Create(Autodesk.Revit.DB.Curve profileCurve,Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Surface Create(Autodesk.Revit.DB.Curve profileCurve1,Autodesk.Revit.DB.Curve profileCurve2) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve GetFirstProfileCurve() => throw new System.NotImplementedException();
	public virtual System.Boolean HasFirstProfilePoint() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetFirstProfilePoint() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve GetSecondProfileCurve() => throw new System.NotImplementedException();
	public virtual System.Boolean HasSecondProfilePoint() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetSecondProfilePoint() => throw new System.NotImplementedException();
}

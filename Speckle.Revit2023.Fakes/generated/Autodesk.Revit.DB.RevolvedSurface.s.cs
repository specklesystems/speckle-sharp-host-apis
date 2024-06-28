namespace Autodesk.Revit.DB;

public partial class RevolvedSurface : Autodesk.Revit.DB.Surface
{
	public virtual Autodesk.Revit.DB.XYZ get_Axis() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_XDir() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_YDir() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ get_Origin() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve GetProfileCurve() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve GetProfileCurveInWorldCoordinates() => throw new System.NotImplementedException();
}

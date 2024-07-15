namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalPanel : Autodesk.Revit.DB.Structure.AnalyticalSurfaceBase
{
	public AnalyticalPanel() {}
	public static Autodesk.Revit.DB.Structure.AnalyticalPanel Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Curve profile,Autodesk.Revit.DB.XYZ normal) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.AnalyticalPanel Create(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.CurveLoop curveLoop) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAnalyticalOpeningsIds() => throw new System.NotImplementedException();
	public virtual System.Double Thickness
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

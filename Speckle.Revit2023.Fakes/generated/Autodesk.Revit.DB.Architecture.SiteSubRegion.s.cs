namespace Autodesk.Revit.DB.Architecture;

public partial class SiteSubRegion : System.Object
{
	public static Autodesk.Revit.DB.Architecture.SiteSubRegion Create(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.CurveLoop> curveLoops,Autodesk.Revit.DB.ElementId hostTopoSurfaceId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Architecture.SiteSubRegion Create(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.CurveLoop> curveLoops) => throw new System.NotImplementedException();
	public static System.Boolean IsValidBoundary(IList<Autodesk.Revit.DB.CurveLoop> curveLoops) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.CurveLoop> GetBoundary() => throw new System.NotImplementedException();
	public virtual void SetBoundary(IList<Autodesk.Revit.DB.CurveLoop> curveLoops) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId HostId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Architecture.TopographySurface TopographySurface
	{
		get => throw new System.NotImplementedException();
	}
}

namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalModelSurface : Autodesk.Revit.DB.Structure.AnalyticalModel
{
	public AnalyticalModelSurface() {}
	public virtual System.Boolean IsPlanar() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Plane GetPlane() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidOpeningForHide(Autodesk.Revit.DB.ElementId openingId) => throw new System.NotImplementedException();
	public virtual void GetHiddenOpenings(out System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> openingsIds) => throw new System.NotImplementedException();
	public virtual void GetOpenings(out System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> openingsIds) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> GetOpeningLoops(Autodesk.Revit.DB.ElementId openingId) => throw new System.NotImplementedException();
	public virtual System.Boolean HasOpenings() => throw new System.NotImplementedException();
	public virtual System.Boolean HideOpening(Autodesk.Revit.DB.ElementId openingId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsOpeningHidden(Autodesk.Revit.DB.ElementId openingId) => throw new System.NotImplementedException();
	public virtual System.Boolean ShowOpening(Autodesk.Revit.DB.ElementId openingId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> GetLoops(Autodesk.Revit.DB.Structure.AnalyticalLoopType loopType) => throw new System.NotImplementedException();
	public virtual System.Boolean SetLoops(Autodesk.Revit.DB.Structure.AnalyticalLoopType loopType,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> newLoops) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetLocalCoordinateSystem(Autodesk.Revit.DB.XYZ point) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId TopExtensionPlaneId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId BottomExtensionPlaneId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.SurfaceElementExtension TopExtension
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.SurfaceElementExtension BottomExtension
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod BottomExtensionMethod
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod TopExtensionMethod
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HasExtension
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId ProjectionPlaneZ
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.SurfaceElementProjectionZ ProjectionZ
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.AnalyticalAlignmentMethod AlignmentMethod
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

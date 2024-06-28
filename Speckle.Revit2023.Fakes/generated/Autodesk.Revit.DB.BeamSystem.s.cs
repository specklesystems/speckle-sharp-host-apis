namespace Autodesk.Revit.DB;

public partial class BeamSystem : Autodesk.Revit.DB.Element
{
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetBeamIds() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.BeamSystem BeamBelongsTo(Autodesk.Revit.DB.FamilyInstance beam) => throw new System.NotImplementedException();
	public static void DropBeamSystem(Autodesk.Revit.DB.BeamSystem beamSystem) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.BeamSystem Create(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.Curve> profile,Autodesk.Revit.DB.Level level,System.Int32 curveIndexForDirection,System.Boolean is3d) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.BeamSystem Create(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.Curve> profile,Autodesk.Revit.DB.Level level,Autodesk.Revit.DB.XYZ direction,System.Boolean is3d) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.BeamSystem Create(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.Curve> profile,Autodesk.Revit.DB.SketchPlane sketchPlane,Autodesk.Revit.DB.XYZ direction,System.Boolean is3d) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.BeamSystem Create(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.Curve> profile,Autodesk.Revit.DB.SketchPlane sketchPlane,System.Int32 curveIndexForDirection) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ Direction
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.LayoutRule LayoutRule
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.CurveArray Profile
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.BeamSystemType BeamSystemType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.FamilySymbol BeamType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Level Level
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Elevation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

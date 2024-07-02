namespace Autodesk.Revit.DB.Structure;

public partial class FabricArea : Autodesk.Revit.DB.Element
{
	public FabricArea() {}
	public static Autodesk.Revit.DB.Structure.FabricArea Create(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.Element hostElement,Autodesk.Revit.DB.XYZ majorDirection,Autodesk.Revit.DB.ElementId fabricAreaTypeId,Autodesk.Revit.DB.ElementId fabricSheetTypeId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.FabricArea Create(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.Element hostElement,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> curveLoops,Autodesk.Revit.DB.XYZ majorDirection,Autodesk.Revit.DB.XYZ majorDirectionOrigin,Autodesk.Revit.DB.ElementId fabricAreaTypeId,Autodesk.Revit.DB.ElementId fabricSheetTypeId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetValidViewsForTags() => throw new System.NotImplementedException();
	public virtual System.Double GetTotalSheetMass() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> CopyCurveLoopsInSketch() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetBoundaryCurveIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetFabricSheetElementIds() => throw new System.NotImplementedException();
	public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> RemoveFabricReinforcementSystem(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.FabricArea system) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.FabricRoundingManager GetReinforcementRoundingManager() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidMajorLapSplice(System.Double majorLapSplice) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidMinorLapSplice(System.Double minorLapSplice) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCoverOffsetValid(System.Double coverOffset) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.FabricLocation FabricLocation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId FabricSheetTypeId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.FabricSheetAlignment MinorSheetAlignment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.FabricSheetAlignment MajorSheetAlignment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ DirectionOrigin
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Direction
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.FabricAreaType FabricAreaType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId TagViewId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double CoverOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double MinorLapSpliceLength
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double MajorLapSpliceLength
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.FabricLapSplicePosition LapSplicePosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId SketchId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId HostId
	{
		get => throw new System.NotImplementedException();
	}
}

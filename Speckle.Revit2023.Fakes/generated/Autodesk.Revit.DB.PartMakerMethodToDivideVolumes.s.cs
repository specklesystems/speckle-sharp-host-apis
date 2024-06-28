namespace Autodesk.Revit.DB;

public partial class PartMakerMethodToDivideVolumes : System.Object
{
	public virtual Autodesk.Revit.DB.Plane GetPlaneOfSketch() => throw new System.NotImplementedException();
	public virtual IDictionary<Autodesk.Revit.DB.ElementId, System.Double> GetSplitRefsOffsets() => throw new System.NotImplementedException();
	public static System.Boolean IsElementValidIntersectingReference(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsElementValidIntersectingReference(Autodesk.Revit.DB.ElementId elementId) => throw new System.NotImplementedException();
	public static System.Boolean AreElementsValidIntersectingReferences(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public virtual System.Boolean AreElementsValidIntersectingReferences(ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public static System.Boolean IsValidSketchPlane(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId sketchPlaneId) => throw new System.NotImplementedException();
	public virtual System.Boolean UsesReference(Autodesk.Revit.DB.ElementId intersectingReference) => throw new System.NotImplementedException();
	public virtual void SetOffsetForIntersectingReference(Autodesk.Revit.DB.ElementId intersectingReference,System.Double offset) => throw new System.NotImplementedException();
	public virtual System.Double GetOffsetForIntersectingReference(Autodesk.Revit.DB.ElementId intersectingReference) => throw new System.NotImplementedException();
	public virtual System.Boolean AddIntersectingReference(Autodesk.Revit.DB.ElementId intersectingReference,System.Double offset) => throw new System.NotImplementedException();
	public virtual System.Boolean RemoveIntersectingReference(Autodesk.Revit.DB.ElementId intersectingReference) => throw new System.NotImplementedException();
	public virtual System.Boolean CanBeDivisionProfile(Autodesk.Revit.DB.ElementId familyId) => throw new System.NotImplementedException();
	public static System.Boolean CanBeDivisionProfile(Autodesk.Revit.DB.ElementId familyId,Autodesk.Revit.DB.Document familyDocument) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean DivisionPatternMirror
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double DivisionRotationAngle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 VConstDivisionIndent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 UConstDivisionIndent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId DivisionRuleId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ProfileFlipAlong
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ProfileFlipAcross
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId ProfileType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ProfileOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double DivisionGap
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.PartEdgeConditionOrientation ProfileMatch
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

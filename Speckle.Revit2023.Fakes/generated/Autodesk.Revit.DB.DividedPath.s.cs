namespace Autodesk.Revit.DB;

public partial class DividedPath : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.DividedPath Create(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.Reference> curveReferences,ICollection<Autodesk.Revit.DB.ElementId> intersectors) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.DividedPath Create(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.Reference> curveReferences) => throw new System.NotImplementedException();
	public static IList<IList<Autodesk.Revit.DB.Reference>> SeparateReferencesIntoConnectedReferences(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.Reference> curveReferences) => throw new System.NotImplementedException();
	public static System.Boolean IsCurveReferenceValid(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Reference curveReference) => throw new System.NotImplementedException();
	public static System.Boolean AreCurveReferencesConnected(Autodesk.Revit.DB.Document document,IList<Autodesk.Revit.DB.Reference> curveReferences) => throw new System.NotImplementedException();
	public static System.Boolean IsIntersectorValidForCreation(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId intersector) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidSpacingRuleLayout(Autodesk.Revit.DB.SpacingRuleLayout layout) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidMeasurementType(Autodesk.Revit.DB.DividedPathMeasurementType measurementType) => throw new System.NotImplementedException();
	public static System.Boolean IsValidFixedNumberOfPoints(System.Int32 fixedNumberOfPoints) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidBeginningIndent(System.Double beginningIndent) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidEndIndent(System.Double endIndent) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidSpacingRuleJustification(Autodesk.Revit.DB.SpacingRuleJustification justification) => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetIntersectingElements() => throw new System.NotImplementedException();
	public virtual void SetIntersectingElements(ICollection<Autodesk.Revit.DB.ElementId> intersectors) => throw new System.NotImplementedException();
	public virtual System.Boolean IsIntersectorValidForDividedPath(Autodesk.Revit.DB.ElementId intersector) => throw new System.NotImplementedException();
	public virtual void Flip() => throw new System.NotImplementedException();
	public virtual System.Boolean DisplayReferenceCurves
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean Flipped
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NumberOfPoints
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.SpacingRuleJustification SpacingRuleJustification
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.SpacingRuleLayout SpacingRuleLayout
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsCyclical
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsClosedLoop
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TotalPathLength
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean DisplayNodeNumbers
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean DisplayNodes
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double EndIndent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double BeginningIndent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double MaximumDistance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double MinimumDistance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Distance
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 FixedNumberOfPoints
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.DividedPathMeasurementType MeasurementType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

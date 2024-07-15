namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalModel : Autodesk.Revit.DB.Element
{
	public AnalyticalModel() {}
	public virtual System.Boolean IsValidDirectionForAutoDetect(Autodesk.Revit.DB.Structure.AnalyticalDirection direction) => throw new System.NotImplementedException();
	public virtual System.Boolean CanDisableAutoDetect(Autodesk.Revit.DB.Structure.AnalyticalDirection direction) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSinglePoint() => throw new System.NotImplementedException();
	public virtual System.Boolean IsSingleCurve() => throw new System.NotImplementedException();
	public virtual System.Boolean CanUseHardPoints() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidSelector(Autodesk.Revit.DB.Structure.AnalyticalModelSelector selector) => throw new System.NotImplementedException();
	public virtual System.Boolean SupportsManualAdjustment() => throw new System.NotImplementedException();
	public virtual System.Boolean CanApproximate() => throw new System.NotImplementedException();
	public virtual System.Boolean IsAnalyzeAsValid(Autodesk.Revit.DB.Structure.AnalyzeAs analyzeAs) => throw new System.NotImplementedException();
	public virtual System.Boolean CanHaveRigidLinks() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidRigidLinksOption(Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption rigidLinksOption) => throw new System.NotImplementedException();
	public virtual System.Boolean HasDeletedLinks() => throw new System.NotImplementedException();
	public virtual void ResetLinks() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetLocalCoordinateSystem() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetCurves(Autodesk.Revit.DB.Structure.AnalyticalCurveType curveType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetPoint() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve GetCurve() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetReference(Autodesk.Revit.DB.Structure.AnalyticalModelSelector selector) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve GetRigidLink(Autodesk.Revit.DB.Structure.AnalyticalModelSelector selector) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.AnalyticalModelSketchComponent> GetAnalyticalModelSketchComponents() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.AnalyticalModelSupport> GetAnalyticalModelSupports() => throw new System.NotImplementedException();
	public virtual System.Boolean IsAutoDetectEnabled(Autodesk.Revit.DB.Structure.AnalyticalDirection direction) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetAutoDetectMatchedElements(Autodesk.Revit.DB.Structure.AnalyticalDirection direction) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidManualAdjustmentSource(Autodesk.Revit.DB.Reference source,Autodesk.Revit.DB.Structure.AnalyticalDirection adjustmentDirection) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidManualAdjustmentTarget(Autodesk.Revit.DB.Reference target,Autodesk.Revit.DB.Reference source,Autodesk.Revit.DB.Structure.AnalyticalDirection direction) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidForManualAdjustment(Autodesk.Revit.DB.Reference reference) => throw new System.NotImplementedException();
	public virtual System.Boolean ManuallyAdjust(Autodesk.Revit.DB.Reference source,Autodesk.Revit.DB.Reference target) => throw new System.NotImplementedException();
	public virtual System.Boolean ResetManualAdjustment() => throw new System.NotImplementedException();
	public virtual System.Boolean IsManuallyAdjusted() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetManualAdjustmentMatchedElements() => throw new System.NotImplementedException();
	public virtual System.Boolean IsElementFullySupported() => throw new System.NotImplementedException();
	public virtual System.Boolean UsesHardPoints() => throw new System.NotImplementedException();
	public virtual void SetUsesHardPoints(System.Boolean hardPoints) => throw new System.NotImplementedException();
	public virtual void EnableAutoDetect(Autodesk.Revit.DB.Structure.AnalyticalDirection direction,System.Boolean enabled) => throw new System.NotImplementedException();
	public virtual System.Boolean IsApproximated() => throw new System.NotImplementedException();
	public virtual void Approximate(System.Boolean enableApproximation) => throw new System.NotImplementedException();
	public virtual System.Double GetApproximationDeviation() => throw new System.NotImplementedException();
	public virtual void SetApproximationDeviation(System.Double deviation) => throw new System.NotImplementedException();
	public virtual System.Boolean IsEnabled() => throw new System.NotImplementedException();
	public virtual void Enable(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.AnalyzeAs GetAnalyzeAs() => throw new System.NotImplementedException();
	public virtual void SetAnalyzeAs(Autodesk.Revit.DB.Structure.AnalyzeAs analyzeAs) => throw new System.NotImplementedException();
	public virtual System.Boolean HasRigidLinksWith(Autodesk.Revit.DB.ElementId neighborId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetElementId() => throw new System.NotImplementedException();
	public virtual void SetOffset(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector,Autodesk.Revit.DB.XYZ offset) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetOffset(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector) => throw new System.NotImplementedException();
	public virtual void Disconnect(Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector) => throw new System.NotImplementedException();
	public virtual System.Boolean IsModified() => throw new System.NotImplementedException();
	public virtual void CloneAdjustment(Autodesk.Revit.DB.Structure.AnalyticalModel source,System.Int32 end) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.AnalyticalRigidLinksOption RigidLinksOption
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

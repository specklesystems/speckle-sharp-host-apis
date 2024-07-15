namespace Autodesk.Revit.DB.Structure;

public partial class Rebar : Autodesk.Revit.DB.Element
{
	public Rebar() {}
	public static Autodesk.Revit.DB.Structure.Rebar CreateFreeForm(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Element host,System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> curves,out Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult error) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.Rebar CreateFreeForm(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Element host,System.Collections.Generic.IList<System.Collections.Generic.IList<Autodesk.Revit.DB.Curve>> curves,out Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult error) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.Rebar CreateFreeForm(Autodesk.Revit.DB.Document doc,System.Guid serverGUID,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Element host) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.Rebar CreateFromCurves(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.RebarStyle style,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Structure.RebarHookType startHook,Autodesk.Revit.DB.Structure.RebarHookType endHook,Autodesk.Revit.DB.Element host,Autodesk.Revit.DB.XYZ norm,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient,System.Double hookRotationAngleAtStart,System.Double hookRotationAngleAtEnd,Autodesk.Revit.DB.ElementId endTreatmentTypeIdAtStart,Autodesk.Revit.DB.ElementId endTreatmentTypeIdAtEnd,System.Boolean useExistingShapeIfPossible,System.Boolean createNewShape) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.Rebar CreateFromCurves(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.RebarStyle style,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Structure.RebarHookType startHook,Autodesk.Revit.DB.Structure.RebarHookType endHook,Autodesk.Revit.DB.Element host,Autodesk.Revit.DB.XYZ norm,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient,System.Boolean useExistingShapeIfPossible,System.Boolean createNewShape) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.Rebar CreateFromRebarShape(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.RebarShape rebarShape,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Element host,Autodesk.Revit.DB.XYZ origin,Autodesk.Revit.DB.XYZ xVec,Autodesk.Revit.DB.XYZ yVec) => throw new System.NotImplementedException();
	public static System.Boolean RebarShapeMatchesCurvesAndHooks(Autodesk.Revit.DB.Structure.RebarShape rebarShape,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.XYZ norm,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,Autodesk.Revit.DB.Structure.RebarHookType startHook,Autodesk.Revit.DB.Structure.RebarHookType endHook,Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient) => throw new System.NotImplementedException();
	public static System.Boolean RebarShapeMatchesCurvesHooksAndEndTreatment(Autodesk.Revit.DB.Structure.RebarShape rebarShape,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.XYZ norm,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,Autodesk.Revit.DB.Structure.RebarHookType startHook,Autodesk.Revit.DB.Structure.RebarHookType endHook,Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient,System.Double hookRotationAngleAtStart,System.Double hookRotationAngleAtEnd,Autodesk.Revit.DB.ElementId endTreatmentTypeIdAtStart,Autodesk.Revit.DB.ElementId endTreatmentTypeIdAtEnd) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.Rebar CreateFromCurvesAndShape(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.RebarShape rebarShape,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Structure.RebarHookType startHook,Autodesk.Revit.DB.Structure.RebarHookType endHook,Autodesk.Revit.DB.Element host,Autodesk.Revit.DB.XYZ norm,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient,System.Double hookRotationAngleAtStart,System.Double hookRotationAngleAtEnd,Autodesk.Revit.DB.ElementId endTreatmentTypeIdAtStart,Autodesk.Revit.DB.ElementId endTreatmentTypeIdAtEnd) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.Rebar CreateFromCurvesAndShape(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.Structure.RebarShape rebarShape,Autodesk.Revit.DB.Structure.RebarBarType barType,Autodesk.Revit.DB.Structure.RebarHookType startHook,Autodesk.Revit.DB.Structure.RebarHookType endHook,Autodesk.Revit.DB.Element host,Autodesk.Revit.DB.XYZ norm,System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,Autodesk.Revit.DB.Structure.RebarHookOrientation startHookOrient,Autodesk.Revit.DB.Structure.RebarHookOrientation endHookOrient) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetCenterlineCurves(System.Boolean adjustForSelfIntersection,System.Boolean suppressHooks,System.Boolean suppressBendRadius,Autodesk.Revit.DB.Structure.MultiplanarOption multiplanarOption,System.Int32 barPositionIndex) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetTransformedCenterlineCurves(System.Boolean adjustForSelfIntersection,System.Boolean suppressHooks,System.Boolean suppressBendRadius,Autodesk.Revit.DB.Structure.MultiplanarOption multiplanarOption,System.Int32 barPositionIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarConstraintsManager GetRebarConstraintsManager() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarRoundingManager GetReinforcementRoundingManager() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetFullGeometryForView(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetHostId() => throw new System.NotImplementedException();
	public virtual void SetHostId(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.ElementId hostId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnobscuredInView(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual void SetUnobscuredInView(Autodesk.Revit.DB.View view,System.Boolean unobscured) => throw new System.NotImplementedException();
	public virtual System.Boolean IsSolidInView(Autodesk.Revit.DB.View3D view) => throw new System.NotImplementedException();
	public virtual void SetSolidInView(Autodesk.Revit.DB.View3D view,System.Boolean solid) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarBendData GetBendData() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetHookTypeId(System.Int32 end) => throw new System.NotImplementedException();
	public virtual void SetHookTypeId(System.Int32 end,Autodesk.Revit.DB.ElementId hookTypeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetEndTreatmentTypeId(System.Int32 end) => throw new System.NotImplementedException();
	public virtual void SetEndTreatmentTypeId(System.Int32 end,Autodesk.Revit.DB.ElementId endTreatmentTypeId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsRebarInSection(Autodesk.Revit.DB.View dBView) => throw new System.NotImplementedException();
	public virtual System.Boolean HasPresentationOverrides(Autodesk.Revit.DB.View dBView) => throw new System.NotImplementedException();
	public virtual void SetBarHiddenStatus(Autodesk.Revit.DB.View view,System.Int32 barIndex,System.Boolean hide) => throw new System.NotImplementedException();
	public virtual System.Boolean IsBarHidden(Autodesk.Revit.DB.View view,System.Int32 barIndex) => throw new System.NotImplementedException();
	public virtual void SetPresentationMode(Autodesk.Revit.DB.View dBView,Autodesk.Revit.DB.Structure.RebarPresentationMode presentationMode) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarPresentationMode GetPresentationMode(Autodesk.Revit.DB.View dBView) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarPresentationMode FindMatchingPredefinedPresentationMode(Autodesk.Revit.DB.View dBView) => throw new System.NotImplementedException();
	public virtual void ClearPresentationMode(Autodesk.Revit.DB.View dBView) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetShapeId() => throw new System.NotImplementedException();
	public virtual System.Boolean DoesBarExistAtPosition(System.Int32 barPosition) => throw new System.NotImplementedException();
	public virtual void SetBarIncluded(System.Boolean include,System.Int32 barPositionIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ParameterValue GetParameterValueAtIndex(Autodesk.Revit.DB.ElementId paramId,System.Int32 barPositionIndex) => throw new System.NotImplementedException();
	public static System.Boolean ContainsValidArcRadiiForStyleAndBarType(System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> curves,Autodesk.Revit.DB.Structure.RebarStyle style,Autodesk.Revit.DB.Structure.RebarBarType barType) => throw new System.NotImplementedException();
	public virtual System.Boolean HookAngleMatchesRebarShapeDefinition(System.Int32 iEnd,Autodesk.Revit.DB.ElementId proposedHookId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanUseHookType(Autodesk.Revit.DB.ElementId proposedHookId) => throw new System.NotImplementedException();
	public virtual System.Boolean ConstraintsCanBeEdited() => throw new System.NotImplementedException();
	public virtual System.Boolean CanApplyPresentationMode(Autodesk.Revit.DB.View dBView) => throw new System.NotImplementedException();
	public virtual System.Boolean CanSuppressFirstOrLastBar(Autodesk.Revit.DB.View dBView,System.Int32 end) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarHookOrientation GetHookOrientation(System.Int32 iEnd) => throw new System.NotImplementedException();
	public virtual void SetHookOrientation(System.Int32 iEnd,Autodesk.Revit.DB.Structure.RebarHookOrientation hookOrientation) => throw new System.NotImplementedException();
	public virtual System.Double GetHookRotationAngle(System.Int32 iEnd) => throw new System.NotImplementedException();
	public virtual void SetHookRotationAngle(System.Double hookRotationAngle,System.Int32 iEnd) => throw new System.NotImplementedException();
	public virtual void EnableHookLengthOverride(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual System.Boolean IsHookLengthOverrideEnabled() => throw new System.NotImplementedException();
	public virtual void GetOverridableHookParameters(out System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> startHookLengthPrameters,out System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> startHookTangentLengthParameters,out System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> endHookLengthParameters,out System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> endHookTangentLengthParameters) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetAllRebarShapeIds() => throw new System.NotImplementedException();
	public virtual System.Boolean CanBeMatchedWithMultipleShapes() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCouplerId(System.Int32 end) => throw new System.NotImplementedException();
	public virtual System.Boolean IsRebarFreeForm() => throw new System.NotImplementedException();
	public virtual System.Boolean IsRebarShapeDriven() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarShapeDrivenAccessor GetShapeDrivenAccessor() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarFreeFormAccessor GetFreeFormAccessor() => throw new System.NotImplementedException();
	public virtual void MoveBarInSet(System.Int32 barPositionIndex,Autodesk.Revit.DB.Transform moveTransform) => throw new System.NotImplementedException();
	public virtual System.Int32 GetBarIndexFromReference(Autodesk.Revit.DB.Reference barReference) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetMovedBarTransform(System.Int32 barPositionIndex) => throw new System.NotImplementedException();
	public virtual void ResetMovedBarTransform(System.Int32 barPositionIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.DistributionType DistributionType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 NumberOfBarPositions
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Volume
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TotalLength
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IncludeLastBar
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IncludeFirstBar
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.RebarLayoutRule LayoutRule
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double MaxSpacing
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Quantity
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ReadOnlyParameters
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String ScheduleMark
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

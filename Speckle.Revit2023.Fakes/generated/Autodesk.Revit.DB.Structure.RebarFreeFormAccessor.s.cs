namespace Autodesk.Revit.DB.Structure;

public partial class RebarFreeFormAccessor : System.IDisposable
{
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Curve> GetCustomDistributionPath() => throw new System.NotImplementedException();
	public virtual void SetLayoutAsSingle() => throw new System.NotImplementedException();
	public virtual void SetLayoutAsNumberWithSpacing(System.Int32 numberOfBars,System.Double spacing) => throw new System.NotImplementedException();
	public virtual void SetLayoutAsFixedNumber(System.Int32 numberOfBars) => throw new System.NotImplementedException();
	public virtual void SetLayoutAsMaximumSpacing(System.Double spacing) => throw new System.NotImplementedException();
	public virtual void SetLayoutAsMinimumClearSpacing(System.Double spacing) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetShapeIdAtIndex(System.Int32 barPositionIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean IsBarMatchedWithShapeInReverseOrder(System.Int32 barPositionIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetHookTypeIdAtIndex(System.Int32 barPositionIndex,System.Int32 end) => throw new System.NotImplementedException();
	public virtual System.Double GetHookOrientationAngleAtIndex(System.Int32 barPositionIndex,System.Int32 end) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarHookOrientation GetHookOrientationAtIndex(System.Int32 barPositionIndex,System.Int32 end) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCouplerIdAtIndex(System.Int32 barPositionIndex,System.Int32 end) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetEndTreatmentTypeIdAtIndex(System.Int32 barPositionIndex,System.Int32 end) => throw new System.NotImplementedException();
	public virtual void AddUpdatingSharedParameter(Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public virtual void RemoveUpdatingSharedParameter(Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetUpdatingSharedParameters() => throw new System.NotImplementedException();
	public virtual System.Boolean HasValidServer() => throw new System.NotImplementedException();
	public virtual System.Boolean IsUnconstrained() => throw new System.NotImplementedException();
	public virtual void SetHookPlaneNormalForBarIdx(System.Int32 end,System.Int32 barPositionIndex,Autodesk.Revit.DB.XYZ hookNormal) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetHookPlaneNormalForBarIdx(System.Int32 end,System.Int32 barPositionIndex) => throw new System.NotImplementedException();
	public virtual void SetHookOrientationAngle(System.Int32 end,System.Double angle) => throw new System.NotImplementedException();
	public virtual System.Double GetHookOrientationAngle(System.Int32 end) => throw new System.NotImplementedException();
	public virtual System.Boolean CanBeHookNormal(System.Int32 barIndex,System.Int32 end,Autodesk.Revit.DB.XYZ normal) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult SetCurves(System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> curves) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarFreeFormValidationResult SetCurves(System.Collections.Generic.IList<System.Collections.Generic.IList<Autodesk.Revit.DB.Curve>> curves) => throw new System.NotImplementedException();
	public virtual System.Guid GetServerGUID() => throw new System.NotImplementedException();
	public virtual void DisconnectFromServer() => throw new System.NotImplementedException();
	public virtual void SetReportedShape(Autodesk.Revit.DB.ElementId rebarShapeId) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.StirrupTieAttachmentType StirrupTieAttachmentType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.RebarStyle RebarStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.RebarWorkInstructions WorkshopInstructions
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

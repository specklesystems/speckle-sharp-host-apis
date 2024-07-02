namespace Autodesk.Revit.DB.Structure;

public partial class RebarConstraint : System.IDisposable
{
	public RebarConstraint() {}
	public virtual Autodesk.Revit.DB.Structure.RebarConstraintType GetConstraintType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element GetTargetElement() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element GetTargetElement(System.Int32 targetIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean AreGeometryTargetsTheSame(Autodesk.Revit.DB.Structure.RebarConstraint otherConstraint) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType GetRebarConstraintTargetHostFaceType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarConstraintTargetHostFaceType GetRebarConstraintTargetHostFaceType(System.Int32 targetIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Face GetTargetHostFaceAndTransform(System.Int32 targetIndex,Autodesk.Revit.DB.Transform faceTransform) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.RebarCoverType GetTargetCoverType(System.Int32 targetIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetTargetHostFaceReference() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetTargetHostFaceReference(System.Int32 targetIndex) => throw new System.NotImplementedException();
	public virtual System.Double GetDistanceToTargetHostFace() => throw new System.NotImplementedException();
	public virtual void SetDistanceToTargetHostFace(System.Double offset) => throw new System.NotImplementedException();
	public virtual System.Double GetDistanceToTargetCover() => throw new System.NotImplementedException();
	public virtual void SetDistanceToTargetCover(System.Double distanceToTargetCover) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Structure.TargetRebarConstraintType GetTargetRebarConstraintType() => throw new System.NotImplementedException();
	public virtual System.Int32 GetTargetRebarEdgeNumber() => throw new System.NotImplementedException();
	public virtual System.Int32 GetTargetRebarBendNumber() => throw new System.NotImplementedException();
	public virtual System.Int32 GetTargetRebarHookBarEnd() => throw new System.NotImplementedException();
	public virtual System.Int32 GetTargetRebarAngleOnBarOrHookBend() => throw new System.NotImplementedException();
	public virtual System.Boolean IsEqual(Autodesk.Revit.DB.Structure.RebarConstraint other) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.RebarConstraint Create(Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle,System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> targetReferences,System.Boolean isConstraintToCover,System.Double offsetValue) => throw new System.NotImplementedException();
	public virtual System.Int32 GetCustomHandleTag() => throw new System.NotImplementedException();
	public virtual void ReplaceReferenceTargets(Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle,System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> targetReferences,System.Boolean isConstraintToCover,System.Double offsetValue) => throw new System.NotImplementedException();
	public virtual System.Boolean IsReferenceValidForConstraint(Autodesk.Revit.DB.Reference targetReference) => throw new System.NotImplementedException();
	public virtual System.Double GetDistanceToTargetRebar() => throw new System.NotImplementedException();
	public virtual void SetDistanceToTargetRebar(System.Double distanceToTargetRebar) => throw new System.NotImplementedException();
	public virtual System.Boolean IsBindingHandleWithTarget() => throw new System.NotImplementedException();
	public virtual void SetToBindHandleWithTarget(System.Boolean bindsHandleWithTarget) => throw new System.NotImplementedException();
	public virtual System.Boolean IsUsingClearBarSpacing() => throw new System.NotImplementedException();
	public virtual void SetToUseClearBarSpacing(System.Boolean useClearBarSpacing) => throw new System.NotImplementedException();
	public virtual void FlipHandleOverTarget() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValid() => throw new System.NotImplementedException();
	public virtual System.Boolean IsFixedDistanceToHostFace() => throw new System.NotImplementedException();
	public virtual System.Boolean IsToCover() => throw new System.NotImplementedException();
	public virtual System.Boolean IsToOtherRebar() => throw new System.NotImplementedException();
	public virtual System.Boolean ConstrainsRebarEnds() => throw new System.NotImplementedException();
	public virtual System.Boolean IsToHostFaceOrCover() => throw new System.NotImplementedException();
	public virtual System.Boolean TargetRebarConstraintTypeIsEdge() => throw new System.NotImplementedException();
	public virtual System.Boolean TargetIsBarBend() => throw new System.NotImplementedException();
	public virtual System.Boolean TargetIsHookBend() => throw new System.NotImplementedException();
	public virtual System.Boolean HasAnEdgeNumber() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NumberOfTargets
	{
		get => throw new System.NotImplementedException();
	}
}

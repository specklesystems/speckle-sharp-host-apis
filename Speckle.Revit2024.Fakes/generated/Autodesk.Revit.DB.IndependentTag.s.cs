namespace Autodesk.Revit.DB;

public partial class IndependentTag : Autodesk.Revit.DB.Element
{
	public IndependentTag() {}
	public static Autodesk.Revit.DB.IndependentTag Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId symId,Autodesk.Revit.DB.ElementId ownerDBViewId,Autodesk.Revit.DB.Reference referenceToTag,System.Boolean addLeader,Autodesk.Revit.DB.TagOrientation tagOrientation,Autodesk.Revit.DB.XYZ pnt) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.IndependentTag Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId ownerDBViewId,Autodesk.Revit.DB.Reference referenceToTag,System.Boolean addLeader,Autodesk.Revit.DB.TagMode tagMode,Autodesk.Revit.DB.TagOrientation tagOrientation,Autodesk.Revit.DB.XYZ pnt) => throw new System.NotImplementedException();
	public virtual System.Boolean HasTagBehavior() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetTaggedLocalElementIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.LinkElementId> GetTaggedElementIds() => throw new System.NotImplementedException();
	public virtual System.Boolean HasLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged) => throw new System.NotImplementedException();
	public virtual void SetLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged,Autodesk.Revit.DB.XYZ elbowPosition) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetLeaderEnd(Autodesk.Revit.DB.Reference referenceTagged) => throw new System.NotImplementedException();
	public virtual void SetLeaderEnd(Autodesk.Revit.DB.Reference referenceTagged,Autodesk.Revit.DB.XYZ pointEnd) => throw new System.NotImplementedException();
	public virtual void AddReferences(System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> referencesToTag) => throw new System.NotImplementedException();
	public virtual void RemoveReferences(System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> referencesToRemove) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.Element> GetTaggedLocalElements() => throw new System.NotImplementedException();
	public virtual System.Boolean CanLeaderEndConditionBeAssigned(Autodesk.Revit.DB.LeaderEndCondition leaderEndCondition) => throw new System.NotImplementedException();
	public virtual System.Boolean IsTaggedOnSubelement() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetTaggedReferences() => throw new System.NotImplementedException();
	public virtual System.Boolean IsLeaderVisible(Autodesk.Revit.DB.Reference referenceTagged) => throw new System.NotImplementedException();
	public virtual void SetIsLeaderVisible(Autodesk.Revit.DB.Reference referenceTagged,System.Boolean visible) => throw new System.NotImplementedException();
	public virtual System.Boolean MergeElbows
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.LeadersPresentationMode LeadersPresentationMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double RotationAngle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean MultiLeader
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.LeaderEndCondition LeaderEndCondition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HasLeader
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ TagHeadPosition
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.TagOrientation TagOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsOrphaned
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsMulticategoryTag
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsMaterialTag
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String TagText
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId MultiReferenceAnnotationId
	{
		get => throw new System.NotImplementedException();
	}
}

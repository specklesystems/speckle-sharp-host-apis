namespace Autodesk.Revit.DB;

public partial class IndependentTag : Autodesk.Revit.DB.Element
{
  public IndependentTag() { }

  public static Autodesk.Revit.DB.IndependentTag Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId symId,
    Autodesk.Revit.DB.ElementId ownerDBViewId,
    Autodesk.Revit.DB.Reference referenceToTag,
    System.Boolean addLeader,
    Autodesk.Revit.DB.TagOrientation tagOrientation,
    Autodesk.Revit.DB.XYZ pnt
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.IndependentTag Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId ownerDBViewId,
    Autodesk.Revit.DB.Reference referenceToTag,
    System.Boolean addLeader,
    Autodesk.Revit.DB.TagMode tagMode,
    Autodesk.Revit.DB.TagOrientation tagOrientation,
    Autodesk.Revit.DB.XYZ pnt
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetTaggedLocalElementIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.LinkElementId> GetTaggedElementIds() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ GetLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged) =>
    throw new System.NotImplementedException();

  public virtual void SetLeaderElbow(Autodesk.Revit.DB.Reference referenceTagged, Autodesk.Revit.DB.XYZ pntElbow) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ GetLeaderEnd(Autodesk.Revit.DB.Reference referenceTagged) =>
    throw new System.NotImplementedException();

  public virtual void SetLeaderEnd(Autodesk.Revit.DB.Reference referenceTagged, Autodesk.Revit.DB.XYZ pntEnd) =>
    throw new System.NotImplementedException();

  public virtual void AddReferences(System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> referencesToTag) =>
    throw new System.NotImplementedException();

  public virtual void RemoveReferences(
    System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> referencesToRemove
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Element GetTaggedLocalElement() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.Element> GetTaggedLocalElements() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanLeaderEndConditionBeAssigned(
    Autodesk.Revit.DB.LeaderEndCondition leaderEndCondition
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsTaggedOnSubelement() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetTaggedReference() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> GetTaggedReferences() =>
    throw new System.NotImplementedException();

  public virtual System.Double RotationAngle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean MultiLeader
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ LeaderEnd
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ LeaderElbow
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.LeaderEndCondition LeaderEndCondition
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HasElbow
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean HasLeader
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ TagHeadPosition
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.TagOrientation TagOrientation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.LinkElementId TaggedElementId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId TaggedLocalElementId
  {
    get => throw new System.NotImplementedException();
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

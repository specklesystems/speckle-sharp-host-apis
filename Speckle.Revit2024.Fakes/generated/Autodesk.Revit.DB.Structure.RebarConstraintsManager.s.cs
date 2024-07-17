namespace Autodesk.Revit.DB.Structure;

public partial class RebarConstraintsManager : System.IDisposable
{
  public RebarConstraintsManager() { }

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarConstrainedHandle> GetAllConstrainedHandles() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarConstraint GetCurrentConstraintOnHandle(
    Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarConstraint> GetConstraintCandidatesForHandle(
    Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle,
    Autodesk.Revit.DB.Reference reference
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarConstraint> GetConstraintCandidatesForHandle(
    Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle,
    Autodesk.Revit.DB.ElementId elementId
  ) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarConstraint> GetConstraintCandidatesForHandle(
    Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle
  ) => throw new System.NotImplementedException();

  public virtual void SetPreferredConstraintForHandle(
    Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle,
    Autodesk.Revit.DB.Structure.RebarConstraint constraint
  ) => throw new System.NotImplementedException();

  public virtual void RemovePreferredConstraintFromHandle(Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarConstrainedHandle> GetAllHandles() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarConstraint GetPreferredConstraintOnHandle(
    Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle
  ) => throw new System.NotImplementedException();

  public virtual void HighlightHandleConstraintPairInAllViews(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle,
    Autodesk.Revit.DB.Structure.RebarConstraint constraint
  ) => throw new System.NotImplementedException();

  public virtual void ClearHandleConstraintPairHighlighting(Autodesk.Revit.DB.Document aDoc) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean AllowConstraintTargets(
    Autodesk.Revit.DB.Structure.RebarConstrainedHandle handle,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> targetsToConstrain
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean ApplyRebarConstraints(
    System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarConstraint> constraintsToApply,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> oldTargets,
    System.Collections.Generic.IList<Autodesk.Revit.DB.Reference> newTargets
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean HasValidRebar() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Boolean IsRebarConstrainedPlacementEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

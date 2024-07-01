namespace Autodesk.Revit.DB.Structure;

public partial class RebarShapeConstraintSegmentLength : Autodesk.Revit.DB.Structure.RebarShapeConstraint
{
  public RebarShapeConstraintSegmentLength() { }

  public RebarShapeConstraintSegmentLength(
    Autodesk.Revit.DB.ElementId paramId,
    Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType refType0,
    Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType refType1
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType GetSegmentEndReferenceType(
    System.Int32 index
  ) => throw new System.NotImplementedException();
}

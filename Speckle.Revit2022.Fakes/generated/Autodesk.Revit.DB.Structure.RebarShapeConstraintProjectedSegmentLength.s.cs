namespace Autodesk.Revit.DB.Structure;

public partial class RebarShapeConstraintProjectedSegmentLength : Autodesk.Revit.DB.Structure.RebarShapeConstraint
{
  public RebarShapeConstraintProjectedSegmentLength() { }

  public RebarShapeConstraintProjectedSegmentLength(
    Autodesk.Revit.DB.ElementId paramId,
    Autodesk.Revit.DB.UV direction,
    System.Int32 tripleProductSign,
    Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType refType0,
    Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType refType1
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarShapeSegmentEndReferenceType GetSegmentEndReferenceType(
    System.Int32 index
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.UV Direction
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 TripleProductSign
  {
    get => throw new System.NotImplementedException();
  }
}

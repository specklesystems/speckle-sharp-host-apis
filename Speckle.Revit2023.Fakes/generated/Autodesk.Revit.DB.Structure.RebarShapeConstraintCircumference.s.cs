namespace Autodesk.Revit.DB.Structure;

public partial class RebarShapeConstraintCircumference : Autodesk.Revit.DB.Structure.RebarShapeConstraint
{
  public RebarShapeConstraintCircumference() { }

  public RebarShapeConstraintCircumference(
    Autodesk.Revit.DB.ElementId paramId,
    Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType refType
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.RebarShapeArcReferenceType ArcReferenceType
  {
    get => throw new System.NotImplementedException();
  }
}

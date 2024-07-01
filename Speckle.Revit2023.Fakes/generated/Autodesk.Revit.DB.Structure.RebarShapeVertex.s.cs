namespace Autodesk.Revit.DB.Structure;

public partial class RebarShapeVertex : System.IDisposable
{
  public RebarShapeVertex() { }

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarShapeConstraint> GetConstraints() =>
    throw new System.NotImplementedException();

  public virtual void SetConstraints(
    System.Collections.Generic.IList<Autodesk.Revit.DB.Structure.RebarShapeConstraint> constraints
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Structure.RebarShapeBendAngle BendAngle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.RebarShapeVertexTurn Turn
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Autodesk.Revit.DB.Structure;

public partial class BoundaryConditions : Autodesk.Revit.DB.Element
{
  public BoundaryConditions() { }

  public virtual Autodesk.Revit.DB.Structure.BoundaryConditionsType GetBoundaryConditionsType() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo GetOrientTo() =>
    throw new System.NotImplementedException();

  public virtual void SetOrientTo(Autodesk.Revit.DB.Structure.BoundaryConditionsOrientTo orientTo) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetDegreesOfFreedomCoordinateSystem() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Curve GetCurve() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> GetLoops() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ Point
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId AssociatedLoadId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.AnalyticalModel HostElement
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId HostElementId
  {
    get => throw new System.NotImplementedException();
  }
}

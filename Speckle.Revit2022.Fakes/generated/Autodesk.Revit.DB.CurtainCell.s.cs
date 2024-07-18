namespace Autodesk.Revit.DB;

public partial class CurtainCell : Autodesk.Revit.DB.APIObject
{
  public CurtainCell() { }

  public virtual Autodesk.Revit.DB.CurveArrArray CurveLoops
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.CurveArrArray PlanarizedCurveLoops
  {
    get => throw new System.NotImplementedException();
  }
}

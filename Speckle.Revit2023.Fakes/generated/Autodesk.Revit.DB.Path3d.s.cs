namespace Autodesk.Revit.DB;

public partial class Path3d : Autodesk.Revit.DB.SketchBase
{
  public virtual Autodesk.Revit.DB.CurveArray get_CurveLoop(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveArrArray AllCurveLoops
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumCurveLoops
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB;

public partial class CurveElementFilter : Autodesk.Revit.DB.ElementSlowFilter
{
  public CurveElementFilter() { }

  public CurveElementFilter(Autodesk.Revit.DB.CurveElementType curveElementType, System.Boolean inverted) =>
    throw new System.NotImplementedException();

  public CurveElementFilter(Autodesk.Revit.DB.CurveElementType curveElementType) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveElementType CurveElementType
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB;

public partial class FaceSplitter : Autodesk.Revit.DB.Element
{
  public FaceSplitter() { }

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.CurveLoop> GetBoundaries() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId SplitElementId
  {
    get => throw new System.NotImplementedException();
  }
}

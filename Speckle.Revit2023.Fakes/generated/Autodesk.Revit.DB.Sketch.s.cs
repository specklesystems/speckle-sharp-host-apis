namespace Autodesk.Revit.DB;

public partial class Sketch : Autodesk.Revit.DB.SketchBase
{
  public Sketch() { }

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetAllElements() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId OwnerId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.SketchPlane SketchPlane
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.CurveArrArray Profile
  {
    get => throw new System.NotImplementedException();
  }
}

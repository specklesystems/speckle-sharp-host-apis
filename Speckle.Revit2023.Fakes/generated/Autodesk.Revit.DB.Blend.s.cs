namespace Autodesk.Revit.DB;

public partial class Blend : Autodesk.Revit.DB.GenericForm
{
  public Blend() { }

  public virtual Autodesk.Revit.DB.VertexIndexPairArray GetVertexConnectionMap() =>
    throw new System.NotImplementedException();

  public virtual void SetVertexConnectionMap(Autodesk.Revit.DB.VertexIndexPairArray vertexMap) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveArrArray TopProfile
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.CurveArrArray BottomProfile
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double TopOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BottomOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Sketch BottomSketch
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Sketch TopSketch
  {
    get => throw new System.NotImplementedException();
  }
}

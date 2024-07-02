namespace Autodesk.Revit.DB;

public partial class Edge : Autodesk.Revit.DB.GeometryObject
{
  public Edge() { }

  public virtual Autodesk.Revit.DB.Face GetFace(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> Tessellate() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.UV> TessellateOnFace(Autodesk.Revit.DB.Face face) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ Evaluate(System.Double param) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.UV EvaluateOnFace(System.Double param, Autodesk.Revit.DB.Face face) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Curve AsCurve() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Curve AsCurveFollowingFace(Autodesk.Revit.DB.Face faceForDir) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsFlippedOnFace(Autodesk.Revit.DB.Face face) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsFlippedOnFace(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveUV GetCurveUV(System.Int32 index, Autodesk.Revit.DB.Transform2D transform) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveUV GetCurveUV(System.Int32 index) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetEndPointReference(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform ComputeDerivatives(System.Double parameter) =>
    throw new System.NotImplementedException();

  public virtual System.Double ApproximateLength
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Reference Reference
  {
    get => throw new System.NotImplementedException();
  }
}

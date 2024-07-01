namespace Autodesk.Revit.DB;

public partial class TransformWithBoundary : System.IDisposable
{
  public TransformWithBoundary(Autodesk.Revit.DB.TransformWithBoundary other) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetModelToProjectionTransform() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurveLoop GetBoundary() => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Rhino.Geometry;

public partial class HiddenLineDrawing : System.IDisposable
{
  public HiddenLineDrawing() { }

  public static Rhino.Geometry.HiddenLineDrawing Compute(
    Rhino.Geometry.HiddenLineDrawingParameters parameters,
    System.Boolean multipleThreads
  ) => throw new System.NotImplementedException();

  public static Rhino.Geometry.HiddenLineDrawing Compute(
    Rhino.Geometry.HiddenLineDrawingParameters parameters,
    System.Boolean multipleThreads,
    System.IProgress<System.Double> progress,
    System.Threading.CancellationToken cancelToken
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual void RejoinCompatibleVisible() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BoundingBox BoundingBox(System.Boolean includeHidden) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerable<Rhino.Geometry.HiddenLineDrawingSegment> Segments
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IEnumerable<Rhino.Geometry.HiddenLineDrawingPoint> Points
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.ViewportInfo Viewport
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Transform WorldToHiddenLine
  {
    get => throw new System.NotImplementedException();
  }
}

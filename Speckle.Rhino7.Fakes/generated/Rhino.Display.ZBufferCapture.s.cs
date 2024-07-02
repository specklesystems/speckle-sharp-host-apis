namespace Rhino.Display;

public partial class ZBufferCapture : System.IDisposable
{
  public ZBufferCapture() { }

  public ZBufferCapture(Rhino.Display.RhinoViewport viewport) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual void SetDisplayMode(System.Guid modeId) => throw new System.NotImplementedException();

  public virtual void ShowIsocurves(System.Boolean on) => throw new System.NotImplementedException();

  public virtual void ShowMeshWires(System.Boolean on) => throw new System.NotImplementedException();

  public virtual void ShowCurves(System.Boolean on) => throw new System.NotImplementedException();

  public virtual void ShowPoints(System.Boolean on) => throw new System.NotImplementedException();

  public virtual void ShowText(System.Boolean on) => throw new System.NotImplementedException();

  public virtual void ShowAnnotations(System.Boolean on) => throw new System.NotImplementedException();

  public virtual void ShowLights(System.Boolean on) => throw new System.NotImplementedException();

  public virtual System.Int32 HitCount() => throw new System.NotImplementedException();

  public virtual System.Single MaxZ() => throw new System.NotImplementedException();

  public virtual System.Single MinZ() => throw new System.NotImplementedException();

  public virtual System.Single ZValueAt(System.Int32 x, System.Int32 y) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d WorldPointAt(System.Int32 x, System.Int32 y) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Bitmap GrayscaleDib() => throw new System.NotImplementedException();
}

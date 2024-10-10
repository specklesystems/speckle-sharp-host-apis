namespace Rhino.Render;

public partial class PreviewJobSignature : System.IDisposable
{
  public PreviewJobSignature() { }

  public PreviewJobSignature(System.IntPtr intPtr) => throw new System.NotImplementedException();

  public PreviewJobSignature(System.Int32 width, System.Int32 height, System.UInt32 sig) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean Compare(Rhino.Render.PreviewJobSignature pjs) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 ImageWidth() => throw new System.NotImplementedException();

  public virtual System.Int32 ImageHeight() => throw new System.NotImplementedException();

  public virtual System.IntPtr CppPointer
  {
    get => throw new System.NotImplementedException();
  }
}

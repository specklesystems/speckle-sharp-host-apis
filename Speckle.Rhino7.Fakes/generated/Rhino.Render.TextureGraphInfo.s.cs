namespace Rhino.Render;

public partial class TextureGraphInfo : System.IDisposable
{
  public TextureGraphInfo() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Double AmountU() => throw new System.NotImplementedException();

  public virtual void SetAmountU(System.Double d) => throw new System.NotImplementedException();

  public virtual System.Double AmountV() => throw new System.NotImplementedException();

  public virtual void SetAmountV(System.Double d) => throw new System.NotImplementedException();

  public virtual System.Double AmountW() => throw new System.NotImplementedException();

  public virtual void SetAmountW(System.Double d) => throw new System.NotImplementedException();

  public virtual Rhino.Render.TextureGraphInfo.Axis ActiveAxis() => throw new System.NotImplementedException();

  public virtual void SetActiveAxis(Rhino.Render.TextureGraphInfo.Axis axis) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Render.TextureGraphInfo.Channel ActiveChannel() => throw new System.NotImplementedException();

  public virtual void SetActiveChannel(Rhino.Render.TextureGraphInfo.Channel channel) =>
    throw new System.NotImplementedException();

  public virtual System.IntPtr CppPointer
  {
    get => throw new System.NotImplementedException();
  }
}

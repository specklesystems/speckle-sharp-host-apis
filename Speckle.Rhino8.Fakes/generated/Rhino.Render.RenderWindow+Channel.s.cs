namespace Rhino.Render;

public partial class RenderWindow
{
  public partial class Channel : System.IDisposable
  {
    public Channel() { }

    public virtual System.Int32 PixelSize() => throw new System.NotImplementedException();

    public virtual void SetValue(System.Int32 x, System.Int32 y, System.Single value) =>
      throw new System.NotImplementedException();

    public virtual void SetValues(
      System.Drawing.Rectangle rectangle,
      System.Drawing.Size bufferResolution,
      Rhino.Render.PixelBuffer colorBuffer
    ) => throw new System.NotImplementedException();

    public virtual void SetValuesFlipped(
      System.Drawing.Rectangle rectangle,
      System.Drawing.Size bufferResolution,
      Rhino.Render.PixelBuffer colorBuffer
    ) => throw new System.NotImplementedException();

    public virtual void SetValue(System.Int32 x, System.Int32 y, Rhino.Display.Color4f value) =>
      throw new System.NotImplementedException();

    public virtual void AddValue(System.Int32 x, System.Int32 y, Rhino.Display.Color4f value) =>
      throw new System.NotImplementedException();

    public virtual Rhino.Render.RenderWindow.Channel Clone() => throw new System.NotImplementedException();

    public virtual void GetMinMaxValues(out System.Single min, out System.Single max) =>
      throw new System.NotImplementedException();

    public virtual void Dispose() => throw new System.NotImplementedException();

    public virtual System.Guid Id
    {
      get => throw new System.NotImplementedException();
    }
    public virtual System.Int32 Width
    {
      get => throw new System.NotImplementedException();
    }
    public virtual System.Int32 Height
    {
      get => throw new System.NotImplementedException();
    }
  }
}

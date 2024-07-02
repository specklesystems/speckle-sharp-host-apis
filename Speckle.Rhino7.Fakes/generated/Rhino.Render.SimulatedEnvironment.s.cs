namespace Rhino.Render;

public partial class SimulatedEnvironment : System.IDisposable
{
  public SimulatedEnvironment() { }

  public static Rhino.Render.SimulatedEnvironment.BackgroundProjections ProjectionFromString(
    System.String projection
  ) => throw new System.NotImplementedException();

  public static System.String StringFromProjection(
    Rhino.Render.SimulatedEnvironment.BackgroundProjections projection
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.IntPtr ConstPointer() => throw new System.NotImplementedException();

  public virtual System.Drawing.Color BackgroundColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.SimulatedTexture BackgroundImage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.SimulatedEnvironment.BackgroundProjections BackgroundProjection
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

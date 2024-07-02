namespace Rhino.Render;

public partial class RenderWindow
{
  public partial class ImageAdjust
  {
    public ImageAdjust() { }

    public virtual System.Single Gamma
    {
      get => throw new System.NotImplementedException();
      set { }
    }
    public virtual Rhino.Render.Dithering.Methods Dither
    {
      get => throw new System.NotImplementedException();
      set { }
    }
  }
}

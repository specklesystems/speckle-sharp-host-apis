namespace Rhino.Display;

public partial class ColorLAB
{
  public ColorLAB() { }

  public ColorLAB(System.Drawing.Color rgb) => throw new System.NotImplementedException();

  public ColorLAB(System.Double lightness, System.Double a, System.Double b) =>
    throw new System.NotImplementedException();

  public ColorLAB(System.Double alpha, System.Double lightness, System.Double a, System.Double b) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLAB CreateFromRGBA(Rhino.Display.ColorRGBA rgb) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLAB CreateFromHSL(Rhino.Display.ColorHSL hsl) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLAB CreateFromCMYK(Rhino.Display.ColorCMYK cmyk) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLAB CreateFromXYZ(Rhino.Display.ColorXYZ xyz) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLAB CreateFromLCH(Rhino.Display.ColorLCH lch) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLAB CreateFromHSV(Rhino.Display.ColorHSV hsv) =>
    throw new System.NotImplementedException();

  public virtual System.Double L
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double A
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double B
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Alpha
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

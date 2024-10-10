namespace Rhino.Display;

public partial class ColorHSV
{
  public ColorHSV() { }

  public ColorHSV(System.Drawing.Color rgb) => throw new System.NotImplementedException();

  public ColorHSV(System.Double hue, System.Double saturation, System.Double value) =>
    throw new System.NotImplementedException();

  public ColorHSV(System.Double alpha, System.Double hue, System.Double saturation, System.Double value) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorHSV CreateFromRGBA(Rhino.Display.ColorRGBA rgba) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorHSV CreateFromHSL(Rhino.Display.ColorHSL hsl) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorHSV CreateFromCMYK(Rhino.Display.ColorCMYK cmyk) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorHSV CreateFromXYZ(Rhino.Display.ColorXYZ xyz) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorHSV CreateFromLAB(Rhino.Display.ColorLAB lab) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorHSV CreateFromLCH(Rhino.Display.ColorLCH lch) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Color ToArgbColor() => throw new System.NotImplementedException();

  public virtual System.Double H
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double S
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double V
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double A
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

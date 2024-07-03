namespace Rhino.Display;

public partial class ColorLCH
{
  public ColorLCH() { }

  public ColorLCH(System.Drawing.Color rgb) => throw new System.NotImplementedException();

  public ColorLCH(System.Double lightness, System.Double chroma, System.Double hue) =>
    throw new System.NotImplementedException();

  public ColorLCH(System.Double alpha, System.Double lightness, System.Double chroma, System.Double hue) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLCH CreateFromRGBA(Rhino.Display.ColorRGBA rgb) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLCH CreateFromHSL(Rhino.Display.ColorHSL hsl) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLCH CreateFromCMYK(Rhino.Display.ColorCMYK cmyk) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLCH CreateFromXYZ(Rhino.Display.ColorXYZ xyz) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorLCH CreateFromLAB(Rhino.Display.ColorLAB lab) =>
    throw new System.NotImplementedException();

  public virtual void MakePositive() => throw new System.NotImplementedException();

  public virtual System.Double L
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double C
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double H
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

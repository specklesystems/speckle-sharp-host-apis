namespace Rhino.Display;

public partial struct ColorCMYK
{
  public ColorCMYK() { }

  public ColorCMYK(System.Drawing.Color rgb) => throw new System.NotImplementedException();

  public ColorCMYK(System.Double cyan, System.Double magenta, System.Double yellow) =>
    throw new System.NotImplementedException();

  public ColorCMYK(System.Double cyan, System.Double magenta, System.Double yellow, System.Double key) =>
    throw new System.NotImplementedException();

  public ColorCMYK(
    System.Double alpha,
    System.Double cyan,
    System.Double magenta,
    System.Double yellow,
    System.Double key
  ) => throw new System.NotImplementedException();

  public static Rhino.Display.ColorCMYK CreateFromRGBA(Rhino.Display.ColorRGBA rgba) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorCMYK CreateFromHSL(Rhino.Display.ColorHSL hsl) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorCMYK CreateFromXYZ(Rhino.Display.ColorXYZ xyz) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorCMYK CreateFromLAB(Rhino.Display.ColorLAB lab) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorCMYK CreateFromLCH(Rhino.Display.ColorLCH lch) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorCMYK CreateFromHSV(Rhino.Display.ColorHSV hsv) =>
    throw new System.NotImplementedException();

  public System.Double C
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double M
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double Y
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double K
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public System.Double A
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

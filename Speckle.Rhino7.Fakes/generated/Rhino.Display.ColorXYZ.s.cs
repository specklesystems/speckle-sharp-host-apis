namespace Rhino.Display;

public partial class ColorXYZ
{
  public ColorXYZ() { }

  public ColorXYZ(System.Drawing.Color rgb) => throw new System.NotImplementedException();

  public ColorXYZ(System.Double x, System.Double y, System.Double z) => throw new System.NotImplementedException();

  public ColorXYZ(System.Double alpha, System.Double x, System.Double y, System.Double z) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorXYZ CreateFromRGBA(Rhino.Display.ColorRGBA rgba) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorXYZ CreateFromHSL(Rhino.Display.ColorHSL hsl) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorXYZ CreateFromCMYK(Rhino.Display.ColorCMYK cmyk) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorXYZ CreateFromLAB(Rhino.Display.ColorLAB lab) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorXYZ CreateFromLCH(Rhino.Display.ColorLCH lch) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorXYZ CreateFromHSV(Rhino.Display.ColorHSV hsv) =>
    throw new System.NotImplementedException();

  public virtual System.Double X
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Y
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Z
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

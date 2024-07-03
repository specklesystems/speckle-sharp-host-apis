namespace Rhino.Display;

public partial class ColorRGBA
  : System.Runtime.Serialization.ISerializable,
    System.IFormattable,
    System.IComparable,
    System.IComparable<Rhino.Display.ColorRGBA>,
    System.IEquatable<Rhino.Display.ColorRGBA>,
    Rhino.IEpsilonComparable<Rhino.Display.ColorRGBA>
{
  public ColorRGBA() { }

  public ColorRGBA(Rhino.Display.ColorRGBA color) => throw new System.NotImplementedException();

  public ColorRGBA(System.Double red, System.Double green, System.Double blue) =>
    throw new System.NotImplementedException();

  public ColorRGBA(System.Double red, System.Double green, System.Double blue, System.Double alpha) =>
    throw new System.NotImplementedException();

  public ColorRGBA(System.Drawing.Color color) => throw new System.NotImplementedException();

  public ColorRGBA(System.Int32 argb) => throw new System.NotImplementedException();

  public static Rhino.Display.ColorRGBA CreateFromHSV(Rhino.Display.ColorHSV hsv) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorRGBA CreateFromHSL(Rhino.Display.ColorHSL hsl) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorRGBA CreateFromCMYK(Rhino.Display.ColorCMYK cmyk) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorRGBA CreateFromXYZ(Rhino.Display.ColorXYZ xyz) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorRGBA CreateFromLAB(Rhino.Display.ColorLAB lab) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorRGBA CreateFromLCH(Rhino.Display.ColorLCH lch) =>
    throw new System.NotImplementedException();

  public virtual System.String ToString(System.String format, System.IFormatProvider formatProvider) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 CompareTo(Rhino.Display.ColorRGBA other) => throw new System.NotImplementedException();

  public virtual System.Boolean EpsilonEquals(Rhino.Display.ColorRGBA other, System.Double epsilon) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Equals(Rhino.Display.ColorRGBA other) => throw new System.NotImplementedException();

  public virtual Rhino.Display.ColorRGBA BlendTo(Rhino.Display.ColorRGBA col, System.Double coefficient) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.ColorRGBA ApplyGamma(Rhino.Display.ColorRGBA col, System.Double gamma) =>
    throw new System.NotImplementedException();

  void System.Runtime.Serialization.ISerializable.GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  System.Int32 System.IComparable.CompareTo(System.Object obj) => throw new System.NotImplementedException();

  public virtual System.Double R
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double G
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double B
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double A
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public static Rhino.Display.ColorRGBA Black
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Display.ColorRGBA White
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Display.ColorRGBA Red
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Display.ColorRGBA Green
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Display.ColorRGBA Blue
  {
    get => throw new System.NotImplementedException();
  }
}

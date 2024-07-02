namespace Rhino.Display;

public partial struct Color4f : System.Runtime.Serialization.ISerializable
{
  public Color4f() { }

  public Color4f(System.Drawing.Color color) => throw new System.NotImplementedException();

  public Color4f(Rhino.Display.Color4f color) => throw new System.NotImplementedException();

  public Color4f(System.Single red, System.Single green, System.Single blue, System.Single alpha) =>
    throw new System.NotImplementedException();

  public Color4f(System.Int32 argb) => throw new System.NotImplementedException();

  public static Rhino.Display.Color4f FromArgb(System.Single a, System.Single r, System.Single g, System.Single b) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.Color4f FromArgb(System.Single a, Rhino.Display.Color4f color) =>
    throw new System.NotImplementedException();

  public Rhino.Display.Color4f BlendTo(System.Single t, Rhino.Display.Color4f col) =>
    throw new System.NotImplementedException();

  public static Rhino.Display.Color4f ApplyGamma(Rhino.Display.Color4f col, System.Single gamma) =>
    throw new System.NotImplementedException();

  public System.Drawing.Color AsSystemColor() => throw new System.NotImplementedException();

  void System.Runtime.Serialization.ISerializable.GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  public static Rhino.Display.Color4f Empty
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Display.Color4f Black
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Display.Color4f White
  {
    get => throw new System.NotImplementedException();
  }
  public System.Single R
  {
    get => throw new System.NotImplementedException();
  }
  public System.Single G
  {
    get => throw new System.NotImplementedException();
  }
  public System.Single B
  {
    get => throw new System.NotImplementedException();
  }
  public System.Single A
  {
    get => throw new System.NotImplementedException();
  }
  public System.Single L
  {
    get => throw new System.NotImplementedException();
  }
}

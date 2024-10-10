namespace Rhino.DocObjects;

public partial class Font : System.Runtime.Serialization.ISerializable
{
  public Font() { }

  public Font(System.String familyName) => throw new System.NotImplementedException();

  public Font(
    System.String familyName,
    Rhino.DocObjects.Font.FontWeight weight,
    Rhino.DocObjects.Font.FontStyle style,
    System.Boolean underlined,
    System.Boolean strikethrough
  ) => throw new System.NotImplementedException();

  public Font(
    System.String familyName,
    Rhino.DocObjects.Font.FontWeight weight,
    Rhino.DocObjects.Font.FontStyle style,
    Rhino.DocObjects.Font.FontStretch stretch,
    System.Boolean underlined,
    System.Boolean strikethrough
  ) => throw new System.NotImplementedException();

  public virtual void GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  public static Rhino.DocObjects.Font FromQuartetProperties(
    System.String quartetName,
    System.Boolean bold,
    System.Boolean italic
  ) => throw new System.NotImplementedException();

  public static System.String[] AvailableFontFaceNames() => throw new System.NotImplementedException();

  public static Rhino.DocObjects.Font[] InstalledFonts() => throw new System.NotImplementedException();

  public static Rhino.DocObjects.Font[] InstalledFonts(System.String familyName) =>
    throw new System.NotImplementedException();

  public static Rhino.DocObjects.FontQuartet[] InstalledFontsAsQuartets() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Font GetSubstituteFont() => throw new System.NotImplementedException();

  public virtual System.String QuartetName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String EnglishQuartetName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String FaceName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String EnglishFaceName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String LogfontName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String FamilyPlusFaceName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String PostScriptName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String RichTextFontName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Bold
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Italic
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Underlined
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Strikeout
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsEngravingFont
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSymbolFont
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSingleStrokeFont
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsSimulated
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.Font.FontStyle Style
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.Font.FontWeight Weight
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.Font.FontStretch Stretch
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double PointSize
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String FamilyName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String EnglishFamilyName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsInstalled
  {
    get => throw new System.NotImplementedException();
  }
}

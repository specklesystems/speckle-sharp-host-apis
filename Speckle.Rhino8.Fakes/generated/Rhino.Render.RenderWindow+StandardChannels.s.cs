namespace Rhino.Render;

public partial class RenderWindow
{
  public enum StandardChannels
  {
    None,
    Red,
    Green,
    Blue,
    Alpha,
    RGBA,
    RGB,
    DistanceFromCamera,
    NormalX,
    NormalY,
    NormalZ,
    NormalXYZ,
    LuminanceRed,
    LuminanceGreen,
    LuminanceBlue,
    BackgroundLuminanceRed,
    BackgroundLuminanceGreen,
    BackgroundLuminanceBlue,
    MaterialIds,
    ObjectIds,
    Wireframe,
    AlbedoRed,
    AlbedoGreen,
    AlbedoBlue,
    AlbedoRGB,
    WireframePointsRGBA,
    WireframeIsocurvesRGBA,
    WireframeCurvesRGBA,
    WireframeAnnotationsRGBA,
  }
}

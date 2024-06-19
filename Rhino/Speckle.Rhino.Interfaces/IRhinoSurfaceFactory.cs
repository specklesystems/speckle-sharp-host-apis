namespace Speckle.Rhino7.Interfaces;

public interface IRhinoSurfaceFactory
{
  IRhinoNurbsSurface Create(
    int dimension,
    bool isRational,
    int order0,
    int order1,
    int controlPointCount0,
    int controlPointCount1
  );
}

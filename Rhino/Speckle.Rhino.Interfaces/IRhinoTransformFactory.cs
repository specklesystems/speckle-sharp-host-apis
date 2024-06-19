namespace Speckle.Rhino7.Interfaces;

public interface IRhinoTransformFactory
{
  IRhinoPoint3d Origin { get; }
  IRhinoTransform Identity { get; }
  IRhinoTransform Scale(IRhinoPoint3d origin, double y);
}

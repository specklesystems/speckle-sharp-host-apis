namespace Speckle.Rhino7.Interfaces;

public interface IRhinoCircleFactory
{
  IRhinoCircle Create(IRhinoPlane plane, double radius);
  IRhinoArcCurve Create(IRhinoCircle circle, IRhinoInterval domain);
}

namespace Speckle.Rhino7.Interfaces;

public interface IRhinoArcFactory
{
  IRhinoArc Create(IRhinoPoint3d startPoint, IRhinoPoint3d midPoint, IRhinoPoint3d endPoint);
  IRhinoArcCurve Create(IRhinoArc arc, IRhinoInterval domain);
}

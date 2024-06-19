namespace Speckle.Rhino7.Interfaces;

public interface IRhinoLineFactory
{
  IRhinoLine Create(IRhinoPoint3d start, IRhinoPoint3d end);
  IRhinoLineCurve Create(IRhinoLine line);
  IRhinoPolyline Create(IRhinoPoint3dList list);
}

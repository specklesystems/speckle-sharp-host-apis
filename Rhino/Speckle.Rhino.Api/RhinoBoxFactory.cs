using Rhino.Geometry;
using Speckle.Rhino7.Interfaces;

namespace Speckle.Rhino7.Api;

public class RhinoBoxFactory : IRhinoBoxFactory
{
  public IRhinoBox CreateBox(IRhinoBoundingBox boundingBox) => new BoxProxy(new Box((A.Cast<IRhinoBoundingBoxProxy, BoundingBox>(boundingBox, x => x._Instance))));
}

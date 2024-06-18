using Rhino.Geometry;
using Speckle.Rhino7.Interfaces;

namespace Speckle.Rhino7.Api;

public class RhinoBoxFactory : IRhinoBoxFactory
{
  public IRhinoBox CreateBox(IRhinoBoundingBox boundingBox) 
    => new BoxProxy(new Box(((IRhinoBoundingBoxProxy)boundingBox)._Instance));
}

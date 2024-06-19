using Rhino.Geometry;
using Speckle.ProxyGenerator;
using Speckle.Rhino7.Interfaces;

namespace Speckle.Rhino7.Api;

[Proxy(typeof(Plane), new[] { "Equals" })]
public partial interface IRhinoPlaneProxy : IRhinoPlane;

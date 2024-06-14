using Rhino.Geometry;
using Speckle.ProxyGenerator;
using Speckle.Rhino7.Interfaces;

namespace Speckle.Rhino7.Api;

[Proxy(
  typeof(Curve),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Duplicate" }
)]
public partial interface IRhinoCurveProxy : IRhinoCurve;

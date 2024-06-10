using Autodesk.Revit.DB;
using Autodesk.Revit.DB.PointClouds;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

[Proxy(typeof(Units), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitUnitsProxy : IRevitUnits;

[Proxy(
  typeof(FormatOptions),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitFormatOptionsProxy : IRevitFormatOptions;

[Proxy(
  typeof(Transform),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] { "Basis" }
)]
public partial interface IRevitTransformProxy : IRevitTransform;

public partial class TransformProxy
{
  public void Dispose() => _Instance.Dispose();
}

[Proxy(
  typeof(BasePoint),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitBasePointProxy : IRevitBasePoint;

public partial class BasePointProxy
{
  public IRevitParameter GetParameter(RevitBuiltInParameter parameter) =>
    new ParameterProxy(_Instance.get_Parameter((BuiltInParameter)parameter));
}

[Proxy(
  typeof(Parameter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"IsReadOnly"}
)]
public partial interface IRevitParameterProxy : IRevitParameter;
public partial class ParameterProxy
{
  public bool IsReadOnly => _Instance.IsReadOnly;
}

[Proxy(
  typeof(PolyLine),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitPolyLineProxy : IRevitPolyLine;
[Proxy(
  typeof(Point),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitPointProxy : IRevitPoint;
[Proxy(
  typeof(Plane),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface 
)]
public partial interface IRevitPlaneProxy : IRevitPlane;

public partial class PlaneProxy
{
  public void Dispose() => _Instance.Dispose();
}
[Proxy(
  typeof(Arc),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitArcProxy : IRevitArc;
[Proxy(
  typeof(BoundingBoxXYZ),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"BoundEnabled", "MaxEnabled", "MinEnabled","Bounds"}
)]
public partial interface IRevitBoundingBoxXYZProxy : IRevitBoundingBoxXYZ;

[Proxy(
  typeof(Line),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitLineProxy : IRevitLine;
[Proxy(
  typeof(Mesh),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"Transformed", "Triangle"}
)]
public partial interface IRevitMeshProxy : IRevitMesh;

public partial class MeshProxy
{
  public IRevitMeshTriangle GetTriangle(int index) => new MeshTriangleProxy(_Instance.get_Triangle(index));
}
[Proxy(
  typeof(Material),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitMaterialProxy : IRevitMaterial;
[Proxy(
  typeof(MeshTriangle),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new [] {"Vertex", "Index"}
)]
public partial interface IRevitMeshTriangleProxy : IRevitMeshTriangle;
public partial class MeshTriangleProxy
{
  public uint GetIndex(int index) => _Instance.get_Index(index);
}

[Proxy(
  typeof(NurbSpline),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitNurbSplineProxy : IRevitNurbSpline;

public partial class NurbSplineProxy
{
  public bool IsRational => _Instance.isRational;
}
[Proxy(
  typeof(HermiteSpline),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitHermiteSplineProxy : IRevitHermiteSpline;
[Proxy(
  typeof(PointCloudInstance),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitPointCloudInstanceProxy : IRevitPointCloudInstance;
[Proxy(
  typeof(Instance),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitInstanceProxy : IRevitInstance;

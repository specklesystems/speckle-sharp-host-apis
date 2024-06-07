using Autodesk.Revit.DB;
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

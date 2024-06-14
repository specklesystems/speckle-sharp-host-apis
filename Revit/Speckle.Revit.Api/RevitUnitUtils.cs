using Autodesk.Revit.DB;
using Mapster.Utils;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

public class RevitUnitUtils : IRevitUnitUtils
{
  public double ConvertFromInternalUnits(double value, IRevitForgeTypeId forgeTypeId) =>
    UnitUtils.ConvertFromInternalUnits(value, ((ForgeTypeIdProxy)forgeTypeId)._Instance);

  public IRevitForgeTypeId Length => new ForgeTypeIdProxy(SpecTypeId.Length);
  public IRevitForgeTypeId Millimeters => new ForgeTypeIdProxy(UnitTypeId.Millimeters);
  public IRevitForgeTypeId Centimeters => new ForgeTypeIdProxy(UnitTypeId.Centimeters);
  public IRevitForgeTypeId Meters => new ForgeTypeIdProxy(UnitTypeId.Meters);
  public IRevitForgeTypeId MetersCentimeters => new ForgeTypeIdProxy(UnitTypeId.MetersCentimeters);
  public IRevitForgeTypeId Inches => new ForgeTypeIdProxy(UnitTypeId.Inches);
  public IRevitForgeTypeId FractionalInches => new ForgeTypeIdProxy(UnitTypeId.FractionalInches);
  public IRevitForgeTypeId Feet => new ForgeTypeIdProxy(UnitTypeId.Feet);
  public IRevitForgeTypeId FeetFractionalInches => new ForgeTypeIdProxy(UnitTypeId.FeetFractionalInches);
}

public class RevitTransformUtils : IRevitTransformUtils
{
  public IRevitTransform Identity => new TransformProxy(Transform.Identity);

  public IRevitTransform CreateTranslation(IRevitXYZ vector) =>
    new TransformProxy(Transform.CreateTranslation(((XYZProxy)vector)._Instance));

  public IRevitTransform CreateRotation(IRevitXYZ axis, double angle) =>
    new TransformProxy(Transform.CreateRotation(((XYZProxy)axis)._Instance, angle));
}

public class RevitXYZUtils : IRevitXYZUtils
{
  public IRevitXYZ Zero => new XYZProxy(XYZ.Zero);
  public IRevitXYZ BasisX => new XYZProxy(XYZ.BasisX);
  public IRevitXYZ BasisY => new XYZProxy(XYZ.BasisY);
  public IRevitXYZ BasisZ => new XYZProxy(XYZ.BasisZ);
}

public class RevitElementIdUtils : IRevitElementIdUtils
{
  public IRevitElementId InvalidElementId => new ElementIdProxy(ElementId.InvalidElementId);
}

public class RevitPlaneUtils : IRevitPlaneUtils
{
  public IRevitPlane CreateByOriginAndBasis(IRevitXYZ center, IRevitXYZ xDirection, IRevitXYZ yDirection) =>
    new PlaneProxy(
      Plane.CreateByOriginAndBasis(
        ((XYZProxy)center)._Instance,
        ((XYZProxy)xDirection)._Instance,
        ((XYZProxy)yDirection)._Instance
      )
    );

  public IRevitPlane CreateByNormalAndOrigin(IRevitXYZ normal, IRevitXYZ center) =>
    new PlaneProxy(Plane.CreateByNormalAndOrigin(((XYZProxy)normal)._Instance, ((XYZProxy)center)._Instance));
}

public class RevitNurbSplineUtils : IRevitNurbSplineUtils
{
  public IRevitNurbSpline Create(IRevitHermiteSpline hermiteSpline) =>
    new NurbSplineProxy(NurbSpline.Create(((HermiteSplineProxy)hermiteSpline)._Instance));
}

public class RevitFormatOptionsUtils : IRevitFormatOptionsUtils
{
  public bool CanHaveSymbol(IRevitForgeTypeId forgeTypeId) =>
    FormatOptions.CanHaveSymbol(((ForgeTypeIdProxy)forgeTypeId)._Instance);

  public IList<IRevitForgeTypeId> GetValidSymbols(IRevitForgeTypeId forgeTypeId) =>
    FormatOptions
      .GetValidSymbols(((ForgeTypeIdProxy)forgeTypeId)._Instance)
      .Select(x => new ForgeTypeIdProxy(x))
      .ToList<IRevitForgeTypeId>();

  public string GetLabelForSymbol(IRevitForgeTypeId symbolId) =>
    LabelUtils.GetLabelForSymbol(((ForgeTypeIdProxy)symbolId)._Instance);
}

public class RevitSolidUtils : IRevitSolidUtils
{
  public IRevitSolid CreateTransformed(IRevitSolid solid, IRevitTransform inverseTransform) =>
    new SolidProxy(
      SolidUtils.CreateTransformed(((SolidProxy)solid)._Instance, ((TransformProxy)inverseTransform)._Instance)
    );
}

public class RevitOptionsFactory : IRevitOptionsFactory
{
  public IRevitOptions Create(RevitViewDetailLevel viewDetailLevel) =>
    new OptionsProxy(
      new Options() { DetailLevel = EnumUtility<RevitViewDetailLevel, ViewDetailLevel>.Convert(viewDetailLevel) }
    );
}

public class ProxyMapper : IProxyMapper
{
  public Type? GetMappedTypeFromHostType(Type type) => ProxyMap.GetMappedTypeFromHostType(type);

  public Type? GetMappedTypeFromProxyType(Type type) => ProxyMap.GetMappedTypeFromProxyType(type);

  public Type? GetHostTypeFromMappedType(Type type) => ProxyMap.GetHostTypeFromMappedType(type);

  public object CreateProxy(Type type, object toWrap) => ProxyMap.CreateProxy(type, toWrap);
  public T CreateProxy<T>(object toWrap) => ProxyMap.CreateProxy<T>(toWrap);
}

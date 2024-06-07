using Autodesk.Revit.DB;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

public class RevitUnitUtils : IRevitUnitUtils
{
  public double ConvertFromInternalUnits(double value, IRevitForgeTypeId forgeTypeId) =>
    UnitUtils.ConvertFromInternalUnits(value, ((ForgeTypeIdProxy)forgeTypeId)._Instance);

  public IRevitForgeTypeId Length => new ForgeTypeIdProxy(SpecTypeId.Length);
}

public class RevitTransformUtils : IRevitTransformUtils
{
  public IRevitTransform Identity => new TransformProxy(Transform.Identity);
  
  public IRevitTransform CreateTranslation(IRevitXYZ vector) => new TransformProxy(Transform.CreateTranslation(((XYZProxy)vector)._Instance));
  
  public IRevitTransform CreateRotation(IRevitXYZ axis, double angle) => new TransformProxy(Transform.CreateRotation(((XYZProxy)axis)._Instance, angle));
}

public class RevitXYZUtils : IRevitXYZUtils
{
  public IRevitXYZ Zero => new XYZProxy(XYZ.Zero);
  public IRevitXYZ BasisX => new XYZProxy(XYZ.BasisX);
  public IRevitXYZ BasisY=> new XYZProxy(XYZ.BasisY);
  public IRevitXYZ BasisZ => new XYZProxy(XYZ.BasisZ);
}

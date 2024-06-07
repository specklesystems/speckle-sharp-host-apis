namespace Speckle.Revit.Interfaces;

public interface IRevitTransform : IRevitObject
{
  IRevitXYZ OfPoint(IRevitXYZ inbound);
  IRevitXYZ OfVector(IRevitXYZ inbound);
  IRevitTransform Multiply(IRevitTransform right);
}

public interface IRevitTransformUtils
{
  IRevitTransform Identity { get; }
  IRevitTransform CreateTranslation(IRevitXYZ vector);
  IRevitTransform CreateRotation(IRevitXYZ axis, double angle);
}

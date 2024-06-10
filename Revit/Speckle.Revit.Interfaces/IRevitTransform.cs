namespace Speckle.Revit.Interfaces;

public interface IRevitTransform : IRevitObject, IDisposable
{
  IRevitXYZ OfPoint(IRevitXYZ inbound);
  IRevitXYZ OfVector(IRevitXYZ inbound);
  IRevitTransform Multiply(IRevitTransform right);
  IRevitXYZ Origin { get; }
  IRevitXYZ BasisX { get; }
  IRevitXYZ BasisY { get; }
  IRevitTransform Inverse { get; }
}

public interface IRevitTransformUtils
{
  IRevitTransform Identity { get; }
  IRevitTransform CreateTranslation(IRevitXYZ vector);
  IRevitTransform CreateRotation(IRevitXYZ axis, double angle);
}

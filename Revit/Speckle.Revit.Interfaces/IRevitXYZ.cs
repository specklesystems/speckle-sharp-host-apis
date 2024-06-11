namespace Speckle.Revit.Interfaces;

public interface IRevitXYZ: IRevitObject
{
  double Z { get; }

  double Y { get; }

  double X { get; }
  double DistanceTo(IRevitXYZ source);

  IRevitXYZ Multiply(double value);
  IRevitXYZ Divide(double value);
  IRevitXYZ Add(IRevitXYZ source);
  IRevitXYZ Subtract(IRevitXYZ source);
  IRevitXYZ Normalize();
  double AngleOnPlaneTo(IRevitXYZ right, IRevitXYZ normal);
  IRevitXYZ Negate();
}

public interface IRevitBoundingBoxXYZ
{
  
  IRevitXYZ Min { get; }
  IRevitXYZ Max { get; }
  IRevitTransform Transform { get; }
}

public interface IRevitXYZUtils 
{
  IRevitXYZ Zero { get; }
  IRevitXYZ BasisX { get; }
  IRevitXYZ BasisY { get; }
  IRevitXYZ BasisZ { get; }
}

public interface IRevitElementIdUtils
{
  IRevitElementId InvalidElementId { get; }
}

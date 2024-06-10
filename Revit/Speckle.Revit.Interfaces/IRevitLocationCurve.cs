namespace Speckle.Revit.Interfaces;

public interface IRevitLocationCurve : IRevitLocation
{
  IRevitCurve Curve { get; }
}

public interface IRevitPolyLine : IRevitGeometryObject
{
  IList<IRevitXYZ> GetCoordinates();
}

public interface IRevitGeometryObject : IRevitObject
{
}

public interface IRevitPoint : IRevitObject
{
  IRevitXYZ Coord { get; }
}

public interface IRevitPlane : IRevitSurface {
IRevitXYZ Origin { get; }
  IRevitXYZ Normal { get; }
  IRevitXYZ XVec { get; }
  IRevitXYZ YVec { get; }
}

public interface IRevitSurface : IRevitObject
{
}

public interface IRevitArc : IRevitCurve
{
  IRevitXYZ Center { get; }
  IRevitXYZ XDirection { get; }
  IRevitXYZ YDirection { get; }
  
  double Radius { get; }
  IRevitXYZ Normal { get; }
}

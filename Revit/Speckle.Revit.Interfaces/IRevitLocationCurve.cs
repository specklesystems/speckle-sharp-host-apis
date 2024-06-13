using System;
using System.Collections.Generic;

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
  IRevitElementId GraphicsStyleId { get; }
  IRevitSolid? ToSolid();
  IRevitMesh? ToMesh();
  IRevitGeometryInstance? ToGeometryInstance();
  IRevitGeometryElement? ToGeometryElement();
}

public interface IRevitPoint : IRevitObject
{
  IRevitXYZ Coord { get; }
}

public interface IRevitPlane : IRevitSurface
{
  IRevitXYZ Origin { get; }
  IRevitXYZ Normal { get; }
  IRevitXYZ XVec { get; }
  IRevitXYZ YVec { get; }
}

public interface IRevitSurface : IRevitObject, IDisposable;

public interface IRevitLine : IRevitCurve;

public interface IRevitArc : IRevitCurve
{
  IRevitXYZ Center { get; }
  IRevitXYZ XDirection { get; }
  IRevitXYZ YDirection { get; }

  double Radius { get; }
  IRevitXYZ Normal { get; }
  bool IsClosed { get; }
}

public interface IRevitMesh : IRevitGeometryObject
{
  IList<IRevitXYZ> Vertices { get; }
  IRevitElementId MaterialElementId { get; }
  int NumTriangles { get; }
  IRevitMeshTriangle GetTriangle(int index);
  IRevitMesh GetTransformed(IRevitTransform transform);
}

public interface IRevitMaterial : IRevitElement
{
  int Transparency { get; }
  IRevitColor Color { get; }
}

public interface IRevitColor
{
  byte Red { get; }
  byte Green { get; }
  byte Blue { get; }
}

public interface IRevitMeshTriangle
{
  uint GetIndex(int idx);
}

public interface IRevitHermiteSpline : IRevitCurve;

public interface IRevitNurbSpline : IRevitCurve
{
  IList<IRevitXYZ> CtrlPoints { get; }
  IRevitDoubleArray Weights { get; }
  IRevitDoubleArray Knots { get; }
  int Degree { get; }
  bool IsRational { get; }
  bool IsClosed { get; }
}

public interface IRevitDoubleArray : IReadOnlyList<double>;

public interface IRevitGeometryInstance : IRevitGeometryObject
{
  IRevitGeometryElement GetSymbolGeometry();
  IRevitGeometryElement GetInstanceGeometry();
}

public interface IRevitGraphicsStyle : IRevitElement
{
  IRevitCategory GraphicsStyleCategory { get; }
}

public interface IRevitBoundarySegment : IRevitObject
{
  IRevitCurve GetCurve();
}

public interface IRevitCeiling : IRevitCeilingAndFloor
{
  IRevitElementId SketchId { get; }
}

public interface IRevitCeilingAndFloor : IRevitHostObject;

public interface IRevitSketch : IRevitSketchBase
{
  IRevitCurveArrArray Profile { get; }

  IList<IRevitElementId> GetAllElements();
}

public interface IRevitDirectShape : IRevitElement;

public interface IRevitExtrusionRoof : IRevitRoofBase
{
  IRevitModelCurveArray GetProfile();
}

public interface IRevitSketchBase : IRevitElement;

public interface IRevitRoofBase : IRevitHostObject;

public interface IRevitSketchPlane : IRevitElement
{
  IRevitPlane GetPlane();
}

public interface IRevitRoom : IRevitSpatialElement;

public interface IRevitSpatialElement : IRevitElement
{
  IEnumerable<IEnumerable<IRevitBoundarySegment>> GetBoundarySegments();
  string Number { get; }
  IRevitLevel Level { get; }
}

public interface IRevitTopographySurface : IRevitElement;

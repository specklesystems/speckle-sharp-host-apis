#nullable enable
namespace Speckle.Revit.Interfaces;

public interface IRevitSolid : IRevitGeometryObject
{
  IRevitFaceArray Faces { get; }
  double SurfaceArea { get; }
}

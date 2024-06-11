namespace Speckle.Revit.Interfaces;

public interface IRevitCurve : IRevitGeometryObject
{
  IRevitXYZ GetEndPoint(int index);
  double Length { get; }
  IRevitXYZ Evaluate(double parameter, bool normalized);
  double GetEndParameter(int index);
  bool IsBound { get; }
  IList<IRevitXYZ> Tessellate();
}

public interface IRevitCloudPoint
{   float X  { get; }
   float Y  { get; }
   float Z  { get; }
   int Color { get; }
  IRevitXYZ ToXYZ();
}

public interface IRevitCloudPointList : IEnumerable<IRevitCloudPoint>
{
}

public interface IRevitPointCloudInstance : IRevitInstance
{
  IRevitCloudPointList GetPoints(
   IRevitPointCloudFilter filter,
    double averageDistance,
    int numPoints);
}
public interface IRevitInstance :IRevitElement
{
  IRevitTransform GetTransform();
}
public interface IRevitCurveArray : IReadOnlyList<IRevitCurve>
{
  
}

public interface IRevitCurveArrArray : IReadOnlyList<IRevitCurveArray>
{
}

public interface IRevitEllipse : IRevitCurve
{
  IRevitXYZ Center { get; }
  IRevitXYZ XDirection { get; }
  IRevitXYZ YDirection { get; }
  double RadiusX { get; }
  double RadiusY { get; }
}

public interface IRevitLevel : IRevitDatumPlane
{
  double Elevation { get; }
}

public interface IRevitDatumPlane : IRevitElement
{
}

public interface IRevitFamilyInstance : IRevitInstance
{
  IRevitFamilySymbol Symbol { get; }
  bool FacingFlipped { get; }
  bool HandFlipped { get; }
  bool IsSlantedColumn { get; }
  RevitStructuralType StructuralType { get; }
} 
public enum RevitStructuralType
{
  NonStructural,
  Beam,
  Brace,
  Column,
  Footing,
  UnknownFraming,
}

public interface IRevitOptionsFactory
{
  IRevitOptions Create(RevitViewDetailLevel viewDetailLevel);
}
public enum RevitViewDetailLevel
{
  Undefined,
  Coarse,
  Medium,
  Fine,
}
public interface IRevitOptions
{
  RevitViewDetailLevel DetailLevel { get; }
  bool ComputeReferences { get; set; }
}

public interface IRevitGroup : IRevitElement
{
  IList<IRevitElementId> GetMemberIds();
}

public interface IRevitSolid : IRevitGeometryObject
{
  IRevitFaceArray Faces { get; }
  double SurfaceArea { get; }
}
public interface IRevitFace
{
  IRevitMesh Triangulate();
  IRevitElementId MaterialElementId { get; }
}
public interface IRevitFaceArray : IReadOnlyList<IRevitFace> {}

public interface IRevitGeometryElement : IRevitGeometryObject, IEnumerable<IRevitGeometryObject>
{
}

public interface IRevitFloor : IRevitCeilingAndFloor
{
  
  IRevitElementId SketchId { get; }
  
}
public interface IRevitModelLine : IRevitModelCurve
{
  
}
public interface IRevitFootPrintRoof : IRevitRoofBase
{
  IRevitModelCurveArrArray GetProfiles();
}

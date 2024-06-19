using System.Collections;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Mapster.Utils;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;
using Speckle.Shared;

namespace Speckle.Revit.Api;

[Proxy(typeof(Units))]
public partial interface IRevitUnitsProxy : IRevitUnits;

[Proxy(
  typeof(FormatOptions)
)]
public partial interface IRevitFormatOptionsProxy : IRevitFormatOptions;

[Proxy(typeof(Transform), new[] { "Basis" })]
public partial interface IRevitTransformProxy : IRevitTransform;

public partial class TransformProxy
{
  public void Dispose() => _Instance.Dispose();
}

[Proxy(typeof(BasePoint))]
public partial interface IRevitBasePointProxy : IRevitBasePoint;

[Proxy(typeof(ParameterSet))]
public partial interface IRevitParameterSetProxy : IRevitParameterSet;

public partial class ParameterSetProxy
{
  public void Dispose() => _Instance.Dispose();

  IEnumerator<IRevitParameter> IEnumerable<IRevitParameter>.GetEnumerator() =>
    new ParameterSetProxyIterator(_Instance.ForwardIterator());

  private readonly struct ParameterSetProxyIterator : IEnumerator<IRevitParameter>
  {
    private readonly ParameterSetIterator _curveArrayIterator;

    public ParameterSetProxyIterator(ParameterSetIterator curveArrayIterator)
    {
      _curveArrayIterator = curveArrayIterator;
    }

    public void Dispose() => _curveArrayIterator.Dispose();

    public bool MoveNext() => _curveArrayIterator.MoveNext();

    public void Reset() => _curveArrayIterator.Reset();

    object IEnumerator.Current => Current;

    public IRevitParameter Current => new ParameterProxy((Parameter)_curveArrayIterator.Current);
  }
}

[Proxy(typeof(Parameter), new[] { "IsReadOnly", "StorageType" })]
public partial interface IRevitParameterProxy : IRevitParameter;

public partial class ParameterProxy
{
  public bool IsReadOnly => _Instance.IsReadOnly;
  public RevitStorageType StorageType => EnumUtility<StorageType, RevitStorageType>.Convert(_Instance.StorageType);
}

[Proxy(typeof(Definition))]
public partial interface IRevitDefinitionProxy : IRevitDefinition;

public partial class DefinitionProxy
{
  public IRevitInternalDefinition? ToInternal()
  {
    var id = _Instance as InternalDefinition;
    if (id is null)
    {
      return null;
    }

    return new InternalDefinitionProxy(id);
  }
}

[Proxy(
  typeof(InternalDefinition),
  new[] { "ParameterGroup", "Name", "GetGroupTypeId", "BuiltInParameter", "get_ParameterGroup", "set_ParameterGroup" }
)]
public partial interface IRevitInternalDefinitionProxy : IRevitInternalDefinition;

public partial class InternalDefinitionProxy
{
  public RevitBuiltInParameter BuiltInParameter =>
    EnumUtility<BuiltInParameter, RevitBuiltInParameter>.Convert(_Instance.BuiltInParameter);
}

[Proxy(typeof(PolyLine))]
public partial interface IRevitPolyLineProxy : IRevitPolyLine;

[Proxy(typeof(Point))]
public partial interface IRevitPointProxy : IRevitPoint;

[Proxy(typeof(Plane))]
public partial interface IRevitPlaneProxy : IRevitPlane;

public partial class PlaneProxy
{
  public void Dispose() => _Instance.Dispose();
}

[Proxy(typeof(Arc))]
public partial interface IRevitArcProxy : IRevitArc;

[Proxy(typeof(BoundingBoxXYZ), new[] { "BoundEnabled", "MaxEnabled", "MinEnabled", "Bounds" })]
public partial interface IRevitBoundingBoxXYZProxy : IRevitBoundingBoxXYZ;

[Proxy(typeof(Line))]
public partial interface IRevitLineProxy : IRevitLine;

[Proxy(typeof(Mesh), new[] { "Transformed", "Triangle" })]
public partial interface IRevitMeshProxy : IRevitMesh;

public partial class MeshProxy
{
  public IRevitMeshTriangle GetTriangle(int index) => new MeshTriangleProxy(_Instance.get_Triangle(index));

  public IRevitMesh GetTransformed(IRevitTransform inverseTransform) =>
    new MeshProxy(_Instance.get_Transformed(((TransformProxy)inverseTransform)._Instance));
}

[Proxy(typeof(Material))]
public partial interface IRevitMaterialProxy : IRevitMaterial;

[Proxy(typeof(MeshTriangle), new[] { "Vertex", "Index" })]
public partial interface IRevitMeshTriangleProxy : IRevitMeshTriangle;

public partial class MeshTriangleProxy
{
  public uint GetIndex(int index) => _Instance.get_Index(index);
}

[Proxy(typeof(NurbSpline))]
public partial interface IRevitNurbSplineProxy : IRevitNurbSpline;

public partial class NurbSplineProxy
{
  public bool IsRational => _Instance.isRational;
}

[Proxy(
  typeof(HermiteSpline)
)]
public partial interface IRevitHermiteSplineProxy : IRevitHermiteSpline;

[Proxy(
  typeof(PointCloudInstance)
)]
public partial interface IRevitPointCloudInstanceProxy : IRevitPointCloudInstance;

[Proxy(typeof(Instance))]
public partial interface IRevitInstanceProxy : IRevitInstance;

[Proxy(typeof(Level))]
public partial interface IRevitLevelProxy : IRevitLevel;

[Proxy(typeof(FamilyInstance), new[] { "ToRoom", "FromRoom", "Space", "Room", "StructuralType", "Location" })]
public partial interface IRevitFamilyInstanceProxy : IRevitFamilyInstance;

public partial class FamilyInstanceProxy
{
  public RevitStructuralType StructuralType =>
    EnumUtility<Autodesk.Revit.DB.Structure.StructuralType, RevitStructuralType>.Convert(_Instance.StructuralType);
}

[Proxy(typeof(Solid))]
public partial interface IRevitSolidProxy : IRevitSolid;

[Proxy(typeof(Group), new[] { "Location" })]
public partial interface IRevitGroupProxy : IRevitGroup;

[Proxy(typeof(GeometryObject), new[] { "Equals" })]
public partial interface IRevitGeometryObjectProxy : IRevitGeometryObject;

public partial class GeometryObjectProxy
{
  public IRevitSolid? ToSolid()
  {
    if (_Instance is Solid m)
    {
      return new SolidProxy(m);
    }

    return null;
  }

  public IRevitMesh? ToMesh()
  {
    if (_Instance is Mesh m)
    {
      return new MeshProxy(m);
    }

    return null;
  }

  public IRevitGeometryInstance? ToGeometryInstance()
  {
    if (_Instance is GeometryInstance m)
    {
      return new GeometryInstanceProxy(m);
    }

    return null;
  }

  public IRevitGeometryElement? ToGeometryElement()
  {
    if (_Instance is GeometryElement m)
    {
      return new GeometryElementProxy(m);
    }

    return null;
  }
}

[Proxy(typeof(Options), new[] { "DetailLevel" })]
public partial interface IRevitOptionsProxy : IRevitOptions;

public partial class OptionsProxy
{
  public RevitViewDetailLevel DetailLevel =>
    EnumUtility<ViewDetailLevel, RevitViewDetailLevel>.Convert(_Instance.DetailLevel);
}

[Proxy(typeof(Face), new[] { "Period", "IsCyclic" })]
public partial interface IRevitFaceProxy : IRevitFace;

[Proxy(typeof(FaceArray), new[] { "Item", "get_Item", "set_Item" })]
public partial interface IRevitFaceArrayProxy : IRevitFaceArray;

public partial class FaceArrayProxy
{
  public int Count => _Instance.Size;
  public IRevitFace this[int index] => new FaceProxy(_Instance.get_Item(index));

  IEnumerator<IRevitFace> IEnumerable<IRevitFace>.GetEnumerator() =>
    new ParameterSetProxyIterator(_Instance.ForwardIterator());

  private readonly struct ParameterSetProxyIterator : IEnumerator<IRevitFace>
  {
    private readonly FaceArrayIterator _curveArrayIterator;

    public ParameterSetProxyIterator(FaceArrayIterator curveArrayIterator)
    {
      _curveArrayIterator = curveArrayIterator;
    }

    public void Dispose() => _curveArrayIterator.Dispose();

    public bool MoveNext() => _curveArrayIterator.MoveNext();

    public void Reset() => _curveArrayIterator.Reset();

    object IEnumerator.Current => Current;

    public IRevitFace Current => new FaceProxy((Face)_curveArrayIterator.Current);
  }
}

[Proxy(typeof(GeometryElement), new[] { "GetEnumerator" })]
public partial interface IRevitGeometryElementProxy : IRevitGeometryElement;

public partial class GeometryElementProxy
{
  IEnumerator IEnumerable.GetEnumerator() => new GeometryElementProxyIterator(_Instance.GetEnumerator());

  IEnumerator<IRevitGeometryObject> IEnumerable<IRevitGeometryObject>.GetEnumerator() =>
    new GeometryElementProxyIterator(_Instance.GetEnumerator());

  private readonly struct GeometryElementProxyIterator : IEnumerator<IRevitGeometryObject>
  {
    private readonly IEnumerator<GeometryObject> _curveArrayIterator;

    public GeometryElementProxyIterator(IEnumerator<GeometryObject> curveArrayIterator)
    {
      _curveArrayIterator = curveArrayIterator;
    }

    public void Dispose() => _curveArrayIterator.Dispose();

    public bool MoveNext() => _curveArrayIterator.MoveNext();

    public void Reset() => _curveArrayIterator.Reset();

    object IEnumerator.Current => Current;

    public IRevitGeometryObject Current => new GeometryObjectProxy((GeometryObject)_curveArrayIterator.Current);
  }
}

[Proxy(
  typeof(GeometryInstance)
)]
public partial interface IRevitGeometryInstanceProxy : IRevitGeometryInstance;

[Proxy(
  typeof(GraphicsStyle)
)]
public partial interface IRevitGraphicsStyleProxy : IRevitGraphicsStyle;

[Proxy(
  typeof(BoundarySegment)
)]
public partial interface IRevitBoundarySegmentProxy : IRevitBoundarySegment;

[Proxy(typeof(Color))]
public partial interface IRevitColorProxy : IRevitColor;

[Proxy(typeof(Ceiling))]
public partial interface IRevitCeilingProxy : IRevitCeiling;

[Proxy(
  typeof(CeilingAndFloor)
)]
public partial interface IRevitCeilingAndFloorProxy : IRevitCeilingAndFloor;

[Proxy(typeof(Sketch))]
public partial interface IRevitSketchProxy : IRevitSketch;

[Proxy(typeof(SketchBase))]
public partial interface IRevitSketchBaseProxy : IRevitSketchBase;

[Proxy(typeof(DirectShape))]
public partial interface IRevitDirectShapeProxy : IRevitDirectShape;

[Proxy(
  typeof(ExtrusionRoof)
)]
public partial interface IRevitExtrusionRoofProxy : IRevitExtrusionRoof;

[Proxy(typeof(RoofBase))]
public partial interface IRevitRoofBaseProxy : IRevitRoofBase;

[Proxy(typeof(SketchPlane))]
public partial interface IRevitSketchPlaneProxy : IRevitSketchPlane;

[Proxy(typeof(Floor))]
public partial interface IRevitFloorProxy : IRevitFloor;

[Proxy(typeof(ModelLine))]
public partial interface IRevitModelLineProxy : IRevitModelLine;

[Proxy(typeof(FootPrintRoof), new[] { "Overhang", "ExtendIntoWall", "Offset", "SlopeAngle", "DefinesSlope" })]
public partial interface IRevitFootPrintRoofProxy : IRevitFootPrintRoof;

[Proxy(typeof(Room))]
public partial interface IRevitRoomProxy : IRevitRoom;

[Proxy(
  typeof(TopographySurface)
)]
public partial interface IRevitTopographySurfaceProxy : IRevitTopographySurface;

[Proxy(typeof(SpatialElement), new[] { "GetBoundarySegments", "Location" })]
public partial interface IRevitSpatialElementProxy : IRevitSpatialElement;

public partial class SpatialElementProxy
{
  public IEnumerable<IEnumerable<IRevitBoundarySegment>> GetBoundarySegments()
  {
    var segments = _Instance.GetBoundarySegments(new SpatialElementBoundaryOptions());
    foreach (var seg in segments)
    {
      yield return GetSegments(seg);
    }
  }

  private static IEnumerable<IRevitBoundarySegment> GetSegments(IList<BoundarySegment> segments) =>
    segments.Select(seg => new BoundarySegmentProxy(seg));
}

[Proxy(typeof(Panel), new[] { "GetRefGridLines" })]
public partial interface IRevitPanelProxy : IRevitPanel;

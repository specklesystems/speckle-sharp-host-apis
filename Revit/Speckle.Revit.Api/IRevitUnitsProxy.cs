using System.Collections;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Mapster.Utils;
using Speckle.ProxyGenerator;
using Speckle.Revit.Interfaces;

namespace Speckle.Revit.Api;

[Proxy(typeof(Units), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitUnitsProxy : IRevitUnits;

[Proxy(
  typeof(FormatOptions),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitFormatOptionsProxy : IRevitFormatOptions;

[Proxy(
  typeof(Transform),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Basis" }
)]
public partial interface IRevitTransformProxy : IRevitTransform;

public partial class TransformProxy
{
  public void Dispose() => _Instance.Dispose();
}

[Proxy(typeof(BasePoint), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitBasePointProxy : IRevitBasePoint;

[Proxy(typeof(ParameterSet), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
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

[Proxy(
  typeof(Parameter),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "IsReadOnly", "StorageType" }
)]
public partial interface IRevitParameterProxy : IRevitParameter;

public partial class ParameterProxy
{
  public bool IsReadOnly => _Instance.IsReadOnly;
  public IRevitStorageType StorageType => Enum<IRevitStorageType>.Parse(_Instance.StorageType.ToString());
}

[Proxy(typeof(Definition), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
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
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "ParameterGroup", "Name", "GetGroupTypeId", "BuiltInParameter", "get_ParameterGroup", "set_ParameterGroup" }
)]
public partial interface IRevitInternalDefinitionProxy : IRevitInternalDefinition;

public partial class InternalDefinitionProxy
{
  public RevitBuiltInParameter BuiltInParameter =>
    Enum<RevitBuiltInParameter>.Parse(_Instance.BuiltInParameter.ToString());
}

[Proxy(typeof(PolyLine), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitPolyLineProxy : IRevitPolyLine;

[Proxy(typeof(Point), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitPointProxy : IRevitPoint;

[Proxy(typeof(Plane), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitPlaneProxy : IRevitPlane;

public partial class PlaneProxy
{
  public void Dispose() => _Instance.Dispose();
}

[Proxy(typeof(Arc), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitArcProxy : IRevitArc;

[Proxy(
  typeof(BoundingBoxXYZ),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "BoundEnabled", "MaxEnabled", "MinEnabled", "Bounds" }
)]
public partial interface IRevitBoundingBoxXYZProxy : IRevitBoundingBoxXYZ;

[Proxy(typeof(Line), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitLineProxy : IRevitLine;

[Proxy(
  typeof(Mesh),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Transformed", "Triangle" }
)]
public partial interface IRevitMeshProxy : IRevitMesh;

public partial class MeshProxy
{
  public IRevitMeshTriangle GetTriangle(int index) => new MeshTriangleProxy(_Instance.get_Triangle(index));

  public IRevitMesh GetTransformed(IRevitTransform inverseTransform) =>
    new MeshProxy(_Instance.get_Transformed(((TransformProxy)inverseTransform)._Instance));
}

[Proxy(typeof(Material), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitMaterialProxy : IRevitMaterial;

[Proxy(
  typeof(MeshTriangle),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Vertex", "Index" }
)]
public partial interface IRevitMeshTriangleProxy : IRevitMeshTriangle;

public partial class MeshTriangleProxy
{
  public uint GetIndex(int index) => _Instance.get_Index(index);
}

[Proxy(typeof(NurbSpline), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitNurbSplineProxy : IRevitNurbSpline;

public partial class NurbSplineProxy
{
  public bool IsRational => _Instance.isRational;
}

[Proxy(
  typeof(HermiteSpline),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitHermiteSplineProxy : IRevitHermiteSpline;

[Proxy(
  typeof(PointCloudInstance),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitPointCloudInstanceProxy : IRevitPointCloudInstance;

[Proxy(typeof(Instance), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitInstanceProxy : IRevitInstance;

[Proxy(typeof(Level), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitLevelProxy : IRevitLevel;

[Proxy(
  typeof(FamilyInstance),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "ToRoom", "FromRoom", "Space", "Room", "StructuralType" }
)]
public partial interface IRevitFamilyInstanceProxy : IRevitFamilyInstance;

public partial class FamilyInstanceProxy
{
  public RevitStructuralType StructuralType => Enum<RevitStructuralType>.Parse(_Instance.StructuralType.ToString());
}

[Proxy(typeof(Solid), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitSolidProxy : IRevitSolid;

[Proxy(typeof(Group), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitGroupProxy : IRevitGroup;

[Proxy(
  typeof(GeometryObject),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Equals" }
)]
public partial interface IRevitGeometryObjectProxy : IRevitGeometryObject;

[Proxy(
  typeof(Options),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "DetailLevel" }
)]
public partial interface IRevitOptionsProxy : IRevitOptions;

public partial class OptionsProxy
{
  public RevitViewDetailLevel DetailLevel => Enum<RevitViewDetailLevel>.Parse(_Instance.DetailLevel.ToString());
}

[Proxy(
  typeof(Face),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Period", "IsCyclic" }
)]
public partial interface IRevitFaceProxy : IRevitFace;

[Proxy(
  typeof(FaceArray),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Item", "get_Item", "set_Item" }
)]
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

[Proxy(
  typeof(GeometryElement),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetEnumerator" }
)]
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
  typeof(GeometryInstance),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitGeometryInstanceProxy : IRevitGeometryInstance;

[Proxy(
  typeof(GraphicsStyle),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitGraphicsStyleProxy : IRevitGraphicsStyle;

[Proxy(
  typeof(BoundarySegment),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitBoundarySegmentProxy : IRevitBoundarySegment;

[Proxy(typeof(Color), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitColorProxy : IRevitColor;

[Proxy(typeof(Ceiling), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitCeilingProxy : IRevitCeiling;

[Proxy(
  typeof(CeilingAndFloor),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitCeilingAndFloorProxy : IRevitCeilingAndFloor;

[Proxy(typeof(Sketch), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitSketchProxy : IRevitSketch;

[Proxy(typeof(SketchBase), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitSketchBaseProxy : IRevitSketchBase;

[Proxy(typeof(DirectShape), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitDirectShapeProxy : IRevitDirectShape;

[Proxy(
  typeof(ExtrusionRoof),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitExtrusionRoofProxy : IRevitExtrusionRoof;

[Proxy(typeof(RoofBase), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitRoofBaseProxy : IRevitRoofBase;

[Proxy(typeof(SketchPlane), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitSketchPlaneProxy : IRevitSketchPlane;

[Proxy(typeof(Floor), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitFloorProxy : IRevitFloor;

[Proxy(typeof(ModelLine), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitModelLineProxy : IRevitModelLine;

[Proxy(
  typeof(FootPrintRoof),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "Overhang", "ExtendIntoWall", "Offset", "SlopeAngle", "DefinesSlope" }
)]
public partial interface IRevitFootPrintRoofProxy : IRevitFootPrintRoof;

[Proxy(typeof(Room), ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface)]
public partial interface IRevitRoomProxy : IRevitRoom;

[Proxy(
  typeof(TopographySurface),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface
)]
public partial interface IRevitTopographySurfaceProxy : IRevitTopographySurface;

[Proxy(
  typeof(SpatialElement),
  ImplementationOptions.UseExtendedInterfaces | ImplementationOptions.ProxyForBaseInterface,
  new[] { "GetBoundarySegments" }
)]
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

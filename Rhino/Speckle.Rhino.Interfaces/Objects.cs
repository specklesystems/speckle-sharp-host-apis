namespace Speckle.Rhino7.Interfaces;

public interface IRhinoBrepObject
{
  IRhinoBrep BrepGeometry { get; }
}

public interface IRhinoCurveObject
{
  IRhinoCurve CurveGeometry { get; }
}

public interface IRhinoExtrusionObject
{
  IRhinoExtrusion ExtrusionGeometry { get; }
}

public interface IRhinoExtrusion
{
  IRhinoBrep ToBrep();
}

public interface IRhinoMeshObject
{
  IRhinoMesh MeshGeometry { get; }
}

public interface IRhinoPointCloudObject
{
  IRhinoPointCloud PointCloudGeometry { get; }
}

public interface IRhinoPointObject
{
  IRhinoPoint PointGeometry { get; }
}

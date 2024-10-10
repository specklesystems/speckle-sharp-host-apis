namespace Rhino.FileIO;

public partial class File3dm
{
  public enum ObjectTypeFilter
  {
    None,
    Point,
    Pointset,
    Curve,
    Surface,
    Brep,
    Mesh,
    Annotation,
    InstanceDefinition,
    InstanceReference,
    TextDot,
    DetailView,
    Hatch,
    Extrusion,
    Any,
  }
}

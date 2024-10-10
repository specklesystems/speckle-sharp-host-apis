namespace Rhino.Geometry;

public partial class SpaceMorph
{
  public SpaceMorph() { }

  public virtual System.Boolean Morph(Rhino.Geometry.GeometryBase geometry) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsMorphable(Rhino.Geometry.GeometryBase geometry) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d MorphPoint(Rhino.Geometry.Point3d point) =>
    throw new System.NotImplementedException();

  public virtual System.Double Tolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean QuickPreview
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean PreserveStructure
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Rhino.Geometry;

public partial class SubDCreationOptions : System.IDisposable
{
  public SubDCreationOptions() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public static Rhino.Geometry.SubDCreationOptions Smooth
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.SubDCreationOptions InteriorCreases
  {
    get => throw new System.NotImplementedException();
  }
  public static Rhino.Geometry.SubDCreationOptions ConvexCornersAndInteriorCreases
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.SubDCreationOptions.InteriorCreaseOption InteriorCreaseTest
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.SubDCreationOptions.ConvexCornerOption ConvexCornerTest
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.UInt32 MaximumConvexCornerEdgeCount
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double MaximumConvexCornerAngleRadians
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.SubDCreationOptions.ConcaveCornerOption ConcaveCornerTest
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double MinimumConcaveCornerAngleRadians
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.UInt32 MinimumConcaveCornerEdgeCount
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean InterpolateMeshVertices
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

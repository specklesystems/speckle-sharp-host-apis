namespace Autodesk.Revit.DB;

public partial class Mesh : Autodesk.Revit.DB.GeometryObject
{
  public Mesh() { }

  public virtual Autodesk.Revit.DB.MeshTriangle get_Triangle(System.Int32 idx) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mesh get_Transformed(Autodesk.Revit.DB.Transform transform) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ GetNormal(System.Int32 idx) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> GetNormals() =>
    throw new System.NotImplementedException();

  public virtual System.Double ComputeSurfaceArea() => throw new System.NotImplementedException();

  public virtual System.Boolean IsClosed
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.DistributionOfNormals DistributionOfNormals
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumberOfNormals
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId MaterialElementId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.XYZ> Vertices
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumTriangles
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB;

public partial class Point : Autodesk.Revit.DB.GeometryObject
{
  public Point() { }

  public static Autodesk.Revit.DB.Point Create(Autodesk.Revit.DB.XYZ coord, Autodesk.Revit.DB.ElementId id) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Point Create(Autodesk.Revit.DB.XYZ coord) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference Reference
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Coord
  {
    get => throw new System.NotImplementedException();
  }
}

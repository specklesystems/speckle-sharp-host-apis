namespace Autodesk.Revit.DB.Structure;

public partial class PointLoad : Autodesk.Revit.DB.Structure.LoadBase
{
  public PointLoad() { }

  public static Autodesk.Revit.DB.Structure.PointLoad Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId hostElemId,
    Autodesk.Revit.DB.XYZ point,
    Autodesk.Revit.DB.XYZ forceVector,
    Autodesk.Revit.DB.XYZ momentVector,
    Autodesk.Revit.DB.Structure.PointLoadType symbol
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.PointLoad Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId hostElemId,
    Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector,
    Autodesk.Revit.DB.XYZ forceVector,
    Autodesk.Revit.DB.XYZ momentVector,
    Autodesk.Revit.DB.Structure.PointLoadType symbol
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidHostId(Autodesk.Revit.DB.Document pDoc, Autodesk.Revit.DB.ElementId hostId) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsPointInsideHostBoundaries(
    Autodesk.Revit.DB.Document pDoc,
    Autodesk.Revit.DB.ElementId hostId,
    Autodesk.Revit.DB.XYZ point
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ MomentVector
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ ForceVector
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ Point
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

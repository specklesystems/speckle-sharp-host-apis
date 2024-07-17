namespace Autodesk.Revit.DB.Structure;

public partial class PointLoad : Autodesk.Revit.DB.Structure.LoadBase
{
  public PointLoad() { }

  public static Autodesk.Revit.DB.Structure.PointLoad Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.XYZ point,
    Autodesk.Revit.DB.XYZ forceVector,
    Autodesk.Revit.DB.XYZ momentVector,
    Autodesk.Revit.DB.Structure.PointLoadType symbol,
    Autodesk.Revit.DB.SketchPlane plane
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.PointLoad Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.Structure.AnalyticalModel host,
    Autodesk.Revit.DB.XYZ forceVector,
    Autodesk.Revit.DB.XYZ momentVector,
    Autodesk.Revit.DB.Structure.PointLoadType symbol
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.PointLoad Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.Structure.AnalyticalModelStick host,
    Autodesk.Revit.DB.Structure.AnalyticalElementSelector selector,
    Autodesk.Revit.DB.XYZ forceVector,
    Autodesk.Revit.DB.XYZ momentVector,
    Autodesk.Revit.DB.Structure.PointLoadType symbol
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

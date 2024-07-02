namespace Autodesk.Revit.DB.Structure;

public partial class LineLoad : Autodesk.Revit.DB.Structure.LoadBase
{
  public LineLoad() { }

  public static Autodesk.Revit.DB.Structure.LineLoad Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.XYZ startPoint,
    Autodesk.Revit.DB.XYZ endPoint,
    Autodesk.Revit.DB.XYZ forceVector,
    Autodesk.Revit.DB.XYZ momentVector,
    Autodesk.Revit.DB.Structure.LineLoadType symbol,
    Autodesk.Revit.DB.SketchPlane plane
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.LineLoad Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.ElementId hostElemId,
    System.Int32 curveIndex,
    Autodesk.Revit.DB.XYZ forceVector1,
    Autodesk.Revit.DB.XYZ momentVector1,
    Autodesk.Revit.DB.Structure.LineLoadType symbol
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Structure.LineLoad Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.ElementId hostElemId,
    Autodesk.Revit.DB.XYZ forceVector1,
    Autodesk.Revit.DB.XYZ momentVector1,
    Autodesk.Revit.DB.Structure.LineLoadType symbol
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidHostId(Autodesk.Revit.DB.Document pDoc, Autodesk.Revit.DB.ElementId hostId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Curve GetCurve() => throw new System.NotImplementedException();

  public virtual System.Boolean SetPoints(Autodesk.Revit.DB.XYZ startPoint, Autodesk.Revit.DB.XYZ endPoint) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ MomentVector2
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ MomentVector1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ ForceVector2
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ ForceVector1
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.XYZ EndPoint
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ StartPoint
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsProjected
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsUniform
  {
    get => throw new System.NotImplementedException();
  }
}

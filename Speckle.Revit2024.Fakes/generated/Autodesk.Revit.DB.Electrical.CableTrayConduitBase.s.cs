namespace Autodesk.Revit.DB.Electrical;

public partial class CableTrayConduitBase : Autodesk.Revit.DB.MEPCurve
{
  public CableTrayConduitBase() { }

  public virtual System.Boolean IsWithFitting() => throw new System.NotImplementedException();

  public static System.Boolean IsValidLevelId(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId levelId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidEndPoints(Autodesk.Revit.DB.XYZ startPoint, Autodesk.Revit.DB.XYZ endPoint) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId RunId
  {
    get => throw new System.NotImplementedException();
  }
}

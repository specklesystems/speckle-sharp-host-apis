namespace Autodesk.Revit.DB;

public partial class StairsEditScope : Autodesk.Revit.DB.EditScope
{
  public StairsEditScope() { }

  public StairsEditScope(Autodesk.Revit.DB.Document document, System.String transactionName) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Start(Autodesk.Revit.DB.ElementId stairsId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId Start(
    Autodesk.Revit.DB.ElementId baseLevelId,
    Autodesk.Revit.DB.ElementId topLevelId
  ) => throw new System.NotImplementedException();
}

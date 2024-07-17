namespace Autodesk.Revit.DB;

public partial class RevitLinkInstance : Autodesk.Revit.DB.Instance
{
  public RevitLinkInstance() { }

  public static Autodesk.Revit.DB.RevitLinkInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId revitLinkTypeId,
    Autodesk.Revit.DB.ImportPlacement placement
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.RevitLinkInstance Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId revitLinkTypeId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Document GetLinkDocument() => throw new System.NotImplementedException();

  public virtual void MoveBasePointToHostBasePoint(System.Boolean resetToOriginalRotation) =>
    throw new System.NotImplementedException();

  public virtual void MoveOriginToHostOrigin(System.Boolean resetToOriginalRotation) =>
    throw new System.NotImplementedException();
}

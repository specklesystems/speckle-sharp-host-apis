namespace Autodesk.Revit.DB;

public partial class Viewport : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.Viewport Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewSheetId,
    Autodesk.Revit.DB.ElementId viewId,
    Autodesk.Revit.DB.XYZ point
  ) => throw new System.NotImplementedException();

  public static System.Boolean CanAddViewToSheet(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewSheetId,
    Autodesk.Revit.DB.ElementId viewId
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsViewIdValidForViewport(Autodesk.Revit.DB.ElementId viewId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Outline GetBoxOutline() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ GetBoxCenter() => throw new System.NotImplementedException();

  public virtual void SetBoxCenter(Autodesk.Revit.DB.XYZ newCenterPoint) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Outline GetLabelOutline() => throw new System.NotImplementedException();

  public virtual System.Boolean HasViewportTransforms() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Transform GetProjectionToSheetTransform() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.XYZ LabelOffset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double LabelLineLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ViewportRotation Rotation
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId SheetId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId ViewId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ViewportPositioning ViewportPositioning
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

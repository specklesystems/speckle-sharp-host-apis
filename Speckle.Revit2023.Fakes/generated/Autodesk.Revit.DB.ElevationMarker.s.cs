namespace Autodesk.Revit.DB;

public partial class ElevationMarker : Autodesk.Revit.DB.Element
{
  public static Autodesk.Revit.DB.ElevationMarker CreateElevationMarker(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewFamilyTypeId,
    Autodesk.Revit.DB.XYZ origin,
    System.Int32 initialViewScale
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ElevationMarker CreateReferenceElevationMarker(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewFamilyTypeId,
    Autodesk.Revit.DB.XYZ origin,
    Autodesk.Revit.DB.ElementId viewPlanId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ViewSection CreateElevation(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId viewPlanId,
    System.Int32 index
  ) => throw new System.NotImplementedException();

  public virtual void CreateReferenceElevation(
    Autodesk.Revit.DB.Document document,
    System.Int32 index,
    Autodesk.Revit.DB.ElementId viewIdToReference
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetViewId(System.Int32 index) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsAvailableIndex(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Boolean HasElevations() => throw new System.NotImplementedException();

  public virtual System.Boolean IsReference
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 MaximumViewCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 CurrentViewCount
  {
    get => throw new System.NotImplementedException();
  }
}

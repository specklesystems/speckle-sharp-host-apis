namespace Autodesk.Revit.DB.Mechanical;

public partial class DuctLining : Autodesk.Revit.DB.InsulationLiningBase
{
  public DuctLining() { }

  public static Autodesk.Revit.DB.Mechanical.DuctLining Create(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId ductOrContentElementId,
    Autodesk.Revit.DB.ElementId ductLiningTypeId,
    System.Double Thickness
  ) => throw new System.NotImplementedException();
}

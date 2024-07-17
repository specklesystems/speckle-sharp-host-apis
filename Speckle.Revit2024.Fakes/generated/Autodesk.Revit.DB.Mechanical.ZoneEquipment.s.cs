namespace Autodesk.Revit.DB.Mechanical;

public partial class ZoneEquipment : Autodesk.Revit.DB.Element
{
  public ZoneEquipment() { }

  public static Autodesk.Revit.DB.Mechanical.ZoneEquipment Create(
    Autodesk.Revit.DB.Document document,
    System.String name
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Mechanical.ZoneEquipmentData GetZoneEquipmentData() =>
    throw new System.NotImplementedException();

  public static void MoveSpaceToEquipment(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> analyticalSpaceSet,
    Autodesk.Revit.DB.ElementId originalZoneEquipmentId,
    Autodesk.Revit.DB.ElementId targetZoneEquipmentId
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAssociatedZoneEquipment(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> spaces
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAssociatedZoneEquipment(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId spaceElementId
  ) => throw new System.NotImplementedException();
}

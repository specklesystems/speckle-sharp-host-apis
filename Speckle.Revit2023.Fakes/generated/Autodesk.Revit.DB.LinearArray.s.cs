namespace Autodesk.Revit.DB;

public partial class LinearArray : Autodesk.Revit.DB.BaseArray
{
  public LinearArray() { }

  public static Autodesk.Revit.DB.LinearArray Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.View dBView,
    Autodesk.Revit.DB.ElementId id,
    System.Int32 count,
    Autodesk.Revit.DB.XYZ translationToAnchorMember,
    Autodesk.Revit.DB.ArrayAnchorMember anchorMember
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.LinearArray Create(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.View dBView,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ids,
    System.Int32 count,
    Autodesk.Revit.DB.XYZ translationToAnchorMember,
    Autodesk.Revit.DB.ArrayAnchorMember anchorMember
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ArrayElementsWithoutAssociation(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.View dBView,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ids,
    System.Int32 count,
    Autodesk.Revit.DB.XYZ translationToAnchorMember,
    Autodesk.Revit.DB.ArrayAnchorMember anchorMember
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> ArrayElementWithoutAssociation(
    Autodesk.Revit.DB.Document aDoc,
    Autodesk.Revit.DB.View dBView,
    Autodesk.Revit.DB.ElementId id,
    System.Int32 count,
    Autodesk.Revit.DB.XYZ translationToAnchorMember,
    Autodesk.Revit.DB.ArrayAnchorMember anchorMember
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidArraySize(System.Int32 count) => throw new System.NotImplementedException();

  public static System.Boolean IsElementArrayable(Autodesk.Revit.DB.Document aDoc, Autodesk.Revit.DB.ElementId id) =>
    throw new System.NotImplementedException();

  public new System.Int32 NumMembers
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

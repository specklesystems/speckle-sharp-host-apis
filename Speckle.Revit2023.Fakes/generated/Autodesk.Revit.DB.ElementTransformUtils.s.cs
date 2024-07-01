namespace Autodesk.Revit.DB;

public partial class ElementTransformUtils
{
  public static System.Boolean CanMirrorElements(
    Autodesk.Revit.DB.Document ADoc,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elemIds
  ) => throw new System.NotImplementedException();

  public static System.Boolean CanMirrorElement(Autodesk.Revit.DB.Document ADoc, Autodesk.Revit.DB.ElementId elemId) =>
    throw new System.NotImplementedException();

  public static void MoveElements(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementsToMove,
    Autodesk.Revit.DB.XYZ translation
  ) => throw new System.NotImplementedException();

  public static void MoveElement(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elementToMove,
    Autodesk.Revit.DB.XYZ translation
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> CopyElements(
    Autodesk.Revit.DB.View sourceView,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementsToCopy,
    Autodesk.Revit.DB.View destinationView,
    Autodesk.Revit.DB.Transform additionalTransform,
    Autodesk.Revit.DB.CopyPasteOptions options
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> CopyElements(
    Autodesk.Revit.DB.Document sourceDocument,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementsToCopy,
    Autodesk.Revit.DB.Document destinationDocument,
    Autodesk.Revit.DB.Transform transform,
    Autodesk.Revit.DB.CopyPasteOptions options
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> CopyElements(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementsToCopy,
    Autodesk.Revit.DB.XYZ translation
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> CopyElement(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elementToCopy,
    Autodesk.Revit.DB.XYZ translation
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> MirrorElements(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementsToMirror,
    Autodesk.Revit.DB.Plane plane,
    System.Boolean mirrorCopies
  ) => throw new System.NotImplementedException();

  public static void MirrorElement(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elementToMirror,
    Autodesk.Revit.DB.Plane plane
  ) => throw new System.NotImplementedException();

  public static void RotateElements(
    Autodesk.Revit.DB.Document document,
    System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> elementsToRotate,
    Autodesk.Revit.DB.Line axis,
    System.Double angle
  ) => throw new System.NotImplementedException();

  public static void RotateElement(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId elementToRotate,
    Autodesk.Revit.DB.Line axis,
    System.Double angle
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Transform GetTransformFromViewToView(
    Autodesk.Revit.DB.View sourceView,
    Autodesk.Revit.DB.View destinationView
  ) => throw new System.NotImplementedException();
}

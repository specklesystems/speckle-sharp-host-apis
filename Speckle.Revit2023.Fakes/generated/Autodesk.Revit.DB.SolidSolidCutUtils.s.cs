namespace Autodesk.Revit.DB;

public partial class SolidSolidCutUtils
{
  public SolidSolidCutUtils() { }

  public static void AddCutBetweenSolids(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Element solidToBeCut,
    Autodesk.Revit.DB.Element cuttingSolid,
    System.Boolean splitFacesOfCuttingSolid
  ) => throw new System.NotImplementedException();

  public static void AddCutBetweenSolids(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Element solidToBeCut,
    Autodesk.Revit.DB.Element cuttingSolid
  ) => throw new System.NotImplementedException();

  public static void RemoveCutBetweenSolids(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.Element first,
    Autodesk.Revit.DB.Element second
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsAllowedForSolidCut(Autodesk.Revit.DB.Element element) =>
    throw new System.NotImplementedException();

  public static System.Boolean CanElementCutElement(
    Autodesk.Revit.DB.Element cuttingElement,
    Autodesk.Revit.DB.Element cutElement,
    out Autodesk.Revit.DB.CutFailureReason reason
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetCuttingSolids(
    Autodesk.Revit.DB.Element element
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetSolidsBeingCut(
    Autodesk.Revit.DB.Element element
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsElementFromAppropriateContext(Autodesk.Revit.DB.Element element) =>
    throw new System.NotImplementedException();

  public static System.Boolean CutExistsBetweenElements(
    Autodesk.Revit.DB.Element first,
    Autodesk.Revit.DB.Element second,
    out System.Boolean firstCutsSecond
  ) => throw new System.NotImplementedException();

  public static void SplitFacesOfCuttingSolid(
    Autodesk.Revit.DB.Element first,
    Autodesk.Revit.DB.Element second,
    System.Boolean split
  ) => throw new System.NotImplementedException();
}

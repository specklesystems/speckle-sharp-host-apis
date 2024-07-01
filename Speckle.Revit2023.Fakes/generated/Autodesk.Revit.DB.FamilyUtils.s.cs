namespace Autodesk.Revit.DB;

public partial class FamilyUtils
{
  public FamilyUtils() { }

  public static void ConvertFamilyToFaceHostBased(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId familyId
  ) => throw new System.NotImplementedException();

  public static System.Boolean FamilyCanConvertToFaceHostBased(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId familyId
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetProfileSymbols(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ProfileFamilyUsage profileFamilyUsage,
    System.Boolean oneCurveLoopOnly
  ) => throw new System.NotImplementedException();
}

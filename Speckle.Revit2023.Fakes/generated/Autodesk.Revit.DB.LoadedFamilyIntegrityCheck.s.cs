namespace Autodesk.Revit.DB;

public partial class LoadedFamilyIntegrityCheck
{
  public LoadedFamilyIntegrityCheck() { }

  public static System.Boolean CheckAllFamilies(
    Autodesk.Revit.DB.Document ADoc,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> corruptFamilyIds
  ) => throw new System.NotImplementedException();

  public static System.Boolean CheckFamily(Autodesk.Revit.DB.Document ADoc, Autodesk.Revit.DB.ElementId familyId) =>
    throw new System.NotImplementedException();

  public static System.Boolean CheckAllFamiliesSlow(
    Autodesk.Revit.DB.Document ADoc,
    System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> corruptFamilyIds
  ) => throw new System.NotImplementedException();
}

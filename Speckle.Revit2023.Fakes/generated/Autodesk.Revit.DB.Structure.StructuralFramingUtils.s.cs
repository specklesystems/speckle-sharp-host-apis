namespace Autodesk.Revit.DB.Structure;

public partial class StructuralFramingUtils
{
  public StructuralFramingUtils() { }

  public static System.Boolean CanSetEndReference(Autodesk.Revit.DB.FamilyInstance familyInstance, System.Int32 end) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsEndReferenceValid(
    Autodesk.Revit.DB.FamilyInstance familyInstance,
    System.Int32 end,
    Autodesk.Revit.DB.Reference pick
  ) => throw new System.NotImplementedException();

  public static void RemoveEndReference(Autodesk.Revit.DB.FamilyInstance familyInstance, System.Int32 end) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Reference GetEndReference(
    Autodesk.Revit.DB.FamilyInstance familyInstance,
    System.Int32 end
  ) => throw new System.NotImplementedException();

  public static void SetEndReference(
    Autodesk.Revit.DB.FamilyInstance familyInstance,
    System.Int32 end,
    Autodesk.Revit.DB.Reference pick
  ) => throw new System.NotImplementedException();

  public static void DisallowJoinAtEnd(Autodesk.Revit.DB.FamilyInstance familyInstance, System.Int32 end) =>
    throw new System.NotImplementedException();

  public static void AllowJoinAtEnd(Autodesk.Revit.DB.FamilyInstance familyInstance, System.Int32 end) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsJoinAllowedAtEnd(Autodesk.Revit.DB.FamilyInstance familyInstance, System.Int32 end) =>
    throw new System.NotImplementedException();

  public static System.Boolean CanFlipEnds(Autodesk.Revit.DB.FamilyInstance familyInstance) =>
    throw new System.NotImplementedException();

  public static void FlipEnds(Autodesk.Revit.DB.FamilyInstance familyInstance) =>
    throw new System.NotImplementedException();
}

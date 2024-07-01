namespace Autodesk.Revit.DB;

public partial class ParameterUtils
{
  public static Autodesk.Revit.DB.ForgeTypeId GetParameterTypeId(Autodesk.Revit.DB.BuiltInParameter builtInParam) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ForgeTypeId GetParameterGroupTypeId(
    Autodesk.Revit.DB.BuiltInParameterGroup builtInParamGroup
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.BuiltInParameter GetBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId parameterTypeId) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.BuiltInParameterGroup GetBuiltInParameterGroup(
    Autodesk.Revit.DB.ForgeTypeId groupTypeId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsBuiltInGroup(Autodesk.Revit.DB.ForgeTypeId groupTypeId) =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.ForgeTypeId> GetAllBuiltInGroups() =>
    throw new System.NotImplementedException();

  public static System.Boolean IsBuiltInParameter(Autodesk.Revit.DB.ElementId parameterId) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsBuiltInParameter(Autodesk.Revit.DB.ForgeTypeId parameterTypeId) =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<Autodesk.Revit.DB.ForgeTypeId> GetAllBuiltInParameters() =>
    throw new System.NotImplementedException();
}

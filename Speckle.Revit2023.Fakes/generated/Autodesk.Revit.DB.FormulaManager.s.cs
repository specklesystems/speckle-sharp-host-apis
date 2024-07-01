namespace Autodesk.Revit.DB;

public partial class FormulaManager : System.IDisposable
{
  public static System.String Evaluate(
    Autodesk.Revit.DB.ElementId parameterId,
    Autodesk.Revit.DB.Document document,
    System.String formula
  ) => throw new System.NotImplementedException();

  public static System.String Validate(
    Autodesk.Revit.DB.ElementId parameterId,
    Autodesk.Revit.DB.Document document,
    System.String formula
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<System.String> GetFunctions() =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.IList<System.String> GetOperators() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

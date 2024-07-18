namespace Autodesk.Revit.DB;

public partial class FilterStringRuleEvaluator : System.IDisposable
{
  public FilterStringRuleEvaluator() { }

  public virtual System.Boolean Evaluate(System.String lhs, System.String rhs, System.Boolean caseSensitive) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

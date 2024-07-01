namespace Autodesk.Revit.DB;

public partial class FilterElementIdRule : Autodesk.Revit.DB.FilterNumericValueRule
{
  public FilterElementIdRule() { }

  public FilterElementIdRule(
    Autodesk.Revit.DB.FilterableValueProvider valueProvider,
    Autodesk.Revit.DB.FilterNumericRuleEvaluator evaluator,
    Autodesk.Revit.DB.ElementId ruleValue
  ) => throw new System.NotImplementedException();

  public static System.Boolean UsesLevelFiltering(
    Autodesk.Revit.DB.Document doc,
    Autodesk.Revit.DB.ElementId parameterId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId RuleValue
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

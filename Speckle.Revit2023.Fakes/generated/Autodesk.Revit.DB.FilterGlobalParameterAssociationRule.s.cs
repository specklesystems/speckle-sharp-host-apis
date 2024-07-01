namespace Autodesk.Revit.DB;

public partial class FilterGlobalParameterAssociationRule : Autodesk.Revit.DB.FilterNumericValueRule
{
  public FilterGlobalParameterAssociationRule(
    Autodesk.Revit.DB.FilterableValueProvider valueProvider,
    Autodesk.Revit.DB.FilterNumericRuleEvaluator evaluator,
    Autodesk.Revit.DB.ElementId ruleValue
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId RuleValue
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

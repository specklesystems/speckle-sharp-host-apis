namespace Autodesk.Revit.DB;

public partial class FilterIntegerRule : Autodesk.Revit.DB.FilterNumericValueRule
{
	public FilterIntegerRule() {}
	public FilterIntegerRule(Autodesk.Revit.DB.FilterableValueProvider valueProvider,Autodesk.Revit.DB.FilterNumericRuleEvaluator evaluator,System.Int32 ruleValue) => throw new System.NotImplementedException();
	public virtual System.Int32 RuleValue
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

namespace Autodesk.Revit.DB;

public partial class FilterStringRule : Autodesk.Revit.DB.FilterValueRule
{
	public FilterStringRule() {}
	public FilterStringRule(Autodesk.Revit.DB.FilterableValueProvider valueProvider,Autodesk.Revit.DB.FilterStringRuleEvaluator evaluator,System.String ruleString) => throw new System.NotImplementedException();
	public FilterStringRule(Autodesk.Revit.DB.FilterableValueProvider valueProvider,Autodesk.Revit.DB.FilterStringRuleEvaluator evaluator,System.String ruleString,System.Boolean caseSensitive) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilterStringRuleEvaluator GetEvaluator() => throw new System.NotImplementedException();
	public virtual void SetEvaluator(Autodesk.Revit.DB.FilterStringRuleEvaluator evaluator) => throw new System.NotImplementedException();
	public virtual System.String RuleString
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

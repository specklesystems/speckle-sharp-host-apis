namespace Autodesk.Revit.DB;

public partial class FilterStringRule : Autodesk.Revit.DB.FilterValueRule
{
	public virtual Autodesk.Revit.DB.FilterStringRuleEvaluator GetEvaluator() => throw new System.NotImplementedException();
	public virtual void SetEvaluator(Autodesk.Revit.DB.FilterStringRuleEvaluator evaluator) => throw new System.NotImplementedException();
	public virtual System.String RuleString
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

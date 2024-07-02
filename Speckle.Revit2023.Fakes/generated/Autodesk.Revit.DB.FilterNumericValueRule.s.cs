namespace Autodesk.Revit.DB;

public partial class FilterNumericValueRule : Autodesk.Revit.DB.FilterValueRule
{
	public FilterNumericValueRule() {}
	public virtual Autodesk.Revit.DB.FilterNumericRuleEvaluator GetEvaluator() => throw new System.NotImplementedException();
	public virtual void SetEvaluator(Autodesk.Revit.DB.FilterNumericRuleEvaluator evaluator) => throw new System.NotImplementedException();
}

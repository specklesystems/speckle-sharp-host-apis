namespace Autodesk.Revit.DB;

public partial class FilterNumericRuleEvaluator : System.IDisposable
{
	public FilterNumericRuleEvaluator() {}
	public virtual System.Boolean Evaluate(System.Int32 lhs,System.Int32 rhs) => throw new System.NotImplementedException();
	public virtual System.Boolean Evaluate(System.Double lhs,System.Double rhs,System.Double epsilon) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}

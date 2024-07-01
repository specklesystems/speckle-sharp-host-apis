namespace Autodesk.Revit.DB;

public partial class PerformanceAdviser : System.IDisposable
{
	public static Autodesk.Revit.DB.PerformanceAdviser GetPerformanceAdviser() => throw new System.NotImplementedException();
	public virtual void AddRule(Autodesk.Revit.DB.PerformanceAdviserRuleId id,Autodesk.Revit.DB.IPerformanceAdviserRule rule) => throw new System.NotImplementedException();
	public virtual void DeleteRule(Autodesk.Revit.DB.PerformanceAdviserRuleId id) => throw new System.NotImplementedException();
	public virtual System.Int32 GetNumberOfRules() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PerformanceAdviserRuleId GetRuleId(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.PerformanceAdviserRuleId> GetAllRuleIds() => throw new System.NotImplementedException();
	public virtual System.Boolean IsRuleEnabled(Autodesk.Revit.DB.PerformanceAdviserRuleId id) => throw new System.NotImplementedException();
	public virtual System.Boolean IsRuleEnabled(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void SetRuleEnabled(Autodesk.Revit.DB.PerformanceAdviserRuleId id,System.Boolean enabled) => throw new System.NotImplementedException();
	public virtual void SetRuleEnabled(System.Int32 index,System.Boolean enabled) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FailureMessage> ExecuteAllRules(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FailureMessage> ExecuteRules(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<System.Int32> rules) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FailureMessage> ExecuteRules(Autodesk.Revit.DB.Document document,System.Collections.Generic.IList<Autodesk.Revit.DB.PerformanceAdviserRuleId> rules) => throw new System.NotImplementedException();
	public virtual void PostWarning(Autodesk.Revit.DB.FailureMessage message) => throw new System.NotImplementedException();
	public virtual System.Boolean WillRuleCheckElements(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Boolean WillRuleCheckElements(Autodesk.Revit.DB.PerformanceAdviserRuleId id) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementFilter GetElementFilterFromRule(System.Int32 index,Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementFilter GetElementFilterFromRule(Autodesk.Revit.DB.PerformanceAdviserRuleId id,Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual System.String GetRuleName(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.String GetRuleName(Autodesk.Revit.DB.PerformanceAdviserRuleId id) => throw new System.NotImplementedException();
	public virtual System.String GetRuleDescription(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.String GetRuleDescription(Autodesk.Revit.DB.PerformanceAdviserRuleId id) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}

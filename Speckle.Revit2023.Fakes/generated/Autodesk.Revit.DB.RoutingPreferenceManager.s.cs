namespace Autodesk.Revit.DB;

public partial class RoutingPreferenceManager : System.IDisposable
{
	public virtual System.Int32 GetNumberOfRules(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType eGroupType) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.RoutingPreferenceRule GetRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType groupType,System.Int32 index) => throw new System.NotImplementedException();
	public virtual void AddRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType groupType,Autodesk.Revit.DB.RoutingPreferenceRule rule,System.Int32 index) => throw new System.NotImplementedException();
	public virtual void AddRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType groupType,Autodesk.Revit.DB.RoutingPreferenceRule rule) => throw new System.NotImplementedException();
	public virtual void RemoveRule(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType groupType,System.Int32 index) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetMEPPartId(Autodesk.Revit.DB.RoutingPreferenceRuleGroupType groupType,Autodesk.Revit.DB.RoutingConditions conditions) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetSharedSizes(System.Double size,Autodesk.Revit.DB.ConnectorProfileType shape) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId OwnerId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PreferredJunctionType PreferredJunctionType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

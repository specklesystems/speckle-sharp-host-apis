namespace Autodesk.Revit.DB.Electrical;

public partial class ElectricalDemandFactorDefinition : Autodesk.Revit.DB.Element
{
	public ElectricalDemandFactorDefinition() {}
	public static Autodesk.Revit.DB.Electrical.ElectricalDemandFactorDefinition Create(Autodesk.Revit.DB.Document ADoc,System.String strName) => throw new System.NotImplementedException();
	public virtual void ClearValues() => throw new System.NotImplementedException();
	public virtual void AddValue(Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue dfValue) => throw new System.NotImplementedException();
	public virtual void RemoveValue(Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue dfValue) => throw new System.NotImplementedException();
	public virtual void SetValues(System.Collections.Generic.ICollection<Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue> values) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.Electrical.ElectricalDemandFactorValue> GetValues() => throw new System.NotImplementedException();
	public virtual System.Int32 GetValuesCount() => throw new System.NotImplementedException();
	public virtual System.Double GetApplicableDemandFactor(System.Double numberOrLoad) => throw new System.NotImplementedException();
	public virtual System.Boolean IncludeAdditionalLoad
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Electrical.ElectricalDemandFactorRule RuleType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AdditionalLoad
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

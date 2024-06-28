namespace Autodesk.Revit.DB;

public partial class FamilySymbol : Autodesk.Revit.DB.InsertableObject
{
	public virtual IList<Autodesk.Revit.DB.FamilyPointLocation> GetFamilyPointLocations() => throw new System.NotImplementedException();
	public virtual void Activate() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyThermalProperties GetThermalProperties() => throw new System.NotImplementedException();
	public virtual void SetThermalProperties(Autodesk.Revit.DB.FamilyThermalProperties thermalProperties) => throw new System.NotImplementedException();
	public virtual System.Boolean HasThermalProperties() => throw new System.NotImplementedException();
	public virtual System.Boolean CanHaveStructuralSection() => throw new System.NotImplementedException();
	public virtual System.Boolean IsActive
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Family Family
	{
		get => throw new System.NotImplementedException();
	}
}

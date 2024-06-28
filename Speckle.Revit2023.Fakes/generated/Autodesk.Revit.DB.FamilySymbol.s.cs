namespace Autodesk.Revit.DB;

public partial class FamilySymbol : Autodesk.Revit.DB.InsertableObject
{
	public virtual void Activate() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyThermalProperties GetThermalProperties() => throw new System.NotImplementedException();
	public virtual void SetThermalProperties(Autodesk.Revit.DB.FamilyThermalProperties thermalProperties) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Family Family
	{
		get => throw new System.NotImplementedException();
	}
}

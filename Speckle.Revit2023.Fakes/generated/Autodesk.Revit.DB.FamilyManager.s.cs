namespace Autodesk.Revit.DB;

public partial class FamilyManager : Autodesk.Revit.DB.APIObject
{
	public virtual void DeleteCurrentType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter GetParameter(Autodesk.Revit.DB.ForgeTypeId parameterTypeId) => throw new System.NotImplementedException();
	public virtual void Set(Autodesk.Revit.DB.FamilyParameter familyParameter,Autodesk.Revit.DB.ElementId value) => throw new System.NotImplementedException();
	public virtual void RemoveParameter(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void MakeInstance(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void MakeType(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void MakeReporting(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void MakeNonReporting(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void AssociateElementParameterToFamilyParameter(Autodesk.Revit.DB.Parameter elementParameter,Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter GetAssociatedFamilyParameter(Autodesk.Revit.DB.Parameter elementParameter) => throw new System.NotImplementedException();
	public virtual void SortParameters(Autodesk.Revit.DB.ParametersOrder order) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameterSet Parameters
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FamilyTypeSet Types
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.FamilyType CurrentType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

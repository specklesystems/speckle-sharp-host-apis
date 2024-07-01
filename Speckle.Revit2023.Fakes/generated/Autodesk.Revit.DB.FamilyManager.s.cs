namespace Autodesk.Revit.DB;

public partial class FamilyManager : Autodesk.Revit.DB.APIObject
{
	public virtual Autodesk.Revit.DB.FamilyType NewType(System.String typeName) => throw new System.NotImplementedException();
	public virtual void DeleteCurrentType() => throw new System.NotImplementedException();
	public virtual void RenameCurrentType(System.String typeName) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter get_Parameter(System.Guid guid) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter get_Parameter(Autodesk.Revit.DB.Definition definition) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter get_Parameter(Autodesk.Revit.DB.BuiltInParameter parameterId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter get_Parameter(System.String parameterName) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter GetParameter(Autodesk.Revit.DB.ForgeTypeId parameterTypeId) => throw new System.NotImplementedException();
	public virtual void Set(Autodesk.Revit.DB.FamilyParameter familyParameter,Autodesk.Revit.DB.ElementId value) => throw new System.NotImplementedException();
	public virtual void Set(Autodesk.Revit.DB.FamilyParameter familyParameter,System.Double value) => throw new System.NotImplementedException();
	public virtual void Set(Autodesk.Revit.DB.FamilyParameter familyParameter,System.String value) => throw new System.NotImplementedException();
	public virtual void Set(Autodesk.Revit.DB.FamilyParameter familyParameter,System.Int32 value) => throw new System.NotImplementedException();
	public virtual void SetValueString(Autodesk.Revit.DB.FamilyParameter familyParameter,System.String value) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter AddParameter(System.String parameterName,Autodesk.Revit.DB.BuiltInParameterGroup parameterGroup,Autodesk.Revit.DB.Category familyCategory,System.Boolean isInstance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter AddParameter(System.String parameterName,Autodesk.Revit.DB.ForgeTypeId groupTypeId,Autodesk.Revit.DB.Category familyCategory,System.Boolean isInstance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter AddParameter(System.String parameterName,Autodesk.Revit.DB.ForgeTypeId groupTypeId,Autodesk.Revit.DB.ForgeTypeId specTypeId,System.Boolean isInstance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter AddParameter(Autodesk.Revit.DB.ExternalDefinition familyDefinition,Autodesk.Revit.DB.BuiltInParameterGroup parameterGroup,System.Boolean isInstance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter AddParameter(Autodesk.Revit.DB.ExternalDefinition familyDefinition,Autodesk.Revit.DB.ForgeTypeId groupTypeId,System.Boolean isInstance) => throw new System.NotImplementedException();
	public virtual void SetDescription(Autodesk.Revit.DB.FamilyParameter familyParameter,System.String description) => throw new System.NotImplementedException();
	public virtual void RemoveParameter(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void MakeInstance(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void MakeType(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void MakeReporting(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void MakeNonReporting(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void SetFormula(Autodesk.Revit.DB.FamilyParameter familyParameter,System.String formula) => throw new System.NotImplementedException();
	public virtual void RenameParameter(Autodesk.Revit.DB.FamilyParameter familyParameter,System.String name) => throw new System.NotImplementedException();
	public virtual void AssociateElementParameterToFamilyParameter(Autodesk.Revit.DB.Parameter elementParameter,Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter ReplaceParameter(Autodesk.Revit.DB.FamilyParameter currentParameter,System.String parameterName,Autodesk.Revit.DB.BuiltInParameterGroup parameterGroup,System.Boolean isInstance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter ReplaceParameter(Autodesk.Revit.DB.FamilyParameter currentParameter,System.String parameterName,Autodesk.Revit.DB.ForgeTypeId groupTypeId,System.Boolean isInstance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter ReplaceParameter(Autodesk.Revit.DB.FamilyParameter currentParameter,Autodesk.Revit.DB.ExternalDefinition familyDefinition,Autodesk.Revit.DB.BuiltInParameterGroup parameterGroup,System.Boolean isInstance) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter ReplaceParameter(Autodesk.Revit.DB.FamilyParameter currentParameter,Autodesk.Revit.DB.ExternalDefinition familyDefinition,Autodesk.Revit.DB.ForgeTypeId groupTypeId,System.Boolean isInstance) => throw new System.NotImplementedException();
	public virtual System.Boolean CanElementParameterBeAssociated(Autodesk.Revit.DB.Parameter elementParameter) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FamilyParameter GetAssociatedFamilyParameter(Autodesk.Revit.DB.Parameter elementParameter) => throw new System.NotImplementedException();
	public virtual System.Boolean IsParameterLockable(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual System.Boolean IsParameterLocked(Autodesk.Revit.DB.FamilyParameter familyParameter) => throw new System.NotImplementedException();
	public virtual void SetParameterLocked(Autodesk.Revit.DB.FamilyParameter familyParameter,System.Boolean locked) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.FamilyParameter> GetParameters() => throw new System.NotImplementedException();
	public virtual void ReorderParameters(System.Collections.Generic.IList<Autodesk.Revit.DB.FamilyParameter> parameters) => throw new System.NotImplementedException();
	public virtual System.Boolean IsUserAssignableParameterGroup(Autodesk.Revit.DB.BuiltInParameterGroup parameterGroup) => throw new System.NotImplementedException();
	public virtual System.Boolean IsUserAssignableParameterGroup(Autodesk.Revit.DB.ForgeTypeId groupTypeId) => throw new System.NotImplementedException();
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

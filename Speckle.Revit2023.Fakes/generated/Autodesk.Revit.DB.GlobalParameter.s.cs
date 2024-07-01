namespace Autodesk.Revit.DB;

public partial class GlobalParameter : Autodesk.Revit.DB.ParameterElement
{
	public static Autodesk.Revit.DB.GlobalParameter Create(Autodesk.Revit.DB.Document document,System.String name,Autodesk.Revit.DB.ForgeTypeId specTypeId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanChangeReporting() => throw new System.NotImplementedException();
	public virtual void SetDrivingDimension(Autodesk.Revit.DB.ElementId dimensionId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAffectedElements() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetAffectedGlobalParameters() => throw new System.NotImplementedException();
	public virtual System.String GetFormula() => throw new System.NotImplementedException();
	public virtual void SetFormula(System.String expression) => throw new System.NotImplementedException();
	public virtual System.String GetLabelName() => throw new System.NotImplementedException();
	public virtual void LabelDimension(Autodesk.Revit.DB.ElementId dimensionId) => throw new System.NotImplementedException();
	public virtual void UnlabelDimension(Autodesk.Revit.DB.ElementId dimensionId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanLabelDimension(Autodesk.Revit.DB.ElementId dimensionId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ISet<Autodesk.Revit.DB.ElementId> GetLabeledDimensions() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ParameterValue GetValue() => throw new System.NotImplementedException();
	public virtual void SetValue(Autodesk.Revit.DB.ParameterValue value) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidFormula(System.String expression) => throw new System.NotImplementedException();
	public virtual System.Boolean HasValidTypeForReporting() => throw new System.NotImplementedException();
	public virtual System.Boolean IsDrivenByDimension
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsDrivenByFormula
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsReporting
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

namespace Autodesk.Revit.DB.Structure;

public partial class RebarShapeDefinition : System.IDisposable
{
	public virtual void AddParameter(Autodesk.Revit.DB.ElementId paramId,System.Double defaultValue) => throw new System.NotImplementedException();
	public virtual void AddFormulaParameter(Autodesk.Revit.DB.ElementId paramId,System.String formula) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetParameters() => throw new System.NotImplementedException();
	public virtual System.Boolean HasParameter(Autodesk.Revit.DB.ElementId paramId) => throw new System.NotImplementedException();
	public virtual System.Double GetParameterDefaultValue(Autodesk.Revit.DB.ElementId paramId) => throw new System.NotImplementedException();
	public virtual System.String GetParameterFormula(Autodesk.Revit.DB.ElementId paramId) => throw new System.NotImplementedException();
	public virtual void SetParameterDefaultValue(Autodesk.Revit.DB.ElementId paramId,System.Double value) => throw new System.NotImplementedException();
	public virtual void SetParameterFormula(Autodesk.Revit.DB.ElementId paramId,System.String formula) => throw new System.NotImplementedException();
	public virtual void RemoveParameter(Autodesk.Revit.DB.ElementId paramId) => throw new System.NotImplementedException();
	public virtual System.Boolean CheckDefaultParameterValues(System.Double bendRadius,System.Double barDiameter) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsPlanar
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Complete
	{
		get => throw new System.NotImplementedException();
	}
}

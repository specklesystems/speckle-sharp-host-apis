namespace Autodesk.Revit.DB;

public partial class GlobalParameter : Autodesk.Revit.DB.ParameterElement
{
	public virtual void SetDrivingDimension(Autodesk.Revit.DB.ElementId dimensionId) => throw new System.NotImplementedException();
	public virtual void LabelDimension(Autodesk.Revit.DB.ElementId dimensionId) => throw new System.NotImplementedException();
	public virtual void UnlabelDimension(Autodesk.Revit.DB.ElementId dimensionId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ParameterValue GetValue() => throw new System.NotImplementedException();
	public virtual void SetValue(Autodesk.Revit.DB.ParameterValue value) => throw new System.NotImplementedException();
}

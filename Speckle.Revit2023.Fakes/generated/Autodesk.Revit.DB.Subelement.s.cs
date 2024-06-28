namespace Autodesk.Revit.DB;

public partial class Subelement : System.Object
{
	public virtual void ChangeTypeId(Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ParameterValue GetParameterValue(Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public virtual void SetParameterValue(Autodesk.Revit.DB.ElementId parameterId,Autodesk.Revit.DB.ParameterValue pValue) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryObject GetGeometryObject(Autodesk.Revit.DB.View dbView) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxXYZ GetBoundingBox(Autodesk.Revit.DB.View dbView) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetReference() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element Element
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Document Document
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId TypeId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Category Category
	{
		get => throw new System.NotImplementedException();
	}
}

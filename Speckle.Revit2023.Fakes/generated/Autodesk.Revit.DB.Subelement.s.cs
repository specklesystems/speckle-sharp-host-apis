namespace Autodesk.Revit.DB;

public partial class Subelement : System.Object
{
	public virtual Autodesk.Revit.DB.Category get_Category() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId get_TypeId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Document get_Document() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element get_Element() => throw new System.NotImplementedException();
	public virtual void ChangeTypeId(Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ParameterValue GetParameterValue(Autodesk.Revit.DB.ElementId parameterId) => throw new System.NotImplementedException();
	public virtual void SetParameterValue(Autodesk.Revit.DB.ElementId parameterId,Autodesk.Revit.DB.ParameterValue pValue) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryObject GetGeometryObject(Autodesk.Revit.DB.View dbView) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.BoundingBoxXYZ GetBoundingBox(Autodesk.Revit.DB.View dbView) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Reference GetReference() => throw new System.NotImplementedException();
	}

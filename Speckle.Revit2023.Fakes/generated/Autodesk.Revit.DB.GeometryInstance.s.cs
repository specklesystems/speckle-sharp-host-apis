namespace Autodesk.Revit.DB;

public partial class GeometryInstance : Autodesk.Revit.DB.GeometryObject
{
	public virtual Autodesk.Revit.DB.Transform get_Transform() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element get_Symbol() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SymbolGeometryId GetSymbolGeometryId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Document GetDocument() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement get_SymbolGeometry() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetSymbolGeometry(Autodesk.Revit.DB.Transform transform) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetSymbolGeometry() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetInstanceGeometry(Autodesk.Revit.DB.Transform transform) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.GeometryElement GetInstanceGeometry() => throw new System.NotImplementedException();
}

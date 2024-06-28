namespace Autodesk.Revit.DB;

public partial class FilteredElementCollector : System.Object
{
	public virtual Autodesk.Revit.DB.FilteredElementCollector OfCategory(Autodesk.Revit.DB.BuiltInCategory category) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementIdIterator GetElementIdIterator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementIterator GetElementIterator() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector WherePasses(Autodesk.Revit.DB.ElementFilter filter) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector IntersectWith(Autodesk.Revit.DB.FilteredElementCollector other) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector UnionWith(Autodesk.Revit.DB.FilteredElementCollector other) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector OfCategoryId(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector WhereElementIsElementType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector WhereElementIsNotElementType() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector OwnedByView(Autodesk.Revit.DB.ElementId viewId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector WhereElementIsViewIndependent() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector ContainedInDesignOption(Autodesk.Revit.DB.ElementId designOptionId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FilteredElementCollector WhereElementIsCurveDriven() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId FirstElementId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Element FirstElement() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
}

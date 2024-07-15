namespace Autodesk.Revit.DB;

public partial class ElementId
{
	public ElementId() {}
	public ElementId(Autodesk.Revit.DB.BuiltInParameter parameterId) => throw new System.NotImplementedException();
	public ElementId(Autodesk.Revit.DB.BuiltInCategory categoryId) => throw new System.NotImplementedException();
	public ElementId(System.Int32 id) => throw new System.NotImplementedException();
	public virtual System.Int32 Compare(Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ElementId InvalidElementId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 IntegerValue
	{
		get => throw new System.NotImplementedException();
	}
}

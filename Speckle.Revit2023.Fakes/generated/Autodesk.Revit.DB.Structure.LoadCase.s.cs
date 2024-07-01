namespace Autodesk.Revit.DB.Structure;

public partial class LoadCase : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.Structure.LoadCase Create(Autodesk.Revit.DB.Document document,System.String name,Autodesk.Revit.DB.ElementId natureId,Autodesk.Revit.DB.ElementId subcategoryId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.Structure.LoadCase Create(Autodesk.Revit.DB.Document document,System.String name,Autodesk.Revit.DB.ElementId natureId,Autodesk.Revit.DB.Structure.LoadCaseCategory loadCaseCategory) => throw new System.NotImplementedException();
	public virtual System.Boolean IsLoadCaseSubcategoryId(Autodesk.Revit.DB.ElementId loadCaseSubcategoryId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsLoadNatureId(Autodesk.Revit.DB.ElementId natureId) => throw new System.NotImplementedException();
	public static System.Boolean IsNumberUnique(Autodesk.Revit.DB.Document document,System.Int32 number) => throw new System.NotImplementedException();
	public virtual System.Int32 Number
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId SubcategoryId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId NatureId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

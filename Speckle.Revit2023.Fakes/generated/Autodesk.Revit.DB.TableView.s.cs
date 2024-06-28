namespace Autodesk.Revit.DB;

public partial class TableView : Autodesk.Revit.DB.View
{
	public virtual System.Boolean IsValidSectionType(Autodesk.Revit.DB.SectionType sectionType) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ElementId> GetAvailableParameterCategories(Autodesk.Revit.DB.SectionType sectionType,System.Int32 row) => throw new System.NotImplementedException();
	public static IList<Autodesk.Revit.DB.ElementId> GetAvailableParameters(Autodesk.Revit.DB.Document cda,Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual System.String GetCellText(Autodesk.Revit.DB.SectionType sectionType,System.Int32 row,System.Int32 column) => throw new System.NotImplementedException();
	public virtual System.String GetCalculatedValueName(Autodesk.Revit.DB.SectionType sectionType,System.Int32 row,System.Int32 column) => throw new System.NotImplementedException();
	public virtual System.String GetCalculatedValueText(Autodesk.Revit.DB.SectionType sectionType,System.Int32 row,System.Int32 column) => throw new System.NotImplementedException();
	public virtual System.Int32 MaximumRowHeight
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 MaximumColumnWidth
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 MinimumRowHeight
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 MinimumColumnWidth
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 MaximumGridWidth
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId TargetId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

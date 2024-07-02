namespace Autodesk.Revit.DB;

public partial class ImportInstance : Autodesk.Revit.DB.Instance
{
	public ImportInstance() {}
	public virtual Autodesk.Revit.DB.FamilyElementVisibility GetVisibility() => throw new System.NotImplementedException();
	public virtual void SetVisibility(Autodesk.Revit.DB.FamilyElementVisibility visibility) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ImportInstance Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId typeId,Autodesk.Revit.DB.View DBView) => throw new System.NotImplementedException();
	public virtual System.Boolean IsLinked
	{
		get => throw new System.NotImplementedException();
	}
}

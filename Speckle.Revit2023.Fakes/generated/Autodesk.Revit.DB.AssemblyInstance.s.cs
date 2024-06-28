namespace Autodesk.Revit.DB;

public partial class AssemblyInstance : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.XYZ GetCenter() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform GetTransform() => throw new System.NotImplementedException();
	public virtual void SetTransform(Autodesk.Revit.DB.Transform trf) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId NamingCategoryId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

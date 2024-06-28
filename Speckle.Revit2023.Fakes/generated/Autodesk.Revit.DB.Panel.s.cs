namespace Autodesk.Revit.DB;

public partial class Panel : Autodesk.Revit.DB.FamilyInstance
{
	public virtual Autodesk.Revit.DB.ElementId FindHostPanel() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Transform Transform
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PanelType PanelType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

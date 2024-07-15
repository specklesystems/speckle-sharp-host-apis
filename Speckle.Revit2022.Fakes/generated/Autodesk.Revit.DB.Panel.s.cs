namespace Autodesk.Revit.DB;

public partial class Panel : Autodesk.Revit.DB.FamilyInstance
{
	public Panel() {}
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
	public virtual System.Boolean Lockable
	{
		get => throw new System.NotImplementedException();
	}
}

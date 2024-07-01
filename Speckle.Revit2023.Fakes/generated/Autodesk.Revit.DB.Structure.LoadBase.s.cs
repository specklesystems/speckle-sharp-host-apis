namespace Autodesk.Revit.DB.Structure;

public partial class LoadBase : Autodesk.Revit.DB.Element
{
	public virtual System.Boolean IsOrientToPermitted(Autodesk.Revit.DB.Structure.LoadOrientTo orientTo) => throw new System.NotImplementedException();
	public virtual System.Boolean IsReaction
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.Structure.LoadOrientTo OrientTo
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId WorkPlaneId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId HostElementId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String LoadCategoryName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String LoadNatureName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String LoadCaseName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.Structure.LoadCase LoadCase
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId LoadCaseId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsHosted
	{
		get => throw new System.NotImplementedException();
	}
}

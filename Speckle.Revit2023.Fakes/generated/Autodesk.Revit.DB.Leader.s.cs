namespace Autodesk.Revit.DB;

public partial class Leader : Autodesk.Revit.DB.APIObject
{
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.LeaderShape LeaderShape
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Anchor
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.XYZ Elbow
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.XYZ End
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

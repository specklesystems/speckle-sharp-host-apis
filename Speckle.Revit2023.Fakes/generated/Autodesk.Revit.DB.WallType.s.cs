namespace Autodesk.Revit.DB;

public partial class WallType : Autodesk.Revit.DB.HostObjAttributes
{
	public virtual Autodesk.Revit.DB.WallKind Kind
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ThermalProperties ThermalProperties
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.WallFunction Function
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

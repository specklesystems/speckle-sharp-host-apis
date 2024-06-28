namespace Autodesk.Revit.DB;

public partial class CurtainSystem : Autodesk.Revit.DB.CurtainSystemBase
{
	public virtual void AddCurtainGrid(Autodesk.Revit.DB.Reference face) => throw new System.NotImplementedException();
	public virtual void RemoveCurtainGrid(Autodesk.Revit.DB.Reference face) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CurtainSystemType CurtainSystemType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.CurtainGridSet CurtainGrids
	{
		get => throw new System.NotImplementedException();
	}
}

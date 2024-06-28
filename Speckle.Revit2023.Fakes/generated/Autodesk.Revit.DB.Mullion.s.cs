namespace Autodesk.Revit.DB;

public partial class Mullion : Autodesk.Revit.DB.FamilyInstance
{
	public virtual void JoinMullion() => throw new System.NotImplementedException();
	public virtual void BreakMullion() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Curve LocationCurve
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.MullionType MullionType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

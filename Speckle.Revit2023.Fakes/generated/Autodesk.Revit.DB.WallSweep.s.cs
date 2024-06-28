namespace Autodesk.Revit.DB;

public partial class WallSweep : Autodesk.Revit.DB.HostObject
{
	public virtual Autodesk.Revit.DB.WallSweepInfo GetWallSweepInfo() => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ElementId> GetHostIds() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.WallSweep Create(Autodesk.Revit.DB.Wall wall,Autodesk.Revit.DB.ElementId wallSweepType,Autodesk.Revit.DB.WallSweepInfo wallSweepInfo) => throw new System.NotImplementedException();
	public static System.Boolean WallAllowsWallSweep(Autodesk.Revit.DB.Wall wall) => throw new System.NotImplementedException();
}

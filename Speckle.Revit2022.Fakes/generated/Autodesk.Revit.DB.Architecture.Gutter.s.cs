namespace Autodesk.Revit.DB.Architecture;

public partial class Gutter : Autodesk.Revit.DB.HostedSweep
{
	public Gutter() {}
	public virtual Autodesk.Revit.DB.Architecture.GutterType GutterType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

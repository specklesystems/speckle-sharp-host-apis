namespace Autodesk.Revit.DB;

public partial class InSessionViewSheetSet : Autodesk.Revit.DB.IViewSheetSet,System.IDisposable
{
	public InSessionViewSheetSet() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ViewSet Views
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

namespace Autodesk.Revit.DB;

public partial class TemporaryGraphicsManager : System.IDisposable
{
	public TemporaryGraphicsManager() {}
	public static Autodesk.Revit.DB.TemporaryGraphicsManager GetTemporaryGraphicsManager(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual System.Int32 AddControl(Autodesk.Revit.DB.InCanvasControlData data,Autodesk.Revit.DB.ElementId ownerViewId) => throw new System.NotImplementedException();
	public virtual void RemoveControl(System.Int32 index) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<System.Int32> GetAll() => throw new System.NotImplementedException();
	public virtual void Clear() => throw new System.NotImplementedException();
	public virtual void UpdateControl(System.Int32 index,Autodesk.Revit.DB.InCanvasControlData data) => throw new System.NotImplementedException();
	public virtual void SetVisibility(System.Int32 index,System.Boolean visible) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
}

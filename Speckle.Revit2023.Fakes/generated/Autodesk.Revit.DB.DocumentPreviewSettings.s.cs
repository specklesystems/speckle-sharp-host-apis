namespace Autodesk.Revit.DB;

public partial class DocumentPreviewSettings : System.IDisposable
{
	public DocumentPreviewSettings() {}
	public virtual void ForceViewUpdate(System.Boolean forceViewUpdate) => throw new System.NotImplementedException();
	public virtual System.Boolean IsViewIdValidForPreview(Autodesk.Revit.DB.ElementId viewId) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId PreviewViewId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsViewUpdateForced
	{
		get => throw new System.NotImplementedException();
	}
}

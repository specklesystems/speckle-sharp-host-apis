namespace Autodesk.Revit.DB;

public partial class RevitLinkType : Autodesk.Revit.DB.ElementType
{
	public virtual Autodesk.Revit.DB.LinkLoadResult Load() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkLoadResult Reload() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkedFileStatus RevertLocalUnloadStatus() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkLoadResult LoadFrom(Autodesk.Revit.DB.ModelPath path,Autodesk.Revit.DB.WorksetConfiguration config) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkLoadResult LoadFrom(Autodesk.Revit.DB.ExternalResourceReference resourceReference,Autodesk.Revit.DB.WorksetConfiguration config) => throw new System.NotImplementedException();
	public virtual void Unload(Autodesk.Revit.DB.ISaveSharedCoordinatesCallback callback) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkConversionData GetConversionData() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkedFileStatus GetLinkedFileStatus() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetParentId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetRootId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.AttachmentType AttachmentType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.PathType PathType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

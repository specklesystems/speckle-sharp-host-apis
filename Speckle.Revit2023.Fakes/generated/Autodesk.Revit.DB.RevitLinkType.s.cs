namespace Autodesk.Revit.DB;

public partial class RevitLinkType : Autodesk.Revit.DB.ElementType
{
	public RevitLinkType() {}
	public static Autodesk.Revit.DB.LinkLoadResult Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ExternalResourceReference resourceReference,Autodesk.Revit.DB.RevitLinkOptions options) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.LinkLoadResult Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ModelPath path,Autodesk.Revit.DB.RevitLinkOptions options) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.LinkLoadResult CreateFromIFC(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ExternalResourceReference resourceReference,System.String revitLinkedFilePath,System.Boolean recreateLink,Autodesk.Revit.DB.RevitLinkOptions options) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.LinkLoadResult CreateFromIFC(Autodesk.Revit.DB.Document document,System.String ifcFilePath,System.String revitLinkedFilePath,System.Boolean recreateLink,Autodesk.Revit.DB.RevitLinkOptions options) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateFromIFC(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ExternalResourceReference resourceReference,System.String revitLinkedFilePath,System.Boolean recreateLink) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateFromIFC(Autodesk.Revit.DB.Document document,System.String ifcFilePath,System.String revitLinkedFilePath,System.Boolean recreateLink) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkLoadResult Load() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkLoadResult Reload() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkedFileStatus RevertLocalUnloadStatus() => throw new System.NotImplementedException();
	public virtual System.Boolean IsNotLoadedIntoMultipleOpenDocuments() => throw new System.NotImplementedException();
	public static System.Boolean IsLoaded(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkLoadResult LoadFrom(Autodesk.Revit.DB.ModelPath path,Autodesk.Revit.DB.WorksetConfiguration config) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkLoadResult LoadFrom(Autodesk.Revit.DB.ExternalResourceReference resourceReference,Autodesk.Revit.DB.WorksetConfiguration config) => throw new System.NotImplementedException();
	public virtual void Unload(Autodesk.Revit.DB.ISaveSharedCoordinatesCallback callback) => throw new System.NotImplementedException();
	public virtual System.Boolean SavePositions(Autodesk.Revit.DB.ISaveSharedCoordinatesCallback callback) => throw new System.NotImplementedException();
	public virtual System.Boolean HasSaveablePositions() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IDictionary<Autodesk.Revit.DB.ElementId, Autodesk.Revit.DB.ElementId> GetPhaseMap() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkConversionData GetConversionData() => throw new System.NotImplementedException();
	public virtual System.Boolean IsFromRevitServer() => throw new System.NotImplementedException();
	public virtual System.Boolean IsFromLocalPath() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LinkedFileStatus GetLinkedFileStatus() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ElementId GetTopLevelLink(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ExternalResourceReference reference) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ElementId GetTopLevelLink(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ModelPath path) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetParentId() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetRootId() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetChildIds() => throw new System.NotImplementedException();
	public virtual System.Boolean UnloadLocally(Autodesk.Revit.DB.ISaveSharedCoordinatesCallbackForUnloadLocally callback) => throw new System.NotImplementedException();
	public virtual System.Boolean LocallyUnloaded
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.AttachmentType AttachmentType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsNestedLink
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PathType PathType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

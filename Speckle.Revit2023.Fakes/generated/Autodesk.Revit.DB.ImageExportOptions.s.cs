namespace Autodesk.Revit.DB;

public partial class ImageExportOptions : System.IDisposable
{
	public ImageExportOptions() => throw new System.NotImplementedException();
	public static System.Boolean IsValidForSaveToProjectAsImage(Autodesk.Revit.DB.ImageExportOptions options,Autodesk.Revit.DB.Document doc) => throw new System.NotImplementedException();
	public static System.Boolean IsValidFileName(System.String filePath) => throw new System.NotImplementedException();
	public static System.String GetFileName(Autodesk.Revit.DB.Document aDoc,Autodesk.Revit.DB.ElementId dbViewId) => throw new System.NotImplementedException();
	public virtual void SetViewsAndSheets(IList<Autodesk.Revit.DB.ElementId> viewsAndSheets) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.ElementId> GetViewsAndSheets() => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ExportRange ExportRange
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShouldCreateWebSite
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String FilePath
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String ViewName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.FitDirectionType FitDirection
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ImageFileType HLRandWFViewsFileType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ImageFileType ShadowViewsFileType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ImageResolution ImageResolution
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 PixelSize
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 Zoom
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ZoomFitType ZoomType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

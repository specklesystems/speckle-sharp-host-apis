namespace Autodesk.Revit.DB;

public partial class ImageType : Autodesk.Revit.DB.ElementType
{
	public ImageType() {}
	public virtual System.Drawing.Bitmap GetImage() => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ImageType Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ImageTypeOptions options) => throw new System.NotImplementedException();
	public virtual System.Boolean CanReload() => throw new System.NotImplementedException();
	public virtual void Reload() => throw new System.NotImplementedException();
	public virtual void ReloadFrom(Autodesk.Revit.DB.ImageTypeOptions options) => throw new System.NotImplementedException();
	public virtual void Unload() => throw new System.NotImplementedException();
	public virtual System.Double Resolution
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Height
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Width
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ImageTypeStatus Status
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ImageTypeSource Source
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.PathType PathType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String Path
	{
		get => throw new System.NotImplementedException();
	}
	public static Autodesk.Revit.DB.ExternalResourceType ExternalResourceType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 HeightInPixels
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 WidthInPixels
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 PageNumber
	{
		get => throw new System.NotImplementedException();
	}
}

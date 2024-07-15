namespace Autodesk.Revit.DB;

public partial class ImageTypeOptions : System.IDisposable
{
	public ImageTypeOptions() {}
	public ImageTypeOptions(Autodesk.Revit.DB.ExternalResourceReference resourceReference,Autodesk.Revit.DB.ImageTypeSource sourceType) => throw new System.NotImplementedException();
	public ImageTypeOptions(System.String path,System.Boolean useRelativePath,Autodesk.Revit.DB.ImageTypeSource sourceType) => throw new System.NotImplementedException();
	public virtual void SetPath(System.String path,System.Boolean useRelativePath) => throw new System.NotImplementedException();
	public virtual void SetPath(System.String path) => throw new System.NotImplementedException();
	public virtual void SetExternalResourceReference(Autodesk.Revit.DB.ExternalResourceReference resourceReference) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValid(Autodesk.Revit.DB.Document document) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ImageTypeSource SourceType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Resolution
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 PageNumber
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Path
	{
		get => throw new System.NotImplementedException();
	}
}

namespace Autodesk.Revit.ApplicationServices;

public partial class ControlledApplication
{
	public ControlledApplication() {}
	public static Autodesk.Revit.DB.FailureDefinitionRegistry GetFailureDefinitionRegistry() => throw new System.NotImplementedException();
	public static void RegisterFailuresProcessor(Autodesk.Revit.DB.IFailuresProcessor processor) => throw new System.NotImplementedException();
	public virtual void WriteJournalComment(System.String comment,System.Boolean timeStamp) => throw new System.NotImplementedException();
	public virtual System.Boolean IsJournalPlaying() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetLibraryPaths() => throw new System.NotImplementedException();
	public virtual void SetLibraryPaths(System.Collections.Generic.IDictionary<System.String, System.String> paths) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.DefinitionFile OpenSharedParameterFile() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.AddInId ActiveAddInId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String SharedParametersFilename
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.ApplicationServices.ProductType Product
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.ApplicationServices.LanguageType Language
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.CitySet Cities
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String VersionBuild
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String VersionNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String VersionName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.Creation.Application Create
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String SubVersionNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CurrentUsersAddinsDataFolderPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CurrentUsersDataFolderPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String AllUsersAddinsLocation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CurrentUserAddinsLocation
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String RecordingJournalFilename
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsLateAddinLoading
	{
		get => throw new System.NotImplementedException();
	}
}

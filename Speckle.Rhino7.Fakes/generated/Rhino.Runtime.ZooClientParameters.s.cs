namespace Rhino.Runtime;

public partial class ZooClientParameters
{
	public ZooClientParameters() {}
	public virtual System.Boolean VerifyPreviousVersionLicense(System.String license,System.String previousVersionLicense,out System.String errorMessage) => throw new System.NotImplementedException();
	public virtual System.Guid ProductGuid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid LicenseGuid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String ProductTitle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 ProductBuildType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String LicenseEntryTextMask
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String ProductPath
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Object ParentWindow
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Runtime.LicenseTypes SelectedLicenseType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

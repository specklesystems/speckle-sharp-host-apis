namespace Rhino.Runtime;

public partial interface IZooClientUtilities
{
	public  System.Boolean Initialize(System.Object verify);
	public  System.String Echo(System.Object verify,System.String message);
	public  System.Boolean GetLicense(System.Object verify,Rhino.Runtime.ZooClientParameters parameters);
	public  System.Boolean ReturnLicense(System.Object verify,System.Guid productId);
	public  System.Boolean ReturnLicense(System.Object verify,System.String productPath,System.Guid productId);
	public  System.Boolean CheckOutLicense(System.Object verify,System.Guid productId);
	public  System.Boolean CheckInLicense(System.Object verify,System.Guid productId);
	public  System.Boolean ConvertLicense(System.Object verify,System.Guid productId);
	public  System.Boolean DeleteLicense(System.Object verify,System.Guid productId);
	public  System.Int32 GetLicenseType(System.Object verify,System.Guid productId);
	public  System.Boolean IsCheckOutEnabled(System.Object verify);
	public  void ShowBuyLicenseUi(System.Object verify,System.Guid productId);
	public  System.Boolean AskUserForLicense(System.Object verify,Rhino.Runtime.ZooClientParameters parameters);
	public  System.Boolean LicenseOptionsHandler(System.Object verify,Rhino.Runtime.ZooClientParameters parameters);
	public  System.Boolean ShowLicenseValidationUi(System.Object verify,System.String cdkey);
	public  System.Boolean LoginToCloudZoo();
	public  System.Boolean LogoutOfCloudZoo();
	public  System.DateTime GetCurrentTime();
	public  System.Drawing.Image LoggedInUserAvatar
	{
		get;
	}
	public  System.String LoggedInUserName
	{
		get;
	}
	public  System.Boolean UserIsLoggedIn
	{
		get;
	}
}

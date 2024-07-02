namespace Autodesk.Revit.DB;

public partial interface ICentralLockedCallback
{
	public  System.Boolean ShouldWaitForLockAvailability();
}

namespace Rhino;

public partial class RhinoApp
{
	public RhinoApp() {}
	public static System.Boolean InFullScreen() => throw new System.NotImplementedException();
	public static System.Boolean RunningOnVMWare() => throw new System.NotImplementedException();
	public static System.Boolean RunningInRdp() => throw new System.NotImplementedException();
	public static System.String ParseTextField(System.String formula,Rhino.DocObjects.RhinoObject obj,Rhino.DocObjects.RhinoObject topParentObject) => throw new System.NotImplementedException();
	public static System.String GetDataDirectory(System.Boolean localUser,System.Boolean forceDirectoryCreation) => throw new System.NotImplementedException();
	public static System.String GetDataDirectory(System.Boolean localUser,System.Boolean forceDirectoryCreation,System.String subDirectory) => throw new System.NotImplementedException();
	public static System.IO.DirectoryInfo GetExecutableDirectory() => throw new System.NotImplementedException();
	public static void Write(System.String message) => throw new System.NotImplementedException();
	public static void Write(System.String format,System.Object arg0) => throw new System.NotImplementedException();
	public static void Write(System.String format,System.Object arg0,System.Object arg1) => throw new System.NotImplementedException();
	public static void Write(System.String format,System.Object arg0,System.Object arg1,System.Object arg2) => throw new System.NotImplementedException();
	public static void WriteLine() => throw new System.NotImplementedException();
	public static void WriteLine(System.String message) => throw new System.NotImplementedException();
	public static void WriteLine(System.String format,System.Object arg0) => throw new System.NotImplementedException();
	public static void WriteLine(System.String format,System.Object arg0,System.Object arg1) => throw new System.NotImplementedException();
	public static void WriteLine(System.String format,System.Object arg0,System.Object arg1,System.Object arg2) => throw new System.NotImplementedException();
	public static System.String[] CapturedCommandWindowStrings(System.Boolean clearBuffer) => throw new System.NotImplementedException();
	public static void OutputDebugString(System.String str) => throw new System.NotImplementedException();
	public static void SetCommandPromptMessage(System.String prompt) => throw new System.NotImplementedException();
	public static void SetCommandPrompt(System.String prompt,System.String promptDefault) => throw new System.NotImplementedException();
	public static void SetCommandPrompt(System.String prompt) => throw new System.NotImplementedException();
	public static void ClearCommandHistoryWindow() => throw new System.NotImplementedException();
	public static void SendKeystrokes(System.String characters,System.Boolean appendReturn) => throw new System.NotImplementedException();
	public static void SetFocusToMainWindow() => throw new System.NotImplementedException();
	public static void SetFocusToMainWindow(Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public static System.Boolean ReleaseMouseCapture() => throw new System.NotImplementedException();
	public static void Exit() => throw new System.NotImplementedException();
	public static void Exit(System.Boolean allowCancel) => throw new System.NotImplementedException();
	public static System.Boolean RunScript(System.UInt32 documentSerialNumber,System.String script,System.Boolean echo) => throw new System.NotImplementedException();
	public static System.Boolean RunScript(System.UInt32 documentSerialNumber,System.String script,System.String mruDisplayString,System.Boolean echo) => throw new System.NotImplementedException();
	public static System.Boolean RunScript(System.String script,System.Boolean echo) => throw new System.NotImplementedException();
	public static Rhino.Commands.Result ExecuteCommand(Rhino.RhinoDoc document,System.String commandName) => throw new System.NotImplementedException();
	public static System.Boolean RunScript(System.String script,System.String mruDisplayString,System.Boolean echo) => throw new System.NotImplementedException();
	public static System.Boolean RunMenuScript(System.String script) => throw new System.NotImplementedException();
	public static void Wait() => throw new System.NotImplementedException();
	public static void InvokeOnUiThread(System.Delegate method,System.Object[] args) => throw new System.NotImplementedException();
	public static void InvokeAndWait(System.Action action) => throw new System.NotImplementedException();
	public static System.IntPtr MainWindowHandle() => throw new System.NotImplementedException();
	public static System.Object GetPlugInObject(System.Guid pluginId) => throw new System.NotImplementedException();
	public static System.Object GetPlugInObject(System.String plugin) => throw new System.NotImplementedException();
	public static System.Boolean AskUserForRhinoLicense(System.Boolean standAlone,System.Object parentWindow) => throw new System.NotImplementedException();
	public static System.Boolean ChangeLicenseKey(System.Guid pluginId) => throw new System.NotImplementedException();
	public static System.Boolean RefreshRhinoLicense() => throw new System.NotImplementedException();
	public static System.Boolean LoginToCloudZoo() => throw new System.NotImplementedException();
	public static System.Int32 SdkVersion
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Int32 SdkServiceRelease
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Int32 ExeVersion
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Int32 ExeServiceRelease
	{
		get => throw new System.NotImplementedException();
	}
	public static System.DateTime BuildDate
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String VersionControlRevision
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Version Version
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String SerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String LicenseUserName
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String LicenseUserOrganization
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String InstallationTypeString
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String Name
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String SchemeName
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Guid Rhino2Id
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Guid Rhino3Id
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Guid Rhino4Id
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Guid Rhino5Id
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Guid Rhino6Id
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Guid Rhino7Id
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Guid CurrentRhinoId
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsRunningAutomated
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsRunningHeadless
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsSafeModeEnabled
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsSkinned
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.RhinoApp.CommandLineTextWriter CommandLineOut
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean CommandWindowCaptureEnabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public static System.Boolean SendWriteToConsole
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public static System.String CommandPrompt
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public static System.String CommandHistoryWindowText
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean InvokeRequired
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean LicenseExpires
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsPreRelease
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsLicenseValidated
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsCloudZooNode
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsInternetAccessAllowed
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean CanSave
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Int32 UpdatesAndStatisticsStatus
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Int32 ValidationGracePeriodDaysLeft
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Int32 DaysUntilExpiration
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String LoggedInUserName
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean UserIsLoggedIn
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsClosing
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean IsExiting
	{
		get => throw new System.NotImplementedException();
	}
	public static Rhino.DocObjects.Font DefaultUiFont
	{
		get => throw new System.NotImplementedException();
	}
}

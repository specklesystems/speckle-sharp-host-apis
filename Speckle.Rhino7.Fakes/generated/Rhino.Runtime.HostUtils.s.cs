namespace Rhino.Runtime;

public partial class HostUtils
{
	public HostUtils() {}
	public static T GetPlatformService<T>(System.String assemblyPath,System.String typeFullName) => throw new System.NotImplementedException();
	public static System.Boolean IsManagedDll(System.String path) => throw new System.NotImplementedException();
	public static void ClearFpuExceptionStatus() => throw new System.NotImplementedException();
	public static void RegisterNamedCallback(System.String name,System.EventHandler<Rhino.Runtime.NamedParametersEventArgs> callback) => throw new System.NotImplementedException();
	public static System.Boolean ExecuteNamedCallback(System.String name,Rhino.Runtime.NamedParametersEventArgs args) => throw new System.NotImplementedException();
	public static void RegisterComputeEndpoint(System.String endpointPath,System.Type t) => throw new System.NotImplementedException();
	public static System.String[] GetAssemblySearchPaths() => throw new System.NotImplementedException();
	public static void InPlaceConstCast(Rhino.Geometry.GeometryBase geometry,System.Boolean makeNonConst) => throw new System.NotImplementedException();
	public static System.Boolean CheckForRdk(System.Boolean throwOnFalse,System.Boolean usePreviousResult) => throw new System.NotImplementedException();
	public static System.Boolean IsRhinoFileExtension(System.String fileExtension) => throw new System.NotImplementedException();
	public static System.Boolean FileNameEndsWithRhinoExtension(System.String fileName) => throw new System.NotImplementedException();
	public static System.Boolean IsRhinoBackupFileExtension(System.String fileExtension) => throw new System.NotImplementedException();
	public static System.Boolean FileNameEndsWithRhinoBackupExtension(System.String fileName) => throw new System.NotImplementedException();
	public static void DebugString(System.String msg) => throw new System.NotImplementedException();
	public static void DebugString(System.String format,System.Object[] args) => throw new System.NotImplementedException();
	public static void ExceptionReport(System.Exception ex) => throw new System.NotImplementedException();
	public static void ExceptionReport(System.String source,System.Exception ex) => throw new System.NotImplementedException();
	public static void SendLogMessageToCloudCallbackProc(Rhino.Runtime.HostUtils.LogMessageType msg_type,System.IntPtr pwStringClass,System.IntPtr pwStringDesc,System.IntPtr pwStringMessage) => throw new System.NotImplementedException();
	public static System.String DebugDumpToString(Rhino.Geometry.GeometryBase geometry) => throw new System.NotImplementedException();
	public static System.String DebugDumpToString(Rhino.Geometry.BezierCurve bezierCurve) => throw new System.NotImplementedException();
	public static void RecordInitInstanceTime(System.String description) => throw new System.NotImplementedException();
	public static System.Int32 CreateCommands(System.IntPtr pPlugIn,System.Reflection.Assembly pluginAssembly) => throw new System.NotImplementedException();
	public static System.String AutoInstallPlugInFolder(System.Boolean currentUser) => throw new System.NotImplementedException();
	public static System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> GetActivePlugInVersionFolders(System.Boolean currentUser) => throw new System.NotImplementedException();
	public static void InitializeRhinoCommon() => throw new System.NotImplementedException();
	public static void InitializeRhinoCommon_RDK() => throw new System.NotImplementedException();
	public static void ShutDownRhinoCommon_RDK() => throw new System.NotImplementedException();
	public static void RhinoCommonExceptionHandler(System.String title,System.Object sender,System.Exception ex) => throw new System.NotImplementedException();
	public static void UnhandledThreadException(System.Object sender,System.Threading.ThreadExceptionEventArgs e) => throw new System.NotImplementedException();
	public static void InitializeZooClient() => throw new System.NotImplementedException();
	public static System.Int32 CallFromCoreRhino(System.String task) => throw new System.NotImplementedException();
	public static void DisplayOleAlerts(System.Boolean display) => throw new System.NotImplementedException();
	public static System.Int32 GetSystemProcessorCount() => throw new System.NotImplementedException();
	public static System.Reflection.Assembly GetRhinoDotNetAssembly() => throw new System.NotImplementedException();
	public static void SetInShutDown() => throw new System.NotImplementedException();
	public static System.Boolean RunningAsRhinoInside
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String OperatingSystemEdition
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String OperatingSystemInstallationType
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String OperatingSystemProductName
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String OperatingSystemVersion
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String OperatingSystemBuildNumber
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean RunningOnWindows
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean RunningOnOSX
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean RunningOnServer
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean RunningInWindowsContainer
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean RunningInDarkMode
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String DeviceName
	{
		get => throw new System.NotImplementedException();
	}
	public static System.String ComputerSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public static System.UInt32 CurrentOSLanguage
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Guid DeviceId
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean RunningInMono
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean RunningInRhino
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Boolean SendDebugToCommandLine
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

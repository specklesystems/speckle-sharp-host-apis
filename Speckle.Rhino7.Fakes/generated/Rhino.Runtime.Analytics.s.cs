namespace Rhino.Runtime;

public partial class Analytics
{
	public Analytics() {}
	public Analytics(System.String TrackingID,System.String Name) => throw new System.NotImplementedException();
	public Analytics(System.String TrackingID,System.String Name,System.String Platform,System.String InstallerId,System.String Version) => throw new System.NotImplementedException();
	public virtual void Send(System.String Category,System.String Action,System.String Label,System.UInt32 Value) => throw new System.NotImplementedException();
	public virtual void Send(System.Collections.Specialized.NameValueCollection data) => throw new System.NotImplementedException();
	public virtual void Send(System.String Category) => throw new System.NotImplementedException();
	public virtual void Send(System.String Category,System.String Action) => throw new System.NotImplementedException();
	public virtual void Send(System.String Category,System.String Action,System.String Label) => throw new System.NotImplementedException();
	public virtual System.String GoogleAnalyticsTrackingID
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String AppName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String AppPlatform
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String AppInstallerId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String AppVersion
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public static System.Boolean UsageStatisticsEnabled
	{
		get => throw new System.NotImplementedException();
	}
	public static System.Guid UserId
	{
		get => throw new System.NotImplementedException();
	}
}

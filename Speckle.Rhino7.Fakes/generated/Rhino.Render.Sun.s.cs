namespace Rhino.Render;

public partial class Sun : Rhino.Render.DocumentOrFreeFloatingBase,System.IDisposable
{
	public Sun() {}
	public static Rhino.Geometry.Vector3d SunDirection(System.Double latitude,System.Double longitude,System.DateTime when) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual void SetPosition(System.Double azimuthDegrees,System.Double altitudeDegrees) => throw new System.NotImplementedException();
	public virtual void SetPosition(System.DateTime when,System.Double latitudeDegrees,System.Double longitudeDegrees) => throw new System.NotImplementedException();
	public virtual System.DateTime GetDateTime(System.DateTimeKind kind) => throw new System.NotImplementedException();
	public virtual void SetDateTime(System.DateTime time,System.DateTimeKind kind) => throw new System.NotImplementedException();
	public virtual void ShowDialog() => throw new System.NotImplementedException();
	public static System.Drawing.Color ColorFromAltitude(System.Double altitudeDegrees) => throw new System.NotImplementedException();
	public static System.Double AltitudeFromValues(System.Double latitude,System.Double longitude,System.Double timezoneHours,System.Int32 daylightMinutes,System.DateTime when,System.Double hours,System.Boolean fast) => throw new System.NotImplementedException();
	public static System.Double JulianDay(System.Double timezoneHours,System.Int32 daylightMinutes,System.DateTime when,System.Double hours) => throw new System.NotImplementedException();
	public static System.Double TwilightZone() => throw new System.NotImplementedException();
	public static System.Boolean Here(out System.Double latitude,out System.Double longitude) => throw new System.NotImplementedException();
	public virtual System.Boolean Enabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ManualControl
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean SkylightOn
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean DaylightSaving
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 DaylightSavingMinutes
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TimeZone
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double North
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Intensity
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Vector3d Vector
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Light Light
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Azimuth
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Altitude
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Latitude
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double Longitude
	{
		get => throw new System.NotImplementedException();
	}
}

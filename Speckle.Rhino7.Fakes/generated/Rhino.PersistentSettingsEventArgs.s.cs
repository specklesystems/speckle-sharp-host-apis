namespace Rhino;

public partial class PersistentSettingsEventArgs : System.EventArgs
{
	public PersistentSettingsEventArgs() {}
	public virtual System.Boolean Cancel
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

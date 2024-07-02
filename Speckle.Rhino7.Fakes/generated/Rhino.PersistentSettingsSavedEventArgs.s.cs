namespace Rhino;

public partial class PersistentSettingsSavedEventArgs : System.EventArgs
{
	public PersistentSettingsSavedEventArgs() {}
	public virtual Rhino.PersistentSettings CommandSettings(System.String englishCommandName) => throw new System.NotImplementedException();
	public virtual System.Boolean SavedByThisRhino
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.PersistentSettings PlugInSettings
	{
		get => throw new System.NotImplementedException();
	}
}

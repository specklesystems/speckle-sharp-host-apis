namespace Rhino;

public partial class PersistentSettingsEventArgs<T> : Rhino.PersistentSettingsEventArgs
{
	public PersistentSettingsEventArgs() {}
	public PersistentSettingsEventArgs(T currentValue,T newValue) => throw new System.NotImplementedException();
	public virtual T CurrentValue
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual T NewValue
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

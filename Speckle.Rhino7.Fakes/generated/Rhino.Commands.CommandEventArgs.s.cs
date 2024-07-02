namespace Rhino.Commands;

public partial class CommandEventArgs : System.EventArgs
{
	public CommandEventArgs() {}
	public virtual System.Guid CommandId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CommandEnglishName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CommandLocalName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String CommandPluginName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Commands.Result CommandResult
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 DocumentRuntimeSerialNumber
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.RhinoDoc Document
	{
		get => throw new System.NotImplementedException();
	}
}

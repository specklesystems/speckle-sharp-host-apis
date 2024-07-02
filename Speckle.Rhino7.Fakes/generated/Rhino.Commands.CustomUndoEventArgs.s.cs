namespace Rhino.Commands;

public partial class CustomUndoEventArgs : System.EventArgs
{
	public CustomUndoEventArgs() {}
	public virtual System.Guid CommandId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 UndoSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String ActionDescription
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean CreatedByRedo
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Object Tag
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.RhinoDoc Document
	{
		get => throw new System.NotImplementedException();
	}
}

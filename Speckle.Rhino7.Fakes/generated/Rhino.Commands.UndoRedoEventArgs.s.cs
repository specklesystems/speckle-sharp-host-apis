namespace Rhino.Commands;

public partial class UndoRedoEventArgs : System.EventArgs
{
	public UndoRedoEventArgs() {}
	public virtual System.Guid CommandId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.UInt32 UndoSerialNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsBeginRecording
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsEndRecording
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsBeginUndo
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsEndUndo
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsBeginRedo
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsEndRedo
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsPurgeRecord
	{
		get => throw new System.NotImplementedException();
	}
}

namespace Rhino;

public partial class DocumentOpenEventArgs : Rhino.DocumentEventArgs
{
	public DocumentOpenEventArgs() {}
	public virtual System.String FileName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Merge
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Reference
	{
		get => throw new System.NotImplementedException();
	}
}

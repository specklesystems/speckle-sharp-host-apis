namespace Rhino;

public partial class DocumentEventArgs : System.EventArgs
{
  public DocumentEventArgs() { }

  public virtual System.Int32 DocumentId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt32 DocumentSerialNumber
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.RhinoDoc Document
  {
    get => throw new System.NotImplementedException();
  }
}

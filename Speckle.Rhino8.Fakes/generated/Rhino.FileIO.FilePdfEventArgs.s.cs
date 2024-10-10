namespace Rhino.FileIO;

public partial class FilePdfEventArgs : System.EventArgs
{
  public FilePdfEventArgs() { }

  public virtual Rhino.FileIO.FilePdf Pdf
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

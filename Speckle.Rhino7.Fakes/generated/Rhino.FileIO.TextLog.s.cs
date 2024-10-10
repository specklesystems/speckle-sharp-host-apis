namespace Rhino.FileIO;

public partial class TextLog : System.IDisposable
{
  public TextLog() { }

  public TextLog(System.String filename) => throw new System.NotImplementedException();

  public TextLog(System.IntPtr ptr) => throw new System.NotImplementedException();

  public virtual void PushIndent() => throw new System.NotImplementedException();

  public virtual void PopIndent() => throw new System.NotImplementedException();

  public virtual void PrintWrappedText(System.String text, System.Int32 lineLength) =>
    throw new System.NotImplementedException();

  public virtual void Print(System.String text) => throw new System.NotImplementedException();

  public virtual void Print(System.String format, System.Object arg0) => throw new System.NotImplementedException();

  public virtual void Print(System.String format, System.Object arg0, System.Object arg1) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public static Rhino.FileIO.TextLog NewCommandLine() => throw new System.NotImplementedException();

  public virtual System.Int32 IndentSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

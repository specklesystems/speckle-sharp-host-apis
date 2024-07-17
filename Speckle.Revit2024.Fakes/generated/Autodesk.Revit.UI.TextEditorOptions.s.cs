namespace Autodesk.Revit.UI;

public partial class TextEditorOptions : System.IDisposable
{
  public TextEditorOptions() { }

  public static Autodesk.Revit.UI.TextEditorOptions GetTextEditorOptions() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ShowOpaqueBackground
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowBorder
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Autodesk.Revit.UI;

public partial class FileDialog : System.IDisposable
{
  public FileDialog() { }

  public virtual Autodesk.Revit.DB.ModelPath GetSelectedModelPath() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.UI.ItemSelectionDialogResult Show() => throw new System.NotImplementedException();

  public static System.Boolean IsValidFilterString(System.String filterString) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String DefaultFilterEntry
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Title
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Filter
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

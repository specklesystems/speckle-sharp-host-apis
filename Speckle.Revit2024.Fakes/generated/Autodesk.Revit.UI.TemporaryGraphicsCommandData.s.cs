namespace Autodesk.Revit.UI;

public partial class TemporaryGraphicsCommandData : Autodesk.Revit.DB.ExternalService.IExternalData, System.IDisposable
{
  public TemporaryGraphicsCommandData() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 Index
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Document Document
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Autodesk.Revit.DB;

public partial class InSessionPrintSetting : Autodesk.Revit.DB.IPrintSetting, System.IDisposable
{
  public InSessionPrintSetting() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.PrintParameters PrintParameters
  {
    get => throw new System.NotImplementedException();
  }
}

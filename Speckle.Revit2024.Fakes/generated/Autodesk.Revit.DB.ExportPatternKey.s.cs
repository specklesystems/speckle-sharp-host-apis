namespace Autodesk.Revit.DB;

public partial class ExportPatternKey : System.IDisposable
{
  public ExportPatternKey() { }

  public ExportPatternKey(
    Autodesk.Revit.DB.FillPatternTarget originalFillPatternType,
    System.String originalFillPatternName
  ) => throw new System.NotImplementedException();

  public ExportPatternKey(Autodesk.Revit.DB.ExportPatternKey other) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String OriginalFillPatternName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.FillPatternTarget OriginalFillPatternType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

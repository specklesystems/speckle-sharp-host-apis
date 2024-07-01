namespace Autodesk.Revit.DB;

public partial class FailureHandlingOptions : System.IDisposable
{
  public virtual Autodesk.Revit.DB.FailureHandlingOptions SetForcedModalHandling(System.Boolean bFlag) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FailureHandlingOptions SetClearAfterRollback(System.Boolean bFlag) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FailureHandlingOptions SetDelayedMiniWarnings(System.Boolean bFlag) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FailureHandlingOptions SetTransactionFinalizer(
    Autodesk.Revit.DB.ITransactionFinalizer finalizer
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.FailureHandlingOptions SetFailuresPreprocessor(
    Autodesk.Revit.DB.IFailuresPreprocessor preprocessor
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetForcedModalHandling() => throw new System.NotImplementedException();

  public virtual System.Boolean GetClearAfterRollback() => throw new System.NotImplementedException();

  public virtual System.Boolean GetDelayedMiniWarnings() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ITransactionFinalizer GetTransactionFinalizer() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.IFailuresPreprocessor GetFailuresPreprocessor() =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
}

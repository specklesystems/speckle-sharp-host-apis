namespace Autodesk.Revit.DB.Analysis;

public partial class AnalysisDisplayColorSettings : System.IDisposable
{
  public AnalysisDisplayColorSettings() => throw new System.NotImplementedException();

  public AnalysisDisplayColorSettings(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings other) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry> GetIntermediateColors() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean AreIntermediateColorsValid(
    System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry> map
  ) => throw new System.NotImplementedException();

  public virtual void SetIntermediateColors(
    System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.AnalysisDisplayColorEntry> map
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 Colors() => throw new System.NotImplementedException();

  public virtual System.Boolean IsEqual(Autodesk.Revit.DB.Analysis.AnalysisDisplayColorSettings other) =>
    throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Analysis.AnalysisDisplayStyleColorSettingsType ColorSettingsType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Color MinColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Color MaxColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

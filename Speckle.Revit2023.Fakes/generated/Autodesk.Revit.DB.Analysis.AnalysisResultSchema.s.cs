namespace Autodesk.Revit.DB.Analysis;

public partial class AnalysisResultSchema : System.IDisposable
{
  public AnalysisResultSchema() { }

  public AnalysisResultSchema(System.String name, System.String description) =>
    throw new System.NotImplementedException();

  public AnalysisResultSchema(Autodesk.Revit.DB.Analysis.AnalysisResultSchema other) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsEqual(Autodesk.Revit.DB.Analysis.AnalysisResultSchema other) =>
    throw new System.NotImplementedException();

  public virtual void SetUnits(
    System.Collections.Generic.IList<System.String> names,
    System.Collections.Generic.IList<System.Double> multipliers
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 GetNumberOfUnits() => throw new System.NotImplementedException();

  public virtual System.String GetUnitsName(System.Int32 index) => throw new System.NotImplementedException();

  public virtual System.Double GetUnitsMultiplier(System.Int32 index) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidObject
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Scale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 CurrentUnits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsVisible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId AnalysisDisplayStyleId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Description
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

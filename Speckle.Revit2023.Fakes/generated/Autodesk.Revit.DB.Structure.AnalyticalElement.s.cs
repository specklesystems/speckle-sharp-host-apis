namespace Autodesk.Revit.DB.Structure;

public partial class AnalyticalElement : Autodesk.Revit.DB.Element
{
  public virtual Autodesk.Revit.DB.Transform GetTransform() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidSelector(Autodesk.Revit.DB.Structure.AnalyticalModelSelector selector) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Reference GetReference(
    Autodesk.Revit.DB.Structure.AnalyticalModelSelector selector
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Curve GetCurve() => throw new System.NotImplementedException();

  public virtual System.Boolean IsSingleCurve() => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidAnalyzeAs(Autodesk.Revit.DB.Structure.AnalyzeAs analyzeAs) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsValidStructuralRole(
    Autodesk.Revit.DB.Structure.AnalyticalStructuralRole structuralRole
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Structure.AnalyticalStructuralRole StructuralRole
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.Structure.AnalyzeAs AnalyzeAs
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId MaterialId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Autodesk.Revit.DB.Analysis;

public partial class EnergyAnalysisOpening : Autodesk.Revit.DB.Element
{
  public virtual Autodesk.Revit.DB.Analysis.EnergyAnalysisSurface GetAnalyticalSurface() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Analysis.Polyloop GetPolyloop() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Analysis.Polyloop> GetPolyloops() =>
    throw new System.NotImplementedException();

  public virtual System.String OpeningId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String OriginatingElementDescription
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.XYZ Corner
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Analysis.EnergyAnalysisOpeningType OpeningType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String CADLinkUniqueId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String CADObjectUniqueId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String OpeningName
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.Analysis.gbXMLOpeningType Type
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Width
  {
    get => throw new System.NotImplementedException();
  }
}

namespace Autodesk.Revit.DB;

public partial class CurtainGrid : Autodesk.Revit.DB.APIObject
{
  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetPanelIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetUnlockedPanelIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetMullionIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetUnlockedMullionIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetUGridLineIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetVGridLineIds() =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.CurtainCell> GetCurtainCells() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Element ChangePanelType(
    Autodesk.Revit.DB.Element panel,
    Autodesk.Revit.DB.ElementType newSymbol
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurtainGridLine AddGridLine(
    System.Boolean isUGridLine,
    Autodesk.Revit.DB.XYZ position,
    System.Boolean oneSegmentOnly
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Panel GetPanel(
    Autodesk.Revit.DB.ElementId uGridLineId,
    Autodesk.Revit.DB.ElementId vGridLineId
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.CurtainCell GetCell(
    Autodesk.Revit.DB.ElementId uGridLineId,
    Autodesk.Revit.DB.ElementId vGridLineId
  ) => throw new System.NotImplementedException();

  public virtual System.Int32 NumPanels
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumVLines
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 NumULines
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Grid2Offset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Grid2Angle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.CurtainGridAlignType Grid2Justification
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Grid1Offset
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Grid1Angle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.CurtainGridAlignType Grid1Justification
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

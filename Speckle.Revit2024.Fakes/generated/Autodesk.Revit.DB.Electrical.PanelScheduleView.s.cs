namespace Autodesk.Revit.DB.Electrical;

public partial class PanelScheduleView : Autodesk.Revit.DB.TableView
{
  public PanelScheduleView() { }

  public static Autodesk.Revit.DB.Electrical.PanelScheduleView CreateInstanceView(
    Autodesk.Revit.DB.Document ADoc,
    Autodesk.Revit.DB.ElementId templateId,
    Autodesk.Revit.DB.ElementId panelId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.Electrical.PanelScheduleView CreateInstanceView(
    Autodesk.Revit.DB.Document ADoc,
    Autodesk.Revit.DB.ElementId panelId
  ) => throw new System.NotImplementedException();

  public virtual void GenerateInstanceFromTemplate(Autodesk.Revit.DB.ElementId templateId) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsPanelScheduleTemplate() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.PanelScheduleData GetTableData() =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TableSectionData GetSectionData(Autodesk.Revit.DB.SectionType sectionType) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetTemplate() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetPanel() => throw new System.NotImplementedException();

  public virtual System.String GetParamValue(
    Autodesk.Revit.DB.SectionType sectionType,
    System.Int32 nRow,
    System.Int32 nCol
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetParamValue(
    Autodesk.Revit.DB.SectionType sectionType,
    System.Int32 nRow,
    System.Int32 nCol,
    System.String sValue
  ) => throw new System.NotImplementedException();

  public virtual System.String GetLoadClassificationParamValue(
    Autodesk.Revit.DB.ElementId parameterId,
    System.Int32 nRow,
    System.Int32 nCol
  ) => throw new System.NotImplementedException();

  public virtual System.String GetLoadClassificationName(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual System.String GetLoadClassificationDemandLoad(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual System.String GetLoadClassificationConnectedLoad(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual System.String GetLoadClassificationDemandCurrent(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual System.String GetLoadClassificationConnectedCurrent(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual System.String GetLoadClassificationDemandFactor(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetLoadClassificationId(System.Int32 nRow) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetApparentPhaseValue(
    Autodesk.Revit.DB.ElementId circuitId,
    Autodesk.Revit.DB.ElementId apparentLoadParam
  ) => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Electrical.ElectricalSystem GetCircuitByCell(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ElementId GetCircuitIdByCell(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 GetSlotNumberByCell(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual void GetCellsBySlotNumber(
    System.Int32 nSlotNumber,
    out System.Collections.Generic.IList<System.Int32> RowArr,
    out System.Collections.Generic.IList<System.Int32> ColArr
  ) => throw new System.NotImplementedException();

  public virtual void SetSpareLoadValue(
    System.Int32 row,
    System.Int32 column,
    Autodesk.Revit.DB.ElementId idLoadParameter,
    System.Double value
  ) => throw new System.NotImplementedException();

  public virtual System.Double GetSpareLoadValue(
    System.Int32 row,
    System.Int32 column,
    Autodesk.Revit.DB.ElementId idLoadParameter
  ) => throw new System.NotImplementedException();

  public virtual void SetSpareCurrentValue(
    System.Int32 row,
    System.Int32 column,
    Autodesk.Revit.DB.ElementId idCurrentParameter,
    System.Double value
  ) => throw new System.NotImplementedException();

  public virtual System.Double GetSpareCurrentValue(
    System.Int32 row,
    System.Int32 column,
    Autodesk.Revit.DB.ElementId idCurrentParameter
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsCellInPhaseLoads(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsRowInCircuitTable(System.Int32 nRow) => throw new System.NotImplementedException();

  public virtual System.Boolean IsColumnInLoadSummary(System.Int32 nCol) => throw new System.NotImplementedException();

  public virtual System.String GetCombinedParamValue(
    Autodesk.Revit.DB.SectionType sectionType,
    System.Int32 nRow,
    System.Int32 nCol
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsSlotLocked(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual void SetLockSlot(System.Int32 nRow, System.Int32 nCol, System.Boolean bLock) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 IsSlotGrouped(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSpare(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsSpace(System.Int32 nRow, System.Int32 nCol) =>
    throw new System.NotImplementedException();

  public virtual void AddSpace(System.Int32 nRow, System.Int32 nCol) => throw new System.NotImplementedException();

  public virtual void AddSpare(System.Int32 nRow, System.Int32 nCol) => throw new System.NotImplementedException();

  public virtual void RemoveSpace(System.Int32 nRow, System.Int32 nCol) => throw new System.NotImplementedException();

  public virtual void RemoveSpare(System.Int32 nRow, System.Int32 nCol) => throw new System.NotImplementedException();

  public virtual System.Boolean CanMoveSlotTo(
    System.Int32 nMovingRow,
    System.Int32 nMovingCol,
    System.Int32 nToRow,
    System.Int32 nToCol
  ) => throw new System.NotImplementedException();

  public virtual void MoveSlotTo(
    System.Int32 nMovingRow,
    System.Int32 nMovingCol,
    System.Int32 nToRow,
    System.Int32 nToCol
  ) => throw new System.NotImplementedException();

  public virtual void RenumberIndexes() => throw new System.NotImplementedException();

  public virtual void SwitchPhases(System.Int32 nRow, System.Int32 nCol) => throw new System.NotImplementedException();
}

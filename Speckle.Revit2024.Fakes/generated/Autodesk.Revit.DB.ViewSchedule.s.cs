namespace Autodesk.Revit.DB;

public partial class ViewSchedule : Autodesk.Revit.DB.TableView
{
  public ViewSchedule() { }

  public static Autodesk.Revit.DB.ViewSchedule CreateSchedule(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId,
    Autodesk.Revit.DB.ElementId areaSchemeId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewSchedule CreateSchedule(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewSchedule CreateKeySchedule(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewSchedule CreateMaterialTakeoff(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewSchedule CreateViewList(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewSchedule CreateSheetList(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewSchedule CreateKeynoteLegend(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewSchedule CreateRevisionSchedule(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static Autodesk.Revit.DB.ViewSchedule CreateNoteBlock(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId familyId
  ) => throw new System.NotImplementedException();

  public static System.Boolean IsValidCategoryForSchedule(Autodesk.Revit.DB.ElementId categoryId) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidCategoryForKeySchedule(Autodesk.Revit.DB.ElementId categoryId) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidCategoryForMaterialTakeoff(Autodesk.Revit.DB.ElementId categoryId) =>
    throw new System.NotImplementedException();

  public static System.Boolean IsValidFamilyForNoteBlock(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId familyId
  ) => throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetValidCategoriesForSchedule() =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetValidCategoriesForKeySchedule() =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetValidCategoriesForMaterialTakeoff() =>
    throw new System.NotImplementedException();

  public static System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetValidFamiliesForNoteBlock(
    Autodesk.Revit.DB.Document document
  ) => throw new System.NotImplementedException();

  public static System.String GetDefaultNameForSchedule(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId,
    Autodesk.Revit.DB.ElementId areaSchemeId
  ) => throw new System.NotImplementedException();

  public static System.String GetDefaultNameForSchedule(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public static System.String GetDefaultNameForKeySchedule(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public static System.String GetDefaultParameterNameForKeySchedule(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public static System.String GetDefaultNameForMaterialTakeoff(
    Autodesk.Revit.DB.Document document,
    Autodesk.Revit.DB.ElementId categoryId
  ) => throw new System.NotImplementedException();

  public static System.String GetDefaultNameForViewList(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static System.String GetDefaultNameForSheetList(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static System.String GetDefaultNameForKeynoteLegend(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static System.String GetDefaultNameForRevisionSchedule(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public static System.String GetDefaultNameForNoteBlock(Autodesk.Revit.DB.Document document) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsDataOutOfDate() => throw new System.NotImplementedException();

  public virtual System.Boolean RefreshData() => throw new System.NotImplementedException();

  public virtual System.Boolean IsSplit() => throw new System.NotImplementedException();

  public virtual void Split(System.Collections.Generic.IList<System.Double> segmentHeights) =>
    throw new System.NotImplementedException();

  public virtual void Split(System.Int32 segmentNumber) => throw new System.NotImplementedException();

  public virtual void SplitSegment(
    System.Int32 segmentIndex,
    System.Collections.Generic.IList<System.Double> segmentHeights
  ) => throw new System.NotImplementedException();

  public virtual void DeleteSegment(System.Int32 segmentIndex) => throw new System.NotImplementedException();

  public virtual System.Int32 GetSegmentCount() => throw new System.NotImplementedException();

  public virtual void SetSegmentHeight(System.Int32 segmentIndex, System.Double height) =>
    throw new System.NotImplementedException();

  public virtual System.Double GetSegmentHeight(System.Int32 segmentIndex) =>
    throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.ElementId> GetScheduleInstances(
    System.Int32 segmentIndex
  ) => throw new System.NotImplementedException();

  public virtual void MergeSegments(System.Int32 movedSegmentIndex, System.Int32 targetSegmentIndex) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.ScheduleHeightsOnSheet GetScheduleHeightsOnSheet() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean CanGroupHeaders(
    System.Int32 top,
    System.Int32 left,
    System.Int32 bottom,
    System.Int32 right
  ) => throw new System.NotImplementedException();

  public virtual void GroupHeaders(
    System.Int32 top,
    System.Int32 left,
    System.Int32 bottom,
    System.Int32 right,
    System.String caption
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean CanUngroupHeaders(
    System.Int32 top,
    System.Int32 left,
    System.Int32 bottom,
    System.Int32 right
  ) => throw new System.NotImplementedException();

  public virtual void UngroupHeaders(System.Int32 top, System.Int32 left, System.Int32 bottom, System.Int32 right) =>
    throw new System.NotImplementedException();

  public virtual void RestoreImageSize() => throw new System.NotImplementedException();

  public virtual System.Boolean HasImageField() => throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.Color GetStripedRowsColor(Autodesk.Revit.DB.StripedRowPattern index) =>
    throw new System.NotImplementedException();

  public virtual void SetStripedRowsColor(Autodesk.Revit.DB.StripedRowPattern index, Autodesk.Revit.DB.Color color) =>
    throw new System.NotImplementedException();

  public virtual void Export(
    System.String folder,
    System.String name,
    Autodesk.Revit.DB.ViewScheduleExportOptions options
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean IsValidTextTypeId(Autodesk.Revit.DB.ElementId textTypeId) =>
    throw new System.NotImplementedException();

  public virtual Autodesk.Revit.DB.TableData GetTableData() => throw new System.NotImplementedException();

  public virtual System.Boolean IsInternalKeynoteSchedule
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsTitleblockRevisionSchedule
  {
    get => throw new System.NotImplementedException();
  }
  public static System.Boolean IsHeaderFrozen
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseStripedRowsOnSheets
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HasStripedRows
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.RowHeightOverrideOptions RowHeightOverride
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double RowHeight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ImageRowHeight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String KeyScheduleParameterName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ScheduleDefinition EmbeddedDefinition
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ScheduleDefinition Definition
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Autodesk.Revit.DB.ElementId BodyTextTypeId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId HeaderTextTypeId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Autodesk.Revit.DB.ElementId TitleTextTypeId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

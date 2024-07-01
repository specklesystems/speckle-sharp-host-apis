namespace Autodesk.Revit.DB;

public partial class TableSectionData : System.IDisposable
{
	public virtual System.Boolean IsDataOutOfDate() => throw new System.NotImplementedException();
	public virtual System.Boolean RefreshData() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidColumnNumber(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidRowNumber(System.Int32 nRow) => throw new System.NotImplementedException();
	public virtual void InsertImage(System.Int32 nRow,System.Int32 nColumn,Autodesk.Revit.DB.ElementId imageSymbolId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidImageSymbolId(Autodesk.Revit.DB.ElementId imageSymbolId) => throw new System.NotImplementedException();
	public virtual System.Boolean CanInsertRow(System.Int32 nIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean CanRemoveRow(System.Int32 nIndex) => throw new System.NotImplementedException();
	public virtual void InsertRow(System.Int32 nIndex) => throw new System.NotImplementedException();
	public virtual void RemoveRow(System.Int32 nIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean CanInsertColumn(System.Int32 nIndex) => throw new System.NotImplementedException();
	public virtual System.Boolean CanRemoveColumn(System.Int32 nIndex) => throw new System.NotImplementedException();
	public virtual void InsertColumn(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void RemoveColumn(System.Int32 nIndex) => throw new System.NotImplementedException();
	public virtual System.Double GetColumnWidth(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual System.Int32 GetColumnWidthInPixels(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void SetColumnWidth(System.Int32 nCol,System.Double width) => throw new System.NotImplementedException();
	public virtual void SetColumnWidthInPixels(System.Int32 nCol,System.Int32 width) => throw new System.NotImplementedException();
	public virtual System.Double GetRowHeight(System.Int32 nRow) => throw new System.NotImplementedException();
	public virtual System.Int32 GetRowHeightInPixels(System.Int32 nRow) => throw new System.NotImplementedException();
	public virtual void SetRowHeight(System.Int32 nRow,System.Double height) => throw new System.NotImplementedException();
	public virtual void SetRowHeightInPixels(System.Int32 nRow,System.Int32 height) => throw new System.NotImplementedException();
	public virtual System.String GetCellText(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void SetCellText(System.Int32 nRow,System.Int32 nCol,System.String text) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TableMergedCell GetMergedCell(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void SetMergedCell(System.Int32 nRow,System.Int32 nCol,Autodesk.Revit.DB.TableMergedCell mergedCell) => throw new System.NotImplementedException();
	public virtual void MergeCells(Autodesk.Revit.DB.TableMergedCell mergedCell) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TableCellStyle GetTableCellStyle(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual System.Boolean AllowOverrideCellStyle(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void SetCellStyle(Autodesk.Revit.DB.TableCellStyle Style) => throw new System.NotImplementedException();
	public virtual void SetCellStyle(System.Int32 nCol,Autodesk.Revit.DB.TableCellStyle Style) => throw new System.NotImplementedException();
	public virtual void SetCellStyle(System.Int32 nRow,System.Int32 nCol,Autodesk.Revit.DB.TableCellStyle Style) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCellOverridden(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCellOverridden(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void ResetCellOverride(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void ResetCellOverride(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void ClearCell(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CellType GetCellType(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.CellType GetCellType(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void SetCellType(System.Int32 nCol,Autodesk.Revit.DB.CellType type) => throw new System.NotImplementedException();
	public virtual void SetCellType(System.Int32 nRow,System.Int32 nCol,Autodesk.Revit.DB.CellType type) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormatOptions GetCellFormatOptions(System.Int32 nCol,Autodesk.Revit.DB.Document ccda) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormatOptions GetCellFormatOptions(System.Int32 nRow,System.Int32 nCol,Autodesk.Revit.DB.Document ccda) => throw new System.NotImplementedException();
	public virtual System.Boolean IsCellFormattable(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ForgeTypeId GetCellSpec(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void SetCellFormatOptions(System.Int32 nRow,System.Int32 nCol,Autodesk.Revit.DB.FormatOptions options) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCellParamId(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCellParamId(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCellCategoryId(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId GetCellCategoryId(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAcceptableParamIdAndCategoryId(System.Int32 nRow,Autodesk.Revit.DB.ElementId paramId,Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAcceptableParamIdAndCategoryId(Autodesk.Revit.DB.ElementId paramId,Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual void SetCellParamIdAndCategoryId(System.Int32 nCol,Autodesk.Revit.DB.ElementId paramId,Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual void SetCellParamIdAndCategoryId(System.Int32 nRow,System.Int32 nCol,Autodesk.Revit.DB.ElementId paramId,Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TableCellCalculatedValueData GetCellCalculatedValue(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TableCellCalculatedValueData GetCellCalculatedValue(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void SetCellCalculatedValue(System.Int32 nCol,Autodesk.Revit.DB.TableCellCalculatedValueData pCalcValue) => throw new System.NotImplementedException();
	public virtual void SetCellCalculatedValue(System.Int32 nRow,System.Int32 nCol,Autodesk.Revit.DB.TableCellCalculatedValueData pCalcValue) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.TableCellCombinedParameterData> GetCellCombinedParameters(System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.TableCellCombinedParameterData> GetCellCombinedParameters(System.Int32 nRow,System.Int32 nCol) => throw new System.NotImplementedException();
	public virtual void SetCellCombinedParameters(System.Int32 nCol,IList<Autodesk.Revit.DB.TableCellCombinedParameterData> paramData) => throw new System.NotImplementedException();
	public virtual void SetCellCombinedParameters(System.Int32 nRow,System.Int32 nCol,IList<Autodesk.Revit.DB.TableCellCombinedParameterData> paramData) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean NeedsRefresh
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 NumberOfRows
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 LastRowNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 FirstRowNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 LastColumnNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 FirstColumnNumber
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NumberOfColumns
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HideSection
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

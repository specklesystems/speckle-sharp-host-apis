namespace Autodesk.Revit.DB;

public partial class TableData : System.IDisposable
{
	public TableData() {}
	public virtual System.Boolean IsEqual(Autodesk.Revit.DB.TableData OtherElem) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TableSectionData GetSectionData(System.Int32 nIndex) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TableSectionData GetSectionData(Autodesk.Revit.DB.SectionType sectionType) => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidZoomLevel(System.Int32 zoomLevel) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 ZoomLevel
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Width
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 WidthInPixels
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NumberOfSections
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean FreezeColumnsAndRows
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

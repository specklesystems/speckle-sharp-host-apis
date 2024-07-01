namespace Autodesk.Revit.DB.Electrical;

public partial class PanelScheduleTemplate : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.Electrical.PanelScheduleTemplate Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.Electrical.PanelScheduleType type,Autodesk.Revit.DB.Electrical.PanelConfiguration config,System.String strName) => throw new System.NotImplementedException();
	public virtual void CopyFrom(Autodesk.Revit.DB.Document OtherADoc,Autodesk.Revit.DB.Electrical.PanelScheduleTemplate otherElem) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Electrical.PanelScheduleType GetPanelScheduleType() => throw new System.NotImplementedException();
	public virtual void SetTableData(Autodesk.Revit.DB.Electrical.PanelScheduleData Data) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Electrical.PanelScheduleData GetTableData() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.TableSectionData GetSectionData(Autodesk.Revit.DB.SectionType sectionType) => throw new System.NotImplementedException();
	public virtual System.Boolean HasSameType(Autodesk.Revit.DB.Electrical.PanelScheduleTemplate otherTemplate) => throw new System.NotImplementedException();
	public static System.Boolean IsValidPanelConfiguration(Autodesk.Revit.DB.Electrical.PanelScheduleType scheduleType,Autodesk.Revit.DB.Electrical.PanelConfiguration configuration) => throw new System.NotImplementedException();
	public virtual System.Boolean IsDefault
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsSwitchboardSchedule
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsDataPanelSchedule
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsBranchPanelSchedule
	{
		get => throw new System.NotImplementedException();
	}
}

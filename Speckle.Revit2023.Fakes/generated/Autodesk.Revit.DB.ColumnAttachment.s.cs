namespace Autodesk.Revit.DB;

public partial class ColumnAttachment : System.Object
{
	public static System.Boolean IsValidColumn(Autodesk.Revit.DB.FamilyInstance familyInstance) => throw new System.NotImplementedException();
	public static System.Boolean IsValidTarget(System.Boolean forSlantedColumn,Autodesk.Revit.DB.Element target) => throw new System.NotImplementedException();
	public static System.Boolean IsValidTarget(Autodesk.Revit.DB.FamilyInstance column,Autodesk.Revit.DB.Element target) => throw new System.NotImplementedException();
	public static void AddColumnAttachment(Autodesk.Revit.DB.Document doc,Autodesk.Revit.DB.FamilyInstance column,Autodesk.Revit.DB.Element target,System.Int32 baseOrTop,Autodesk.Revit.DB.ColumnAttachmentCutStyle cutColumnStyle,Autodesk.Revit.DB.ColumnAttachmentJustification justification,System.Double attachOffset) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ColumnAttachment GetColumnAttachment(Autodesk.Revit.DB.FamilyInstance column,Autodesk.Revit.DB.ElementId targetId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ColumnAttachment GetColumnAttachment(Autodesk.Revit.DB.FamilyInstance column,System.Int32 baseOrTop) => throw new System.NotImplementedException();
	public static void RemoveColumnAttachment(Autodesk.Revit.DB.FamilyInstance column,Autodesk.Revit.DB.ElementId targetId) => throw new System.NotImplementedException();
	public static void RemoveColumnAttachment(Autodesk.Revit.DB.FamilyInstance column,System.Int32 baseOrTop) => throw new System.NotImplementedException();
	public virtual void SetJustification(Autodesk.Revit.DB.ColumnAttachmentJustification justification) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual System.Boolean IsValidObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ColumnAttachmentCutStyle CutStyle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ColumnAttachmentJustification Justification
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 BaseOrTop
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId TargetId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double AttachOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

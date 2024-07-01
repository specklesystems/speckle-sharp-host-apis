namespace Autodesk.Revit.DB;

public partial class TextNote : Autodesk.Revit.DB.TextElement
{
	public static Autodesk.Revit.DB.TextNote Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewId,Autodesk.Revit.DB.XYZ position,System.Double width,System.String text,Autodesk.Revit.DB.TextNoteOptions options) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.TextNote Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewId,Autodesk.Revit.DB.XYZ position,System.Double width,System.String text,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.TextNote Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewId,Autodesk.Revit.DB.XYZ position,System.String text,Autodesk.Revit.DB.TextNoteOptions options) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.TextNote Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewId,Autodesk.Revit.DB.XYZ position,System.String text,Autodesk.Revit.DB.ElementId typeId) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.IList<Autodesk.Revit.DB.Leader> GetLeaders() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Leader AddLeader(Autodesk.Revit.DB.TextNoteLeaderTypes leaderType) => throw new System.NotImplementedException();
	public virtual void RemoveLeaders() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormattedText GetFormattedText() => throw new System.NotImplementedException();
	public virtual void SetFormattedText(Autodesk.Revit.DB.FormattedText formattedText) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LeaderAtachement LeaderRightAttachment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.LeaderAtachement LeaderLeftAttachment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 LeaderCount
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.TextNoteType TextNoteType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

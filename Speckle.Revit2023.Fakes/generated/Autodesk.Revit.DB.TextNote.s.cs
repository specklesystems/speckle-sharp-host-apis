namespace Autodesk.Revit.DB;

public partial class TextNote : Autodesk.Revit.DB.TextElement
{
	public virtual Autodesk.Revit.DB.TextNoteType get_TextNoteType() => throw new System.NotImplementedException();
	public virtual void set_TextNoteType(Autodesk.Revit.DB.TextNoteType A_0) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LeaderAtachement get_LeaderLeftAttachment() => throw new System.NotImplementedException();
	public virtual void set_LeaderLeftAttachment(Autodesk.Revit.DB.LeaderAtachement attachment) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.LeaderAtachement get_LeaderRightAttachment() => throw new System.NotImplementedException();
	public virtual void set_LeaderRightAttachment(Autodesk.Revit.DB.LeaderAtachement attachment) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.Leader AddLeader(Autodesk.Revit.DB.TextNoteLeaderTypes leaderType) => throw new System.NotImplementedException();
	public virtual void RemoveLeaders() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.FormattedText GetFormattedText() => throw new System.NotImplementedException();
	public virtual void SetFormattedText(Autodesk.Revit.DB.FormattedText formattedText) => throw new System.NotImplementedException();
}

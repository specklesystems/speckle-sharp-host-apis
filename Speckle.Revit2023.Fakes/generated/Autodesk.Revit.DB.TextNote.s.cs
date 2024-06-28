namespace Autodesk.Revit.DB;

public partial class TextNote : Autodesk.Revit.DB.TextElement
{
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
	public virtual Autodesk.Revit.DB.TextNoteType TextNoteType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

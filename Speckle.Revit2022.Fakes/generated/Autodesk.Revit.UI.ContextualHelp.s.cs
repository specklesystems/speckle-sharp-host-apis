namespace Autodesk.Revit.UI;

public partial class ContextualHelp
{
	public ContextualHelp() {}
	public ContextualHelp(Autodesk.Revit.UI.ContextualHelpType helpType,System.String helpPath) => throw new System.NotImplementedException();
	public virtual void Launch() => throw new System.NotImplementedException();
	public virtual System.String HelpTopicUrl
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String HelpPath
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.UI.ContextualHelpType HelpType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

namespace Autodesk.Revit.UI;

public partial class ContextualHelp : System.Object
{
	public virtual void Launch() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.ContextualHelpType HelpType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

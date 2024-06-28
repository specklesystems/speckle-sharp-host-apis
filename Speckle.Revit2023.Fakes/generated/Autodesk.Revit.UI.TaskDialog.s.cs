namespace Autodesk.Revit.UI;

public partial class TaskDialog : Autodesk.Revit.DB.APIObject
{
	public virtual void AddCommandLink(Autodesk.Revit.UI.TaskDialogCommandLinkId id,System.String mainContent) => throw new System.NotImplementedException();
	public virtual void AddCommandLink(Autodesk.Revit.UI.TaskDialogCommandLinkId id,System.String mainContent,System.String supportingContent) => throw new System.NotImplementedException();
	public static Autodesk.Revit.UI.TaskDialogResult Show(System.String title,System.String mainInstruction,Autodesk.Revit.UI.TaskDialogCommonButtons buttons,Autodesk.Revit.UI.TaskDialogResult defaultButton) => throw new System.NotImplementedException();
	public static Autodesk.Revit.UI.TaskDialogResult Show(System.String title,System.String mainInstruction,Autodesk.Revit.UI.TaskDialogCommonButtons buttons) => throw new System.NotImplementedException();
	public static Autodesk.Revit.UI.TaskDialogResult Show(System.String title,System.String mainInstruction) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.UI.TaskDialogResult Show() => throw new System.NotImplementedException();
	public virtual System.Boolean WasVerificationChecked() => throw new System.NotImplementedException();
	public virtual System.Boolean WasExtraCheckBoxChecked() => throw new System.NotImplementedException();
	public virtual void EnableDoNotShowAgain(System.String dialogId,System.Boolean enableDoNotShow,System.String doNotShowText) => throw new System.NotImplementedException();
	public virtual System.Boolean EnableMarqueeProgressBar
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean TitleAutoPrefix
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.UI.TaskDialogCommonButtons CommonButtons
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.UI.TaskDialogIcon MainIcon
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.UI.TaskDialogResult DefaultButton
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean AllowCancellation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String FooterText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String ExtraCheckBoxText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String VerificationText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String ExpandedContent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String MainContent
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Id
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String MainInstruction
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Title
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

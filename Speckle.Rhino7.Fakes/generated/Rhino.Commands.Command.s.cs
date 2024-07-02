namespace Rhino.Commands;

public partial class Command
{
	public Command() {}
	public static System.Boolean IsValidCommandName(System.String name) => throw new System.NotImplementedException();
	public static Rhino.Commands.MostRecentCommandDescription[] GetMostRecentCommands() => throw new System.NotImplementedException();
	public static System.Guid[] GetCommandStack() => throw new System.NotImplementedException();
	public static System.Boolean InCommand() => throw new System.NotImplementedException();
	public static System.Boolean InScriptRunnerCommand() => throw new System.NotImplementedException();
	public static System.Boolean IsCommand(System.String name) => throw new System.NotImplementedException();
	public static System.Guid LookupCommandId(System.String name,System.Boolean searchForEnglishName) => throw new System.NotImplementedException();
	public static System.String LookupCommandName(System.Guid commandId,System.Boolean englishName) => throw new System.NotImplementedException();
	public static System.String[] GetCommandNames(System.Boolean english,System.Boolean loaded) => throw new System.NotImplementedException();
	public static void DisplayHelp(System.Guid commandId) => throw new System.NotImplementedException();
	public static  System.Guid LastCommandId
	{
		get => throw new System.NotImplementedException();
	}
	public static  Rhino.Commands.Result LastCommandResult
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String EnglishName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String LocalName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.PersistentSettings Settings
	{
		get => throw new System.NotImplementedException();
	}
}

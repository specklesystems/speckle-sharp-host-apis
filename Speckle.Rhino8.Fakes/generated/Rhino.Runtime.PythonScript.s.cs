namespace Rhino.Runtime;

public partial class PythonScript
{
  public PythonScript() { }

  public static Rhino.Runtime.PythonScript Create() => throw new System.NotImplementedException();

  public static System.Reflection.Assembly[] RuntimeAssemblies() => throw new System.NotImplementedException();

  public static void AddRuntimeAssembly(System.Reflection.Assembly assembly) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Runtime.PythonCompiledCode Compile(System.String script) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ContainsVariable(System.String name) => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.IEnumerable<System.String> GetVariableNames() =>
    throw new System.NotImplementedException();

  public virtual System.Object GetVariable(System.String name) => throw new System.NotImplementedException();

  public virtual void SetVariable(System.String name, System.Object value) =>
    throw new System.NotImplementedException();

  public virtual void SetIntellisenseVariable(System.String name, System.Object value) =>
    throw new System.NotImplementedException();

  public virtual void RemoveVariable(System.String name) => throw new System.NotImplementedException();

  public virtual System.Object EvaluateExpression(System.String statements, System.String expression) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ExecuteFile(System.String path) => throw new System.NotImplementedException();

  public virtual System.Boolean ExecuteFileInScope(System.String path) => throw new System.NotImplementedException();

  public virtual System.Boolean ExecuteScript(System.String script) => throw new System.NotImplementedException();

  public virtual System.String GetStackTraceFromException(System.Exception ex) =>
    throw new System.NotImplementedException();

  public virtual System.Object CreateTextEditorControl(
    System.String script,
    System.Action<System.String> helpcallback
  ) => throw new System.NotImplementedException();

  public virtual void SetupScriptContext(System.Object doc) => throw new System.NotImplementedException();

  public static System.String[] SearchPaths
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Action<System.String> Output
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Object ScriptContextDoc
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Commands.Command ScriptContextCommand
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ContextId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

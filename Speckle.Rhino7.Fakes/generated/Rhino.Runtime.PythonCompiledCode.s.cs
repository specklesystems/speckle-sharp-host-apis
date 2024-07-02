namespace Rhino.Runtime;

public partial class PythonCompiledCode
{
  public PythonCompiledCode() { }

  public virtual void Execute(Rhino.Runtime.PythonScript scope) => throw new System.NotImplementedException();
}

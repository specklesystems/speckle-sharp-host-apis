namespace Rhino;

	public partial class RhinoApp
	{
	public partial class CommandLineTextWriter : System.IO.TextWriter
{
	public CommandLineTextWriter() {}
	public virtual void write(System.String str) => throw new System.NotImplementedException();
	public override System.Text.Encoding Encoding
	{
		get => throw new System.NotImplementedException();
	}
}
}

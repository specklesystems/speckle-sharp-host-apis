namespace Rhino.Commands;

public partial class CommandStyleAttribute : System.Attribute
{
  public CommandStyleAttribute() { }

  public CommandStyleAttribute(Rhino.Commands.Style styles) => throw new System.NotImplementedException();

  public virtual Rhino.Commands.Style Styles
  {
    get => throw new System.NotImplementedException();
  }
}

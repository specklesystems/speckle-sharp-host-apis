namespace Rhino.Commands;

public partial class SelCommand : Rhino.Commands.Command
{
  public SelCommand() { }

  public virtual System.Boolean TestLights
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean TestGrips
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean BeQuiet
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

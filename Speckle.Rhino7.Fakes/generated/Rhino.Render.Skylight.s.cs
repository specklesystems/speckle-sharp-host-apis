namespace Rhino.Render;

public partial class Skylight : Rhino.Render.DocumentOrFreeFloatingBase
{
  public Skylight() { }

  public Skylight(Rhino.Render.Skylight src) => throw new System.NotImplementedException();

  public virtual System.Boolean Enabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ShadowIntensity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CustomEnvironmentOn
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid CustomEnvironment
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

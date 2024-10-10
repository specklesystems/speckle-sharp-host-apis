namespace Rhino.Render;

public partial class DocumentOrFreeFloatingBase : Rhino.Render.FreeFloatingBase
{
  public DocumentOrFreeFloatingBase() { }

  public virtual void BeginChange(Rhino.Render.RenderContent.ChangeContexts cc) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean EndChange() => throw new System.NotImplementedException();
}

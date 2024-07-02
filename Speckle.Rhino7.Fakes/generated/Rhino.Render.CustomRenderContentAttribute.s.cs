namespace Rhino.Render;

public partial class CustomRenderContentAttribute : System.Attribute
{
  public CustomRenderContentAttribute() { }

  public CustomRenderContentAttribute(
    System.String renderEngineGuid,
    System.Boolean imageBased,
    System.String category,
    System.Boolean is_elevated,
    System.Boolean is_built_in,
    System.Boolean is_private
  ) => throw new System.NotImplementedException();

  public CustomRenderContentAttribute(
    System.String renderEngineGuid,
    System.Boolean imageBased,
    System.String category,
    System.Boolean is_elevated,
    System.Boolean is_built_in,
    System.Boolean is_private,
    System.Boolean is_linear,
    System.Boolean is_hdrcapable,
    System.Boolean is_normalmap
  ) => throw new System.NotImplementedException();

  public virtual System.Guid RenderEngineId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ImageBased
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsLinear
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsHdrCapable
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsNormalMap
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Category
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsElevated
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsBuiltIn
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPrivate
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

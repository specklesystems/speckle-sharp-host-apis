namespace Rhino.Render;

public partial class MappingTag
{
  public MappingTag() { }

  public virtual System.Guid Id
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.TextureMappingType MappingType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.UInt32 MappingCRC
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Transform MeshTransform
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

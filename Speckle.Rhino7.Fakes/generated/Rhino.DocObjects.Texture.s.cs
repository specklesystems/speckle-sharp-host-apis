namespace Rhino.DocObjects;

public partial class Texture : Rhino.Runtime.CommonObject
{
  public Texture() { }

  public virtual void GetAlphaBlendValues(
    out System.Double constant,
    out System.Double a0,
    out System.Double a1,
    out System.Double a2,
    out System.Double a3
  ) => throw new System.NotImplementedException();

  public virtual void SetAlphaBlendValues(
    System.Double constant,
    System.Double a0,
    System.Double a1,
    System.Double a2,
    System.Double a3
  ) => throw new System.NotImplementedException();

  public virtual void SetRGBBlendValues(
    System.Drawing.Color color,
    System.Double a0,
    System.Double a1,
    System.Double a2,
    System.Double a3
  ) => throw new System.NotImplementedException();

  public virtual System.String FileName
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.FileIO.FileReference FileReference
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid Id
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean Enabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextureType TextureType
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MappingChannelId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.TextureCombineMode TextureCombineMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextureUvwWrapping WrapU
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextureUvwWrapping WrapV
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.DocObjects.TextureUvwWrapping WrapW
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ApplyUvwTransform
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Transform UvwTransform
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

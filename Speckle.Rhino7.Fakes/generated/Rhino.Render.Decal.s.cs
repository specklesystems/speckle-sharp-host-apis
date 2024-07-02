namespace Rhino.Render;

public partial class Decal : System.IDisposable
{
  public Decal() { }

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual void Dispose(System.Boolean isDisposing) => throw new System.NotImplementedException();

  public static Rhino.Render.Decal Create(Rhino.Render.DecalCreateParams createParams) =>
    throw new System.NotImplementedException();

  public virtual System.UInt32 TextureRenderCRC(Rhino.Render.TextureRenderHashFlags rh) =>
    throw new System.NotImplementedException();

  public virtual System.UInt32 TextureRenderCRC(
    Rhino.Render.TextureRenderHashFlags rh,
    Rhino.Render.LinearWorkflow lw
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Render.TextureMapping GetTextureMapping() => throw new System.NotImplementedException();

  public virtual System.Collections.Generic.List<Rhino.Render.NamedValue> CustomData() =>
    throw new System.NotImplementedException();

  public virtual System.IntPtr ConstPointer() => throw new System.NotImplementedException();

  public virtual System.IntPtr NonConstPointer() => throw new System.NotImplementedException();

  public virtual System.Int32 CRC
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid TextureInstanceId
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.DecalMapping DecalMapping
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Render.DecalProjection DecalProjection
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean MapToInside
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Transparency
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d Origin
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d VectorUp
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d VectorAcross
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Height
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Radius
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double StartLatitude
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double EndLatitude
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double StartLongitude
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double EndLongitude
  {
    get => throw new System.NotImplementedException();
  }
}

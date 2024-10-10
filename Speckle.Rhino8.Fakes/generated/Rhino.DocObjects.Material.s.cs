namespace Rhino.DocObjects;

public partial class Material : Rhino.DocObjects.ModelComponent
{
  public Material() { }

  public Material(Rhino.DocObjects.Material other) => throw new System.NotImplementedException();

  public virtual void CopyFrom(Rhino.DocObjects.Material other) => throw new System.NotImplementedException();

  public virtual void ToPhysicallyBased() => throw new System.NotImplementedException();

  public virtual void Default() => throw new System.NotImplementedException();

  public virtual System.Boolean SetTexture(Rhino.DocObjects.Texture texture, Rhino.DocObjects.TextureType which) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Texture GetTexture(Rhino.DocObjects.TextureType which) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Texture[] GetTextures() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Texture GetBitmapTexture() => throw new System.NotImplementedException();

  public virtual System.Boolean SetBitmapTexture(System.String filename) => throw new System.NotImplementedException();

  public virtual System.Boolean SetBitmapTexture(Rhino.DocObjects.Texture texture) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Texture GetBumpTexture() => throw new System.NotImplementedException();

  public virtual System.Boolean SetBumpTexture(System.String filename) => throw new System.NotImplementedException();

  public virtual System.Boolean SetBumpTexture(Rhino.DocObjects.Texture texture) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Texture GetEnvironmentTexture() => throw new System.NotImplementedException();

  public virtual System.Boolean SetEnvironmentTexture(System.String filename) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetEnvironmentTexture(Rhino.DocObjects.Texture texture) =>
    throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.Texture GetTransparencyTexture() => throw new System.NotImplementedException();

  public virtual System.Boolean SetTransparencyTexture(System.String filename) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetTransparencyTexture(Rhino.DocObjects.Texture texture) =>
    throw new System.NotImplementedException();

  public virtual System.Guid MaterialChannelIdFromIndex(System.Int32 material_channel_index) =>
    throw new System.NotImplementedException();

  public virtual System.Int32 MaterialChannelIndexFromId(
    System.Guid material_channel_id,
    System.Boolean bAddIdIfNotPresent
  ) => throw new System.NotImplementedException();

  public virtual void ClearMaterialChannels() => throw new System.NotImplementedException();

  public virtual System.Boolean CommitChanges() => throw new System.NotImplementedException();

  public virtual System.Boolean SetUserString(System.String key, System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.String GetUserString(System.String key) => throw new System.NotImplementedException();

  public virtual System.Collections.Specialized.NameValueCollection GetUserStrings() =>
    throw new System.NotImplementedException();

  public static Rhino.DocObjects.Material DefaultMaterial
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid RenderMaterialInstanceId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Render.RenderMaterial RenderMaterial
  {
    get => throw new System.NotImplementedException();
  }
  public new Rhino.DocObjects.ModelComponentType ComponentType
  {
    get => throw new System.NotImplementedException();
  }
  public new System.Boolean IsDeleted
  {
    get => throw new System.NotImplementedException();
  }
  public new System.Boolean IsReference
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid RenderPlugInId
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsDefaultMaterial
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 MaterialIndex
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 UseCount
  {
    get => throw new System.NotImplementedException();
  }
  public new System.Boolean IsDocumentControlled
  {
    get => throw new System.NotImplementedException();
  }
  public new System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public static System.Double MaxShine
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Shine
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double Transparency
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double IndexOfRefraction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FresnelIndexOfRefraction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double RefractionGlossiness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ReflectionGlossiness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean FresnelReflections
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DisableLighting
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean AlphaTransparency
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPhysicallyBased
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.DocObjects.PhysicallyBasedMaterial PhysicallyBased
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Reflectivity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color PreviewColor
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid RDKMaterialID
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Drawing.Color DiffuseColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color AmbientColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color EmissionColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SpecularColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color ReflectionColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color TransparentColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 UserStringCount
  {
    get => throw new System.NotImplementedException();
  }
}

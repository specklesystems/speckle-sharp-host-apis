namespace Rhino.DocObjects;

public partial class PhysicallyBasedMaterial
{
	public PhysicallyBasedMaterial() {}
	public virtual System.Boolean SetTexture(Rhino.DocObjects.Texture texture,Rhino.DocObjects.TextureType which) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Texture GetTexture(Rhino.DocObjects.TextureType which) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Texture[] GetTextures() => throw new System.NotImplementedException();
	public virtual void SynchronizeLegacyMaterial() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Material Material
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.PhysicallyBasedMaterial.BRDFs BRDF
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Subsurface
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SubsurfaceScatteringRadius
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Metallic
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Specular
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ReflectiveIOR
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SpecularTint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Roughness
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Anisotropic
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double AnisotropicRotation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Sheen
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double SheenTint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Clearcoat
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ClearcoatRoughness
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double OpacityIOR
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Opacity
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double OpacityRoughness
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Alpha
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean UseBaseColorTextureAlphaForObjectAlphaTransparencyTexture
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

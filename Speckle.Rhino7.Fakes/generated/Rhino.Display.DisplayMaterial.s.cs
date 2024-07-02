namespace Rhino.Display;

public partial class DisplayMaterial : System.IDisposable
{
	public DisplayMaterial() {}
	public DisplayMaterial(Rhino.Display.DisplayMaterial other) => throw new System.NotImplementedException();
	public DisplayMaterial(Rhino.DocObjects.Material material) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Texture GetBitmapTexture(System.Boolean front) => throw new System.NotImplementedException();
	public virtual System.Boolean SetBitmapTexture(System.String filename,System.Boolean front) => throw new System.NotImplementedException();
	public virtual System.Boolean SetBitmapTexture(Rhino.DocObjects.Texture texture,System.Boolean front) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Texture GetBumpTexture(System.Boolean front) => throw new System.NotImplementedException();
	public virtual System.Boolean SetBumpTexture(System.String filename,System.Boolean front) => throw new System.NotImplementedException();
	public virtual System.Boolean SetBumpTexture(Rhino.DocObjects.Texture texture,System.Boolean front) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Texture GetEnvironmentTexture(System.Boolean front) => throw new System.NotImplementedException();
	public virtual System.Boolean SetEnvironmentTexture(System.String filename,System.Boolean front) => throw new System.NotImplementedException();
	public virtual System.Boolean SetEnvironmentTexture(Rhino.DocObjects.Texture texture,System.Boolean front) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Texture GetTransparencyTexture(System.Boolean front) => throw new System.NotImplementedException();
	public virtual System.Boolean SetTransparencyTexture(System.String filename,System.Boolean front) => throw new System.NotImplementedException();
	public virtual System.Boolean SetTransparencyTexture(Rhino.DocObjects.Texture texture,System.Boolean front) => throw new System.NotImplementedException();
	public virtual System.Double Shine
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double BackShine
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Transparency
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double BackTransparency
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsTwoSided
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

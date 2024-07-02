namespace Rhino.Render;

public partial class RenderMaterial : Rhino.Render.RenderContent
{
	public RenderMaterial() {}
	public static Rhino.Render.RenderMaterial CreateBasicMaterial(Rhino.DocObjects.Material material) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderMaterial CreateBasicMaterial(Rhino.DocObjects.Material material,Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderMaterial FromMaterial(Rhino.DocObjects.Material material,Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderMaterial CreateImportedMaterial(Rhino.DocObjects.Material material,Rhino.RhinoDoc doc,System.Boolean reference) => throw new System.NotImplementedException();
	public static Rhino.DocObjects.TextureType TextureTypeFromSlot(Rhino.Render.RenderMaterial.StandardChildSlots slot) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderMaterial.StandardChildSlots SlotFromTextureType(Rhino.DocObjects.TextureType tt) => throw new System.NotImplementedException();
	public virtual System.String TextureChildSlotName(Rhino.Render.RenderMaterial.StandardChildSlots slot) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderTexture GetTextureFromUsage(Rhino.Render.RenderMaterial.StandardChildSlots slot) => throw new System.NotImplementedException();
	public virtual System.Boolean GetTextureOnFromUsage(Rhino.Render.RenderMaterial.StandardChildSlots slot) => throw new System.NotImplementedException();
	public virtual System.Double GetTextureAmountFromUsage(Rhino.Render.RenderMaterial.StandardChildSlots slot) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Material SimulateMaterial(System.Boolean isForDataOnly) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.Material SimulatedMaterial(Rhino.Render.RenderTexture.TextureGeneration tg) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.PhysicallyBasedMaterial ConvertToPhysicallyBased(Rhino.Render.RenderTexture.TextureGeneration tg) => throw new System.NotImplementedException();
	public static  System.Guid PlasterMaterialGuid
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid PlasticMaterialGuid
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid PaintMaterialGuid
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid GlassMaterialGuid
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid GemMaterialGuid
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid MetalMaterialGuid
	{
		get => throw new System.NotImplementedException();
	}
	public static  System.Guid PictureMaterialGuid
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Render.RenderMaterial.PreviewGeometryType DefaultPreviewGeometryType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Render.RenderMaterial.PreviewBackgroundType DefaultPreviewBackgroundType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double DefaultPreviewSize
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean SmellsLikePlaster
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikePaint
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikeMetal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikePlastic
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikeGem
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikeGlass
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikeTexturedPlaster
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikeTexturedPaint
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikeTexturedMetal
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikeTexturedPlastic
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikeTexturedGem
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SmellsLikeTexturedGlass
	{
		get => throw new System.NotImplementedException();
	}
}

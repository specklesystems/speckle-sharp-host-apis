namespace Rhino.Render;

public partial class RenderTexture : Rhino.Render.RenderContent
{
	public RenderTexture() {}
	public static Rhino.Render.RenderTexture NewBitmapTexture(Rhino.Render.SimulatedTexture texture) => throw new System.NotImplementedException();
	public static Rhino.Render.RenderTexture NewBitmapTexture(Rhino.Render.SimulatedTexture texture,Rhino.RhinoDoc doc) => throw new System.NotImplementedException();
	public virtual System.Boolean SaveAsImage(System.String FullPath,System.Int32 width,System.Int32 height,System.Int32 depth) => throw new System.NotImplementedException();
	public virtual Rhino.Render.TextureEvaluator CreateEvaluator(Rhino.Render.RenderTexture.TextureEvaluatorFlags evaluatorFlags) => throw new System.NotImplementedException();
	public virtual Rhino.Render.TextureEvaluator CreateEvaluator() => throw new System.NotImplementedException();
	public virtual Rhino.Render.SimulatedTexture SimulatedTexture(Rhino.Render.RenderTexture.TextureGeneration tg,System.Int32 size,Rhino.DocObjects.RhinoObject obj) => throw new System.NotImplementedException();
	public virtual Rhino.Render.TextureProjectionMode GetProjectionMode() => throw new System.NotImplementedException();
	public virtual void SetProjectionMode(Rhino.Render.TextureProjectionMode value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual Rhino.Render.TextureWrapType GetWrapType() => throw new System.NotImplementedException();
	public virtual void SetWrapType(Rhino.Render.TextureWrapType value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual System.Int32 GetMappingChannel() => throw new System.NotImplementedException();
	public virtual void SetMappingChannel(System.Int32 value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual System.Boolean GetRepeatLocked() => throw new System.NotImplementedException();
	public virtual void SetRepeatLocked(System.Boolean value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual System.Boolean GetOffsetLocked() => throw new System.NotImplementedException();
	public virtual void SetOffsetLocked(System.Boolean value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual System.Boolean GetPreviewIn3D() => throw new System.NotImplementedException();
	public virtual void SetPreviewIn3D(System.Boolean value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d GetRepeat() => throw new System.NotImplementedException();
	public virtual void SetRepeat(Rhino.Geometry.Vector3d value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d GetOffset() => throw new System.NotImplementedException();
	public virtual void SetOffset(Rhino.Geometry.Vector3d value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d GetRotation() => throw new System.NotImplementedException();
	public virtual void SetRotation(Rhino.Geometry.Vector3d value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual Rhino.Render.TextureEnvironmentMappingMode GetInternalEnvironmentMappingMode() => throw new System.NotImplementedException();
	public virtual Rhino.Render.TextureEnvironmentMappingMode GetEnvironmentMappingMode() => throw new System.NotImplementedException();
	public virtual void SetEnvironmentMappingMode(Rhino.Render.TextureEnvironmentMappingMode value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual void SetEnvironmentMappingMode(Rhino.Render.TextureEnvironmentMappingMode value) => throw new System.NotImplementedException();
	public virtual System.Boolean GetPreviewLocalMapping() => throw new System.NotImplementedException();
	public virtual void SetPreviewLocalMapping(System.Boolean value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual Rhino.Render.RenderTexture.eLocalMappingType GetLocalMappingType() => throw new System.NotImplementedException();
	public virtual void SetPreviewLocalMapping(System.Boolean value) => throw new System.NotImplementedException();
	public virtual System.Boolean GetDisplayInViewport() => throw new System.NotImplementedException();
	public virtual void SetDisplayInViewport(System.Boolean value,Rhino.Render.RenderContent.ChangeContexts changeContext) => throw new System.NotImplementedException();
	public virtual void SetDisplayInViewport(System.Boolean value) => throw new System.NotImplementedException();
	public virtual System.Boolean IsHdrCapable() => throw new System.NotImplementedException();
	public virtual System.Boolean IsLinear() => throw new System.NotImplementedException();
	public virtual System.Boolean IsNormalMap() => throw new System.NotImplementedException();
	public virtual void SetGraphInfo(Rhino.Render.TextureGraphInfo tgi) => throw new System.NotImplementedException();
	public virtual System.Boolean IsImageBased() => throw new System.NotImplementedException();
	public static Rhino.Geometry.Point3d GetWcsBoxMapping(Rhino.Geometry.Point3d worldXyz,Rhino.Geometry.Vector3d normal) => throw new System.NotImplementedException();
	public virtual System.UInt32 RenderHashWithoutLocalMapping
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Transform LocalMappingTransform
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Nullable<System.ValueTuple<System.Int32, System.Int32, System.Int32>> PixelSize2
	{
		get => throw new System.NotImplementedException();
	}
}

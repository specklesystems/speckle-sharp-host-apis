namespace Rhino.Display;

public partial class DisplayPipeline
{
	public DisplayPipeline() {}
	public virtual void DrawActivePoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual void DrawPoint(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();
	public virtual void DrawPointCloud(Rhino.Geometry.PointCloud cloud,System.Single size) => throw new System.NotImplementedException();
	public virtual void DrawPointCloud(Rhino.Geometry.PointCloud cloud,System.Int32 size) => throw new System.NotImplementedException();
	public virtual void DrawBitmap(Rhino.Display.DisplayBitmap bitmap,System.Int32 left,System.Int32 top) => throw new System.NotImplementedException();
	public virtual void DrawDot(System.Single screenX,System.Single screenY,System.String text) => throw new System.NotImplementedException();
	public virtual void DrawDot(Rhino.Geometry.Point3d worldPosition,System.String text) => throw new System.NotImplementedException();
	public virtual void DrawGradientMesh(Rhino.Geometry.Mesh mesh,System.Collections.Generic.IEnumerable<Rhino.Display.ColorStop> stops,Rhino.Geometry.Point3d point1,Rhino.Geometry.Point3d point2,System.Boolean linearGradient,System.Single repeat) => throw new System.NotImplementedException();
	public virtual void DrawGradientLines(System.Collections.Generic.IEnumerable<Rhino.Geometry.Line> lines,System.Single strokeWidth,System.Collections.Generic.IEnumerable<Rhino.Display.ColorStop> stops,Rhino.Geometry.Point3d point1,Rhino.Geometry.Point3d point2,System.Boolean linearGradient,System.Single repeat) => throw new System.NotImplementedException();
	public virtual void DrawConstructionPlane(Rhino.DocObjects.ConstructionPlane constructionPlane) => throw new System.NotImplementedException();
	public virtual void DrawObject(Rhino.DocObjects.RhinoObject rhinoObject) => throw new System.NotImplementedException();
	public virtual void DrawObject(Rhino.DocObjects.RhinoObject rhinoObject,Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual void DrawSprite(Rhino.Display.DisplayBitmap bitmap,Rhino.Geometry.Point3d worldLocation,System.Single size,System.Boolean sizeInWorldSpace) => throw new System.NotImplementedException();
	public virtual void DrawSprite(Rhino.Display.DisplayBitmap bitmap,Rhino.Geometry.Point2d screenLocation,System.Single size) => throw new System.NotImplementedException();
	public virtual void DrawSprite(Rhino.Display.DisplayBitmap bitmap,Rhino.Geometry.Point2d screenLocation,System.Single width,System.Single height) => throw new System.NotImplementedException();
	public virtual void DrawSprites(Rhino.Display.DisplayBitmap bitmap,Rhino.Display.DisplayBitmapDrawList items,System.Single size,System.Boolean sizeInWorldSpace) => throw new System.NotImplementedException();
	public virtual void DrawSprites(Rhino.Display.DisplayBitmap bitmap,Rhino.Display.DisplayBitmapDrawList items,System.Single size,Rhino.Geometry.Vector3d translation,System.Boolean sizeInWorldSpace) => throw new System.NotImplementedException();
	public virtual void DrawParticles(Rhino.Geometry.ParticleSystem particles) => throw new System.NotImplementedException();
	public virtual void DrawParticles(Rhino.Geometry.ParticleSystem particles,Rhino.Display.DisplayBitmap bitmap) => throw new System.NotImplementedException();
	public virtual void DrawParticles(Rhino.Geometry.ParticleSystem particles,Rhino.Display.DisplayBitmap[] bitmaps) => throw new System.NotImplementedException();
	public static System.Boolean MakeDefaultOpenGLContextCurrent() => throw new System.NotImplementedException();
	public virtual System.Boolean Open() => throw new System.NotImplementedException();
	public virtual System.Boolean Close() => throw new System.NotImplementedException();
	public virtual Rhino.Display.DisplayPipeline Clone(Rhino.Display.RhinoViewport viewport) => throw new System.NotImplementedException();
	public virtual void PushModelTransform(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual void PopModelTransform() => throw new System.NotImplementedException();
	public virtual void EnableDepthTesting(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual void EnableDepthWriting(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual void EnableColorWriting(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual void EnableLighting(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Light[] GetLights() => throw new System.NotImplementedException();
	public virtual void EnableClippingPlanes(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual System.Int32 AddClippingPlane(Rhino.Geometry.Point3d point,Rhino.Geometry.Vector3d normal) => throw new System.NotImplementedException();
	public virtual void RemoveClippingPlane(System.Int32 index) => throw new System.NotImplementedException();
	public virtual void PushDepthTesting(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual void PopDepthTesting() => throw new System.NotImplementedException();
	public virtual void PushDepthWriting(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual void PopDepthWriting() => throw new System.NotImplementedException();
	public virtual void PushClipTesting(System.Boolean enable) => throw new System.NotImplementedException();
	public virtual void PopClipTesting() => throw new System.NotImplementedException();
	public virtual void PushCullFaceMode(Rhino.Display.CullFaceMode mode) => throw new System.NotImplementedException();
	public virtual void PopCullFaceMode() => throw new System.NotImplementedException();
	public static System.Boolean CullControlPolygon() => throw new System.NotImplementedException();
	public virtual void Flush() => throw new System.NotImplementedException();
	public virtual System.Boolean IsVisible(Rhino.Geometry.Point3d worldCoordinate) => throw new System.NotImplementedException();
	public virtual System.Boolean IsVisible(Rhino.DocObjects.RhinoObject rhinoObject) => throw new System.NotImplementedException();
	public virtual System.Boolean IsVisible(Rhino.Geometry.BoundingBox bbox) => throw new System.NotImplementedException();
	public virtual System.Boolean IsActive(Rhino.DocObjects.RhinoObject rhinoObject) => throw new System.NotImplementedException();
	public virtual System.Boolean InterruptDrawing() => throw new System.NotImplementedException();
	public virtual System.Single[] GetOpenGLWorldToCamera(System.Boolean includeModelTransform) => throw new System.NotImplementedException();
	public virtual System.Single[] GetOpenGLWorldToClip(System.Boolean includeModelTransform) => throw new System.NotImplementedException();
	public virtual System.Single[] GetOpenGLCameraToClip() => throw new System.NotImplementedException();
	public virtual void DrawMeshShaded(Rhino.Geometry.Mesh mesh,Rhino.Display.DisplayMaterial material) => throw new System.NotImplementedException();
	public virtual void DrawMeshShaded(Rhino.Geometry.Mesh mesh,Rhino.Display.DisplayMaterial material,System.Int32[] faceIndices) => throw new System.NotImplementedException();
	public virtual void DrawMeshFalseColors(Rhino.Geometry.Mesh mesh) => throw new System.NotImplementedException();
	public virtual void DrawSubDShaded(Rhino.Geometry.SubD subd,Rhino.Display.DisplayMaterial material) => throw new System.NotImplementedException();
	public virtual void DrawBrepShaded(Rhino.Geometry.Brep brep,Rhino.Display.DisplayMaterial material) => throw new System.NotImplementedException();
	public virtual System.Int32 DefaultCurveThickness
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsOpenGL
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsStereoMode
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsPrinting
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsInViewCapture
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsDynamicDisplay
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean SupportsShading
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 StereoProjection
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Transform ModelTransform
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ModelTransformIsIdentity
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 RenderPass
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 NestLevel
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.RhinoObject ActiveTopLevelObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.RhinoObject ActiveObject
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 ActiveObjectNestingLevel
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.RhinoObject[] ActiveObjectNestingStack
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsOpen
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean DrawingWires
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean DrawingGrips
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean DrawingSurfaces
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ShadingRequired
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Display.RhinoViewport Viewport
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Display.DisplayPipelineAttributes DisplayPipelineAttributes
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Single DpiScale
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Display.DepthMode DepthMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Display.ZBiasMode ZBiasMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

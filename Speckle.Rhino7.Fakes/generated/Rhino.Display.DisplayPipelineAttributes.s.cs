namespace Rhino.Display;

public partial class DisplayPipelineAttributes : System.IDisposable,System.Runtime.Serialization.ISerializable
{
	public DisplayPipelineAttributes() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context) => throw new System.NotImplementedException();
	public virtual void Dispose() => throw new System.NotImplementedException();
	public virtual void SetFill(System.Drawing.Color singleColor) => throw new System.NotImplementedException();
	public virtual void SetFill(System.Drawing.Color gradientTop,System.Drawing.Color gradientBottom) => throw new System.NotImplementedException();
	public virtual void SetFill(System.Drawing.Color gradientTopLeft,System.Drawing.Color gradientBottomLeft,System.Drawing.Color gradientTopRight,System.Drawing.Color gradientBottomRight) => throw new System.NotImplementedException();
	public virtual void GetFill(out System.Drawing.Color topLeft,out System.Drawing.Color bottomLeft,out System.Drawing.Color topRight,out System.Drawing.Color bottomRight) => throw new System.NotImplementedException();
	public virtual System.Boolean XrayAllObjects
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IgnoreHighlights
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean DisableConduits
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean DisableTransparency
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Drawing.Color ObjectColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowGrips
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Display.DisplayPipelineAttributes.FrameBufferFillMode FillMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Display.DisplayPipelineAttributes.BoundingBoxDisplayMode BoundingBoxMode
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowClippingPlanes
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Display.DisplayPipelineAttributes.ViewDisplayAttributes ViewSpecificAttributes
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean UseAssignedObjectMaterial
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean UseCustomObjectColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean UseCustomObjectMaterial
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean UseCustomObjectColorBackfaces
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean UseCustomObjectMaterialBackfaces
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowCurves
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean UseSingleCurveColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 CurveThickness
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Drawing.Color CurveColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShadingEnabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShadeVertexColors
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowIsoCurves
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowSurfaceEdges
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowTangentEdges
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowTangentSeams
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 SurfaceEdgeThickness
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean LockedObjectsDrawBehindOthers
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Display.DisplayPipelineAttributes.MeshDisplayAttributes MeshSpecificAttributes
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean ShowText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowAnnotations
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowLights
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Drawing.Color AmbientLightingColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Drawing.Color ShadowColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean CastShadows
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowPoints
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Display.PointStyle PointStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Single PointRadius
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowPointClouds
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid Id
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.String EnglishName
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String LocalName
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Display.DisplayPipelineAttributes.ContextsForDraw ContextForDraw
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid RealtimeDisplayId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Int32 RealtimeRenderPasses
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean ShowRealtimeRenderProgressBar
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Display.StereoContext StereoContext
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

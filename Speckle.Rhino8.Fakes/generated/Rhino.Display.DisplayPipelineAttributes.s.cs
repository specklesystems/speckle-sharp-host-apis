namespace Rhino.Display;

public partial class DisplayPipelineAttributes : System.IDisposable, System.Runtime.Serialization.ISerializable
{
  public DisplayPipelineAttributes() { }

  public virtual void GetColorFadeEffect(out System.Drawing.Color fadeColor, out System.Single fadeAmount) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasColorFadeEffect() => throw new System.NotImplementedException();

  public virtual System.Single GetDitherTransparencyEffect() => throw new System.NotImplementedException();

  public virtual System.Boolean HasDitherTransparencyEffect() => throw new System.NotImplementedException();

  public virtual void GetDiagonalHatchEffect(out System.Single hatchStrength, out System.Single hatchWidth) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean HasDiagonalHatchEffect() => throw new System.NotImplementedException();

  public virtual void GetObjectData(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public virtual void SetFill(System.Drawing.Color singleColor) => throw new System.NotImplementedException();

  public virtual void SetFill(System.Drawing.Color gradientTop, System.Drawing.Color gradientBottom) =>
    throw new System.NotImplementedException();

  public virtual void SetFill(
    System.Drawing.Color gradientTopLeft,
    System.Drawing.Color gradientBottomLeft,
    System.Drawing.Color gradientTopRight,
    System.Drawing.Color gradientBottomRight
  ) => throw new System.NotImplementedException();

  public virtual void GetFill(
    out System.Drawing.Color topLeft,
    out System.Drawing.Color bottomLeft,
    out System.Drawing.Color topRight,
    out System.Drawing.Color bottomRight
  ) => throw new System.NotImplementedException();

  public virtual void SetCurveThicknessUsage(Rhino.Display.DisplayPipelineAttributes.CurveThicknessUse usage) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Display.DisplayPipelineAttributes.CurveThicknessUse GetCurveThicknessUsage() =>
    throw new System.NotImplementedException();

  public virtual Rhino.Display.DisplayPipelineAttributes.SurfaceThicknessUse GetSurfaceEdgeThicknessUsage() =>
    throw new System.NotImplementedException();

  public virtual void SetSurfaceEdgeThicknessUsage(Rhino.Display.DisplayPipelineAttributes.SurfaceThicknessUse use) =>
    throw new System.NotImplementedException();

  public virtual void SetSurfaceNakedEdgeThicknessUsage(
    Rhino.Display.DisplayPipelineAttributes.SurfaceNakedEdgeThicknessUse use
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Display.DisplayPipelineAttributes.SurfaceNakedEdgeThicknessUse GetSurfaceNakedEdgeThicknessUsage() =>
    throw new System.NotImplementedException();

  public virtual void SetSurfaceIsoThicknessUsage(
    Rhino.Display.DisplayPipelineAttributes.SurfaceIsoThicknessUse value
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Display.DisplayPipelineAttributes.SurfaceIsoThicknessUse GetSurfaceIsoThicknessUsage() =>
    throw new System.NotImplementedException();

  public virtual void SetSurfaceIsoApplyPattern(System.Boolean u, System.Boolean v, System.Boolean w) =>
    throw new System.NotImplementedException();

  public virtual void GetSurfaceIsoApplyPattern(out System.Boolean u, out System.Boolean v, out System.Boolean w) =>
    throw new System.NotImplementedException();

  public virtual void SetSurfaceIsoColorUsage(Rhino.Display.DisplayPipelineAttributes.SurfaceIsoColorUse use) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Display.DisplayPipelineAttributes.SurfaceIsoColorUse GetSurfaceIsoColorUsage() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean XrayAllObjects
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IgnoreHighlights
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DisableConduits
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean DisableTransparency
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color ObjectColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowGrips
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.FrameBufferFillMode FillMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.BoundingBoxDisplayMode BoundingBoxMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowClippingPlanes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowClipIntersectionSurfaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowClipIntersectionEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.ViewDisplayAttributes ViewSpecificAttributes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean UseAssignedObjectMaterial
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseCustomObjectColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseCustomObjectMaterial
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseCustomObjectColorBackfaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseCustomObjectMaterialBackfaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowCurves
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseSingleCurveColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.CurveThicknessUse CurveThicknessUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 CurveThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single CurveThicknessScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color CurveColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShadingEnabled
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShadeVertexColors
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowIsoCurves
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowSurfaceEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowTangentEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowTangentSeams
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SurfaceEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SurfaceIsoShowForFlatFaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SurfaceIsoThicknessUsed
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SurfaceEdgeApplyPattern
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SurfaceNakedEdgeApplyPattern
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowSurfaceEdge
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowSurfaceNakedEdge
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SurfaceEdgeColorUse SurfaceEdgeColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SurfaceNakedEdgeColorUse SurfaceNakedEdgeColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SurfaceIsoSingleColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SurfaceIsoColorsUsed
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SurfaceEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SurfaceNakedEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SurfaceIsoUVColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SurfaceIsoUColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SurfaceIsoVColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SurfaceEdgeColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SurfaceNakedAdgeColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SurfaceEdgeColorReductionPercent
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SurfaceNakedEdgeColorReductionPercent
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SurfaceNakedEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SurfaceIsoThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SurfaceIsoUThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SurfaceIsoVThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SurfaceEdgeThicknessScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SurfaceNakedEdgeThicknessScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SurfaceIsoThicknessUScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SurfaceIsoThicknessVScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SurfaceIsoThicknessWScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean LockedObjectsDrawBehindOthers
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.MeshDisplayAttributes MeshSpecificAttributes
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ShowText
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowAnnotations
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowLights
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.LightingSchema LightingScheme
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color AmbientLightingColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color ShadowColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ColorReductionPct
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CastShadows
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowPoints
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.PointStyle PointStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single PointRadius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowPointClouds
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.PointStyle PointCloudStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single PointCloudRadius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Guid Id
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.String EnglishName
  {
    get => throw new System.NotImplementedException();
    set { }
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
    set { }
  }
  public virtual System.Boolean ShowRealtimeRenderProgressBar
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.StereoContext StereoContext
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FrontMaterialShine
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BackMaterialShine
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double FrontMaterialTransparency
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double BackMaterialTransparency
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color BackMaterialDiffuseColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CullBackfaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SubDSmoothInteriorColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SubDCreaseInteriorColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SubDNonManifoldColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SubDBoundaryColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDEdgeColorUse SubDSmoothInteriorEdgeColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDEdgeColorUse SubDCreaseInteriorEdgeColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDEdgeColorUse SubDNonManifoldEdgeColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDEdgeColorUse SubDBoundaryEdgeColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDReflectionPlaneColorUse SubDReflectionPlaneColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SubDReflectionPlaneColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MeshEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MeshNakedEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MeshNonmanifoldEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MeshVertexSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MeshEdgeColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MeshNakedEdgeColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 MeshNonmanifoldEdgeColorReduction
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SubDSmoothInteriorThicknessScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SubDCreaseInteriorThicknessScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SubDNonManifoldThicknessScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SubDBoundaryThicknessScale
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SubDSmoothInteriorEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SubDCreaseInteriorEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SubDNonManifoldEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single SubDBoundaryEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDThicknessUse SubDThicknessUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDThicknessUse SubDSmoothInteriorThicknessUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDThicknessUse SubDCreaseInteriorThicknessUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDThicknessUse SubDNonManifoldThicknessUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.SubDThicknessUse SubDBoundaryThicknessUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SubDSmoothInteriorApplyPattern
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SubDCreaseInteriorApplyPattern
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SubDNonManifoldApplyPattern
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SubDBoundaryApplyPattern
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean SubDReflectionPlaneAxisLineOn
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SubDSmoothInteriorEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SubDCreaseInteriorEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SubDNonManifoldEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SubDBoundaryEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SubDReflectionAxisLineColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color SubDReflectionPlaneColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color MeshEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color MeshNakedEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color MeshNonmanifoldEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double CustomGroundPlaneAltitude
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CustomGroundPlaneOn
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CustomGroundPlaneShadowOnly
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean CustomGroundPlaneAutomaticAltitude
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowSubDEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowSubDCreases
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowSubDBoundary
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowSubDNonmanifoldEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowSubDReflectionPlanePreview
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowMeshEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowMeshNakedEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowMeshNonmanifoldEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseLightColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowClippingFills
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShowClippingEdges
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ClippingShadeSelectedPlane
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ClipSelectionHighlight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.ClippingPlaneFillColorUse ClippingPlaneFillColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color ClippingFillColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.ClippingEdgeColorUse ClippingEdgeColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color ClippingEdgeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.ClippingShadeColorUse ClippingShadeColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color ClippingShadeColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ClippingEdgeThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ClippingShadeTransparency
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean UseSectionStyles
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ControlPolygonWireThickness
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.PointStyle ControlPolygonStyle
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ControlPolygonGripSize
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 LockedObjectTransparency
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.LockedObjectUse LockedObjectUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.DynamicDisplayUse DynamicDisplayUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean HighlightSurfaces
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ControlPolygonUseSolidLines
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ControlPolygonUseFixedSingleColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ControlPolygonShowPoints
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ControlPolygonShowSurface
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ControlPolygonShow
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ControlPolygonHighlight
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean GhostLockedObjects
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean LayersFollowLockUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color ControlPolygonColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color LockedColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShadowsOn
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ShadowIntensity
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ShadowMemoryUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 SkylightShadowQuality
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ShadowSoftEdgeQuality
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ShadowEdgeBlur
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Double ShadowBiasX
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 ShadowTransparencyTolerance
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Single ShadowClippingRadius
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ShadowsIgnoreUserDefinedClippingPlanes
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 AxesSizePercentage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 GridTransparency
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Int32 GridPlaneTransparency
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.GridPlaneVisibilityMode GridPlaneVisibility
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Display.DisplayPipelineAttributes.WorldAxesIconColorUse WorldAxesIconColorUsage
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean PlaneUsesGridColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Drawing.Color GridPlaneColor
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

namespace Rhino.Display;

public enum DrawFrameStages
{
  InitializeFrameBuffer,
  SetupFrustum,
  ObjectCulling,
  CalculateBoundingBox,
  CalculateClippingPlanes,
  SetupLighting,
  DrawBackground,
  PreDrawObjects,
  DrawObject,
  PostDrawObjects,
  DrawForeGround,
  DrawOverlay,
  PostProcessFrameBuffer,
  MeshingParameters,
  ObjectDisplayAttributes,
  PreObjectDraw,
  PostObjectDraw,
  ViewExtents,
  DrawMiddleGround,
  ObjectBasedChannel,
  All,
}

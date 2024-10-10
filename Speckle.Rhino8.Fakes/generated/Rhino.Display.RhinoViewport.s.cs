namespace Rhino.Display;

public partial class RhinoViewport : System.IDisposable
{
  public RhinoViewport() { }

  public RhinoViewport(Rhino.Display.RhinoViewport other) => throw new System.NotImplementedException();

  public virtual System.Boolean SetWallpaper(System.String imageFilename, System.Boolean grayscale) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetWallpaper(
    System.String imageFilename,
    System.Boolean grayscale,
    System.Boolean visible
  ) => throw new System.NotImplementedException();

  public virtual void ClearTraceImage() => throw new System.NotImplementedException();

  public virtual System.Boolean SetTraceImage(
    System.String bitmapFileName,
    Rhino.Geometry.Plane plane,
    System.Double width,
    System.Double height,
    System.Boolean grayscale,
    System.Boolean filtered
  ) => throw new System.NotImplementedException();

  public virtual void Dispose() => throw new System.NotImplementedException();

  public static Rhino.Display.RhinoViewport FromId(System.Guid id) => throw new System.NotImplementedException();

  public virtual System.Boolean IsVisible(Rhino.Geometry.BoundingBox bbox) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean IsVisible(Rhino.Geometry.Point3d point) => throw new System.NotImplementedException();

  public virtual void SetClippingPlanes(Rhino.Geometry.BoundingBox box) => throw new System.NotImplementedException();

  public virtual void SetCameraTarget(Rhino.Geometry.Point3d targetLocation, System.Boolean updateCameraLocation) =>
    throw new System.NotImplementedException();

  public virtual void SetCameraLocations(
    Rhino.Geometry.Point3d targetLocation,
    Rhino.Geometry.Point3d cameraLocation
  ) => throw new System.NotImplementedException();

  public virtual void SetCameraLocation(Rhino.Geometry.Point3d cameraLocation, System.Boolean updateTargetLocation) =>
    throw new System.NotImplementedException();

  public virtual void SetCameraDirection(
    Rhino.Geometry.Vector3d cameraDirection,
    System.Boolean updateTargetLocation
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BoundingBox GetCameraExtents(
    System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Plane ConstructionPlane() => throw new System.NotImplementedException();

  public virtual Rhino.DocObjects.ConstructionPlane GetConstructionPlane() =>
    throw new System.NotImplementedException();

  public virtual void SetConstructionPlane(Rhino.Geometry.Plane plane) => throw new System.NotImplementedException();

  public virtual void SetConstructionPlane(Rhino.DocObjects.ConstructionPlane cplane) =>
    throw new System.NotImplementedException();

  public virtual void PushConstructionPlane(Rhino.DocObjects.ConstructionPlane cplane) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean PopConstructionPlane() => throw new System.NotImplementedException();

  public virtual System.Boolean NextConstructionPlane() => throw new System.NotImplementedException();

  public virtual System.Boolean PreviousConstructionPlane() => throw new System.NotImplementedException();

  public virtual System.Boolean SetToPlanView(
    Rhino.Geometry.Point3d planeOrigin,
    Rhino.Geometry.Vector3d planeXaxis,
    Rhino.Geometry.Vector3d planeYaxis,
    System.Boolean setConstructionPlane
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean SetProjection(
    Rhino.Display.DefinedViewportProjection projection,
    System.String viewName,
    System.Boolean updateConstructionPlane
  ) => throw new System.NotImplementedException();

  public virtual void PushViewProjection() => throw new System.NotImplementedException();

  public virtual System.Boolean SetViewProjection(
    Rhino.DocObjects.ViewportInfo projection,
    System.Boolean updateTargetLocation
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean PopViewProjection() => throw new System.NotImplementedException();

  public virtual System.Boolean PushViewInfo(Rhino.DocObjects.ViewInfo viewinfo, System.Boolean includeTraceImage) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean NextViewProjection() => throw new System.NotImplementedException();

  public virtual System.Boolean PreviousViewProjection() => throw new System.NotImplementedException();

  public virtual System.Boolean ZoomExtents() => throw new System.NotImplementedException();

  public virtual System.Boolean ZoomExtentsSelected() => throw new System.NotImplementedException();

  public virtual System.Boolean ZoomBoundingBox(Rhino.Geometry.BoundingBox box) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ZoomWindow(System.Drawing.Rectangle rect) => throw new System.NotImplementedException();

  public virtual System.Boolean MouseRotateAroundTarget(
    System.Drawing.Point mousePreviousPoint,
    System.Drawing.Point mouseCurrentPoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean MouseRotateCamera(
    System.Drawing.Point mousePreviousPoint,
    System.Drawing.Point mouseCurrentPoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean MouseInOutDolly(
    System.Drawing.Point mousePreviousPoint,
    System.Drawing.Point mouseCurrentPoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean MouseMagnify(
    System.Drawing.Point mousePreviousPoint,
    System.Drawing.Point mouseCurrentPoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean MouseTilt(
    System.Drawing.Point mousePreviousPoint,
    System.Drawing.Point mouseCurrentPoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean MouseAdjustLensLength(
    System.Drawing.Point mousePreviousPoint,
    System.Drawing.Point mouseCurrentPoint,
    System.Boolean moveTarget
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean MouseDollyZoom(
    System.Drawing.Point mousePreviousPoint,
    System.Drawing.Point mouseCurrentPoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean MouseLateralDolly(
    System.Drawing.Point mousePreviousPoint,
    System.Drawing.Point mouseCurrentPoint
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean KeyboardRotate(System.Boolean leftRight, System.Double angleRadians) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean KeyboardDolly(System.Boolean leftRight, System.Double amount) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean KeyboardDollyInOut(System.Double amount) => throw new System.NotImplementedException();

  public virtual System.Boolean Magnify(System.Double magnificationFactor, System.Boolean mode) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean Magnify(
    System.Double magnificationFactor,
    System.Boolean mode,
    System.Drawing.Point fixedScreenPoint
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Transform GetPickTransform(System.Int32 clientX, System.Int32 clientY) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Transform GetPickTransform(System.Drawing.Point clientPoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Transform GetPickTransform(System.Drawing.Rectangle clientRectangle) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean SetUserString(System.String key, System.String value) =>
    throw new System.NotImplementedException();

  public virtual System.String GetUserString(System.String key) => throw new System.NotImplementedException();

  public virtual System.Collections.Specialized.NameValueCollection GetUserStrings() =>
    throw new System.NotImplementedException();

  public virtual System.Boolean DeleteUserString(System.String key) => throw new System.NotImplementedException();

  public virtual void DeleteAllUserStrings() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.BoundingBox GetFrustumBoundingBox() => throw new System.NotImplementedException();

  public virtual System.Boolean Rotate(
    System.Double angleRadians,
    Rhino.Geometry.Vector3d rotationAxis,
    Rhino.Geometry.Point3d rotationCenter
  ) => throw new System.NotImplementedException();

  public virtual System.Double[] GetViewScale() => throw new System.NotImplementedException();

  public virtual System.Boolean ChangeToParallelProjection(System.Boolean symmetricFrustum) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ChangeToPerspectiveProjection(
    System.Boolean symmetricFrustum,
    System.Double lensLength
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean ChangeToPerspectiveProjection(
    System.Double targetDistance,
    System.Boolean symmetricFrustum,
    System.Double lensLength
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean ChangeToTwoPointPerspectiveProjection(System.Double lensLength) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean ChangeToTwoPointPerspectiveProjection(
    System.Double targetDistance,
    Rhino.Geometry.Vector3d up,
    System.Double lensLength
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetCameraFrame(out Rhino.Geometry.Plane frame) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetFrustum(
    out System.Double left,
    out System.Double right,
    out System.Double bottom,
    out System.Double top,
    out System.Double nearDistance,
    out System.Double farDistance
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetFrustumCenter(out Rhino.Geometry.Point3d center) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetDepth(Rhino.Geometry.Point3d point, out System.Double distance) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetDepth(
    Rhino.Geometry.BoundingBox bbox,
    out System.Double nearDistance,
    out System.Double farDistance
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetDepth(
    Rhino.Geometry.Sphere sphere,
    out System.Double nearDistance,
    out System.Double farDistance
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetFrustumNearPlane(out Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetFrustumFarPlane(out Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetFrustumLeftPlane(out Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetFrustumRightPlane(out Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetFrustumBottomPlane(out Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual System.Boolean GetFrustumTopPlane(out Rhino.Geometry.Plane plane) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d[] GetNearRect() => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point3d[] GetFarRect() => throw new System.NotImplementedException();

  public virtual System.Boolean GetScreenPort(
    out System.Int32 portLeft,
    out System.Int32 portRight,
    out System.Int32 portBottom,
    out System.Int32 portTop,
    out System.Int32 portNear,
    out System.Int32 portFar
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetCameraAngle(
    out System.Double halfDiagonalAngle,
    out System.Double halfVerticalAngle,
    out System.Double halfHorizontalAngle
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Transform GetTransform(
    Rhino.DocObjects.CoordinateSystem sourceSystem,
    Rhino.DocObjects.CoordinateSystem destinationSystem
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetFrustumLine(
    System.Double screenX,
    System.Double screenY,
    out Rhino.Geometry.Line worldLine
  ) => throw new System.NotImplementedException();

  public virtual System.Boolean GetWorldToScreenScale(
    Rhino.Geometry.Point3d pointInFrustum,
    out System.Double pixelsPerUnit
  ) => throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Point2d WorldToClient(Rhino.Geometry.Point3d worldPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Point ClientToScreen(Rhino.Geometry.Point2d clientPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Point ClientToScreen(System.Drawing.Point clientPoint) =>
    throw new System.NotImplementedException();

  public virtual System.Drawing.Point ScreenToClient(System.Drawing.Point screenPoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line ClientToWorld(System.Drawing.Point clientPoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Geometry.Line ClientToWorld(Rhino.Geometry.Point2d clientPoint) =>
    throw new System.NotImplementedException();

  public virtual Rhino.Display.RhinoView ParentView
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Guid Id
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.UInt32 ChangeCounter
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Drawing.Size Size
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean LockedProjection
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String Name
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Point3d CameraTarget
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean ConstructionGridVisible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean ConstructionAxesVisible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean WorldAxesVisible
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.Boolean IsPlanView
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Int32 UserStringCount
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValidCamera
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsValidFrustum
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsPerspectiveProjection
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsTwoPointPerspectiveProjection
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean IsParallelProjection
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Point3d CameraLocation
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CameraDirection
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CameraUp
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual Rhino.Geometry.Vector3d CameraX
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CameraY
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Geometry.Vector3d CameraZ
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double FrustumAspect
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Drawing.Rectangle Bounds
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double ScreenPortAspect
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Double Camera35mmLensLength
  {
    get => throw new System.NotImplementedException();
    set { }
  }
  public virtual System.String WallpaperFilename
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean WallpaperGrayscale
  {
    get => throw new System.NotImplementedException();
  }
  public virtual System.Boolean WallpaperVisible
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Display.ViewportType ViewportType
  {
    get => throw new System.NotImplementedException();
  }
  public virtual Rhino.Display.DisplayModeDescription DisplayMode
  {
    get => throw new System.NotImplementedException();
    set { }
  }
}

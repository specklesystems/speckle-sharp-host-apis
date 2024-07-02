namespace Rhino.DocObjects;

public partial class ViewportInfo : Rhino.Runtime.CommonObject
{
	public ViewportInfo() {}
	public ViewportInfo(Rhino.DocObjects.ViewportInfo other) => throw new System.NotImplementedException();
	public ViewportInfo(Rhino.Display.RhinoViewport rhinoViewport) => throw new System.NotImplementedException();
	public static System.Double CalculateCameraRotationAngle(Rhino.Geometry.Vector3d direction,Rhino.Geometry.Vector3d up) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Vector3d CalculateCameraUpDirection(Rhino.Geometry.Point3d location,Rhino.Geometry.Vector3d direction,System.Double angle) => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeToParallelProjection(System.Boolean symmetricFrustum) => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeToPerspectiveProjection(System.Double targetDistance,System.Boolean symmetricFrustum,System.Double lensLength) => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeToTwoPointPerspectiveProjection(System.Double targetDistance,Rhino.Geometry.Vector3d up,System.Double lensLength) => throw new System.NotImplementedException();
	public virtual System.Boolean SetCameraLocation(Rhino.Geometry.Point3d location) => throw new System.NotImplementedException();
	public virtual System.Boolean SetCameraDirection(Rhino.Geometry.Vector3d direction) => throw new System.NotImplementedException();
	public virtual System.Boolean SetCameraUp(Rhino.Geometry.Vector3d up) => throw new System.NotImplementedException();
	public virtual void UnlockCamera() => throw new System.NotImplementedException();
	public virtual void UnlockFrustumSymmetry() => throw new System.NotImplementedException();
	public virtual System.Boolean SetFrustum(System.Double left,System.Double right,System.Double bottom,System.Double top,System.Double nearDistance,System.Double farDistance) => throw new System.NotImplementedException();
	public virtual System.Boolean SetFrustumNearFar(Rhino.Geometry.BoundingBox boundingBox) => throw new System.NotImplementedException();
	public virtual System.Boolean SetFrustumNearFar(Rhino.Geometry.Point3d center,System.Double radius) => throw new System.NotImplementedException();
	public virtual System.Boolean SetFrustumNearFar(System.Double nearDistance,System.Double farDistance) => throw new System.NotImplementedException();
	public virtual System.Boolean ChangeToSymmetricFrustum(System.Boolean isLeftRightSymmetric,System.Boolean isTopBottomSymmetric,System.Double targetDistance) => throw new System.NotImplementedException();
	public virtual System.Boolean SetFrustumNearFar(System.Double nearDistance,System.Double farDistance,System.Double minNearDistance,System.Double minNearOverFar,System.Double targetDistance) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d[] GetNearPlaneCorners() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d[] GetFarPlaneCorners() => throw new System.NotImplementedException();
	public virtual System.Boolean SetScreenPort(System.Int32 left,System.Int32 right,System.Int32 bottom,System.Int32 top,System.Int32 near,System.Int32 far) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Transform GetXform(Rhino.DocObjects.CoordinateSystem sourceSystem,Rhino.DocObjects.CoordinateSystem destinationSystem) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Line GetFrustumLine(System.Double screenX,System.Double screenY) => throw new System.NotImplementedException();
	public virtual System.Double GetWorldToScreenScale(Rhino.Geometry.Point3d pointInFrustum) => throw new System.NotImplementedException();
	public virtual System.Boolean Extents(System.Double halfViewAngleRadians,Rhino.Geometry.BoundingBox bbox) => throw new System.NotImplementedException();
	public virtual System.Boolean Extents(System.Double halfViewAngleRadians,Rhino.Geometry.Sphere sphere) => throw new System.NotImplementedException();
	public virtual System.Boolean ZoomToScreenRect(System.Int32 left,System.Int32 top,System.Int32 right,System.Int32 bottom) => throw new System.NotImplementedException();
	public virtual System.Boolean DollyCamera(Rhino.Geometry.Vector3d dollyVector) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Vector3d GetDollyCameraVector(System.Int32 screenX0,System.Int32 screenY0,System.Int32 screenX1,System.Int32 screenY1,System.Double projectionPlaneDistance) => throw new System.NotImplementedException();
	public virtual System.Boolean DollyFrustum(System.Double dollyDistance) => throw new System.NotImplementedException();
	public virtual System.Boolean DollyExtents(System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> geometry,System.Double border) => throw new System.NotImplementedException();
	public virtual System.Boolean DollyExtents(Rhino.Geometry.BoundingBox cameraCoordinateBoundingBox,System.Double border) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Point3d FrustumCenterPoint(System.Double targetDistance) => throw new System.NotImplementedException();
	public virtual System.Double TargetDistance(System.Boolean useFrustumCenterFallback) => throw new System.NotImplementedException();
	public virtual System.Boolean TransformCamera(Rhino.Geometry.Transform xform) => throw new System.NotImplementedException();
	public virtual System.Boolean RotateCamera(System.Double rotationAngleRadians,Rhino.Geometry.Vector3d rotationAxis,Rhino.Geometry.Point3d rotationCenter) => throw new System.NotImplementedException();
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
		set {}
	}
	public virtual System.Boolean IsParallelProjection
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsTwoPointPerspectiveProjection
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
	}
	public virtual System.Boolean IsCameraLocationLocked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsCameraDirectionLocked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsCameraUpLocked
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsFrustumLeftRightSymmetric
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean IsFrustumTopBottomSymmetric
	{
		get => throw new System.NotImplementedException();
		set {}
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
	public static  Rhino.Geometry.Vector3d DefaultCameraDirection
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumAspect
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point3d FrustumCenter
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumLeft
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumRight
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumBottom
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumTop
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumNear
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumFar
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumWidth
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumHeight
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumMinimumDiameter
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FrustumMaximumDiameter
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Plane FrustumNearPlane
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Plane FrustumFarPlane
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Plane FrustumLeftPlane
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Plane FrustumRightPlane
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Plane FrustumBottomPlane
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Plane FrustumTopPlane
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double ScreenPortAspect
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double CameraAngle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double Camera35mmLensLength
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point3d TargetPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PerspectiveMinNearOverFar
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double PerspectiveMinNearDist
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid Id
	{
		get => throw new System.NotImplementedException();
	}
}

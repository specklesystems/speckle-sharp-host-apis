namespace Rhino.Geometry;

public partial class Silhouette
{
	public Silhouette() {}
	public static Rhino.Geometry.Silhouette ComputeDraftCurve(Rhino.Geometry.GeometryBase geometry,System.Double draftAngle,Rhino.Geometry.Vector3d pullDirection,System.Double tolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Silhouette ComputeDraftCurve(Rhino.Geometry.GeometryBase geometry,System.Double draftAngle,Rhino.Geometry.Vector3d pullDirection,System.Double tolerance,System.Double angleToleranceRadians,System.Threading.CancellationToken cancelToken) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Silhouette Compute(Rhino.Geometry.GeometryBase geometry,Rhino.Geometry.SilhouetteType silhouetteType,Rhino.Geometry.Point3d perspectiveCameraLocation,System.Double tolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Silhouette Compute(Rhino.Geometry.GeometryBase geometry,Rhino.Geometry.SilhouetteType silhouetteType,Rhino.Geometry.Point3d perspectiveCameraLocation,System.Double tolerance,System.Double angleToleranceRadians,System.Collections.Generic.IEnumerable<Rhino.Geometry.Plane> clippingPlanes,System.Threading.CancellationToken cancelToken) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Silhouette Compute(Rhino.Geometry.GeometryBase geometry,Rhino.Geometry.SilhouetteType silhouetteType,Rhino.Geometry.Vector3d parallelCameraDirection,System.Double tolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Silhouette Compute(Rhino.Geometry.GeometryBase geometry,Rhino.Geometry.SilhouetteType silhouetteType,Rhino.Geometry.Vector3d parallelCameraDirection,System.Double tolerance,System.Double angleToleranceRadians,System.Collections.Generic.IEnumerable<Rhino.Geometry.Plane> clippingPlanes,System.Threading.CancellationToken cancelToken) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Silhouette Compute(Rhino.Geometry.GeometryBase geometry,Rhino.Geometry.SilhouetteType silhouetteType,Rhino.DocObjects.ViewportInfo viewport,System.Double tolerance,System.Double angleToleranceRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Silhouette Compute(Rhino.Geometry.GeometryBase geometry,Rhino.Geometry.SilhouetteType silhouetteType,Rhino.DocObjects.ViewportInfo viewport,System.Double tolerance,System.Double angleToleranceRadians,System.Collections.Generic.IEnumerable<Rhino.Geometry.Plane> clippingPlanes,System.Threading.CancellationToken cancelToken) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.SilhouetteType SilhouetteType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.ComponentIndex GeometryComponentIndex
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Curve Curve
	{
		get => throw new System.NotImplementedException();
	}
}

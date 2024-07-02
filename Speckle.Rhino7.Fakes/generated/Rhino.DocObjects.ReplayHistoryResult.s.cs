namespace Rhino.DocObjects;

public partial class ReplayHistoryResult
{
	public ReplayHistoryResult() {}
	public virtual System.Boolean UpdateToPoint(Rhino.Geometry.Point3d point,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToPointCloud(Rhino.Geometry.PointCloud cloud,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToPointCloud(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToClippingPlane(Rhino.Geometry.Plane plane,System.Double uMagnitude,System.Double vMagnitude,System.Guid clippedViewportId,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToClippingPlane(Rhino.Geometry.Plane plane,System.Double uMagnitude,System.Double vMagnitude,System.Collections.Generic.IEnumerable<System.Guid> clippedViewportIds,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToLinearDimension(Rhino.Geometry.LinearDimension dimension,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToRadialDimension(Rhino.Geometry.RadialDimension dimension,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToAngularDimension(Rhino.Geometry.AngularDimension dimension,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToLine(Rhino.Geometry.Point3d from,Rhino.Geometry.Point3d to,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToPolyline(System.Collections.Generic.IEnumerable<Rhino.Geometry.Point3d> points,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToArc(Rhino.Geometry.Arc arc,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToCircle(Rhino.Geometry.Circle circle,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToEllipse(Rhino.Geometry.Ellipse ellipse,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToSphere(Rhino.Geometry.Sphere sphere,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToCurve(Rhino.Geometry.Curve curve,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToTextDot(Rhino.Geometry.TextDot dot,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToText(System.String text,Rhino.Geometry.Plane plane,System.Double height,System.String fontName,System.Boolean bold,System.Boolean italic,Rhino.Geometry.TextJustification justification,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToText(Rhino.Geometry.TextEntity text,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToSurface(Rhino.Geometry.Surface surface,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToExtrusion(Rhino.Geometry.Extrusion extrusion,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToMesh(Rhino.Geometry.Mesh mesh,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToBrep(Rhino.Geometry.Brep brep,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToLeader(Rhino.Geometry.Leader leader,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual System.Boolean UpdateToHatch(Rhino.Geometry.Hatch hatch,Rhino.DocObjects.ObjectAttributes attributes) => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.RhinoObject ExistingObject
	{
		get => throw new System.NotImplementedException();
	}
}

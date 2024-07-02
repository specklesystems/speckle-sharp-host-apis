namespace Rhino.Geometry;

public partial class Squisher : System.IDisposable
{
	public Squisher() {}
	public virtual void Dispose() => throw new System.NotImplementedException();
	public static System.Boolean Is2dPatternSquished(Rhino.Geometry.GeometryBase geometry) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Mesh SquishMesh(Rhino.Geometry.SquishParameters sp,Rhino.Geometry.Mesh mesh3d,System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> marks,System.Collections.Generic.List<Rhino.Geometry.GeometryBase> squished_marks_out) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Mesh SquishMesh(Rhino.Geometry.SquishParameters sp,Rhino.Geometry.Mesh mesh3d) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep SquishSurface(Rhino.Geometry.SquishParameters sp,Rhino.Geometry.Surface surface,System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> marks,System.Collections.Generic.List<Rhino.Geometry.GeometryBase> squished_marks_out) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep SquishSurface(Rhino.Geometry.SquishParameters sp,Rhino.Geometry.Surface surface) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.PolylineCurve SquishCurve(Rhino.Geometry.Curve curve) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.TextDot SquishTextDot(Rhino.Geometry.TextDot textDot) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Mesh Get2dMesh() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Mesh Get3dMesh() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Line GetMesh2dEdges() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Line GetMesh3dEdges() => throw new System.NotImplementedException();
	public static System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> SquishBack2dMarks(Rhino.Geometry.GeometryBase squishedGeometry,System.Collections.Generic.IEnumerable<Rhino.Geometry.GeometryBase> marks) => throw new System.NotImplementedException();
}

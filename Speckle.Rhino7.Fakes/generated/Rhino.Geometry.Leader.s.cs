namespace Rhino.Geometry;

public partial class Leader : Rhino.Geometry.AnnotationBase
{
	public Leader() {}
	public static Rhino.Geometry.Leader Create(System.String text,Rhino.Geometry.Plane plane,Rhino.DocObjects.DimensionStyle dimstyle,Rhino.Geometry.Point3d[] points) => throw new System.NotImplementedException();
	public static Rhino.Geometry.Leader CreateWithRichText(System.String richText,Rhino.Geometry.Plane plane,Rhino.DocObjects.DimensionStyle dimstyle,Rhino.Geometry.Point3d[] points) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.NurbsCurve Curve
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Point2d[] Points2D
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point3d[] Points3D
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.TextHorizontalAlignment LeaderTextHorizontalAlignment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.TextVerticalAlignment LeaderTextVerticalAlignment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.ArrowType LeaderArrowType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid LeaderArrowBlockId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LeaderArrowSize
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.LeaderCurveStyle LeaderCurveStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.LeaderContentAngleStyle LeaderContentAngleStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean LeaderHasLanding
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LeaderLandingLength
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

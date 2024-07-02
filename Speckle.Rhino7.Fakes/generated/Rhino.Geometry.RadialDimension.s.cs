namespace Rhino.Geometry;

public partial class RadialDimension : Rhino.Geometry.Dimension
{
	public RadialDimension() {}
	public static Rhino.Geometry.RadialDimension Create(Rhino.DocObjects.DimensionStyle dimStyle,Rhino.Geometry.AnnotationType dimtype,Rhino.Geometry.Plane plane,Rhino.Geometry.Point3d centerpoint,Rhino.Geometry.Point3d radiuspoint,Rhino.Geometry.Point3d dimlinepoint) => throw new System.NotImplementedException();
	public virtual System.Boolean AdjustFromPoints(Rhino.Geometry.Plane plane,Rhino.Geometry.Point3d centerpoint,Rhino.Geometry.Point3d radiuspoint,Rhino.Geometry.Point3d dimlinepoint,System.Double rotationInPlane) => throw new System.NotImplementedException();
	public virtual System.String GetDistanceDisplayText(Rhino.UnitSystem unitsystem,Rhino.DocObjects.DimensionStyle style) => throw new System.NotImplementedException();
	public virtual System.Boolean IsDiameterDimension
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.Geometry.Point2d CenterPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point2d RadiusPoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point2d DimlinePoint
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Point2d KneePoint
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.TextHorizontalAlignment LeaderTextHorizontalAlignment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.ArrowType LeaderArrowType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double LeaderArrowSize
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Guid LeaderArrowBlockId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.LeaderCurveStyle LeaderCurveStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public override Rhino.DocObjects.TextOrientation TextOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public override Rhino.DocObjects.DimensionStyle.TextLocation TextLocation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public override Rhino.DocObjects.DimensionStyle.LeaderContentAngleStyle TextAngleType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

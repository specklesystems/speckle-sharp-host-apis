namespace Rhino.Geometry;

public partial class TextEntity : Rhino.Geometry.AnnotationBase
{
	public TextEntity() {}
	public static Rhino.Geometry.TextEntity Create(System.String text,Rhino.Geometry.Plane plane,Rhino.DocObjects.DimensionStyle style,System.Boolean wrapped,System.Double rectWidth,System.Double rotationRadians) => throw new System.NotImplementedException();
	public static Rhino.Geometry.TextEntity CreateWithRichText(System.String richTextString,Rhino.Geometry.Plane plane,Rhino.DocObjects.DimensionStyle style,System.Boolean wrapped,System.Double rectWidth,System.Double rotationRadians) => throw new System.NotImplementedException();
	public virtual System.Boolean Transform(Rhino.Geometry.Transform transform,Rhino.DocObjects.DimensionStyle style) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Transform GetTextTransform(System.Double textscale,Rhino.DocObjects.DimensionStyle dimstyle) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve Explode() => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep CreateSurfaces(Rhino.DocObjects.DimensionStyle dimstyle,System.Double smallCapsScale,System.Double spacing) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Brep CreatePolySurfaces(Rhino.DocObjects.DimensionStyle dimstyle,System.Double height,System.Double smallCapsScale,System.Double spacing) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Extrusion CreateExtrusions(Rhino.DocObjects.DimensionStyle dimstyle,System.Double height,System.Double smallCapsScale,System.Double spacing) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Curve CreateCurves(Rhino.DocObjects.DimensionStyle dimstyle,System.Boolean bAllowOpen,System.Double smallCapsScale,System.Double spacing) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.TextJustification Justification
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.TextHorizontalAlignment TextHorizontalAlignment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.TextVerticalAlignment TextVerticalAlignment
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.TextOrientation TextOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

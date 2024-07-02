namespace Rhino.Geometry;

public partial class AnnotationBase : Rhino.Geometry.GeometryBase
{
	public AnnotationBase() {}
	public virtual System.Boolean IsPropertyOverridden(Rhino.DocObjects.DimensionStyle.Field field) => throw new System.NotImplementedException();
	public virtual System.Boolean ClearPropertyOverrides() => throw new System.NotImplementedException();
	public virtual Rhino.DocObjects.DimensionStyle GetDimensionStyle(Rhino.DocObjects.DimensionStyle parentDimStyle) => throw new System.NotImplementedException();
	public virtual System.Boolean SetOverrideDimStyle(Rhino.DocObjects.DimensionStyle OverrideStyle) => throw new System.NotImplementedException();
	public static System.Double GetDimensionScale(Rhino.RhinoDoc doc,Rhino.DocObjects.DimensionStyle dimstyle,Rhino.Display.RhinoViewport vport) => throw new System.NotImplementedException();
	public static System.String PlainTextToRtf(System.String str) => throw new System.NotImplementedException();
	public virtual void SetRichText(System.String rtfText,Rhino.DocObjects.DimensionStyle dimstyle) => throw new System.NotImplementedException();
	public static System.String FormatRtfString(System.String rtf_in,System.Boolean clear_bold,System.Boolean set_bold,System.Boolean clear_italic,System.Boolean set_italic,System.Boolean clear_underline,System.Boolean set_underline,System.Boolean clear_facename,System.Boolean set_facename,System.String facename) => throw new System.NotImplementedException();
	public virtual System.Boolean IsAllBold() => throw new System.NotImplementedException();
	public virtual System.Boolean IsAllItalic() => throw new System.NotImplementedException();
	public virtual System.Boolean IsAllUnderlined() => throw new System.NotImplementedException();
	public virtual void WrapText() => throw new System.NotImplementedException();
	public virtual System.Boolean SetBold(System.Boolean set_on) => throw new System.NotImplementedException();
	public virtual System.Boolean SetItalic(System.Boolean set_on) => throw new System.NotImplementedException();
	public virtual System.Boolean SetUnderline(System.Boolean set_on) => throw new System.NotImplementedException();
	public virtual System.Boolean SetFacename(System.Boolean set_on,System.String facename) => throw new System.NotImplementedException();
	public virtual System.Boolean RunReplace(System.String replaceString,System.Int32 startRunIndex,System.Int32 startRunPosition,System.Int32 endRunIndex,System.Int32 endRunPosition) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.AnnotationType AnnotationType
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Guid DimensionStyleId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean HasPropertyOverrides
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.DimensionStyle DimensionStyle
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.DimensionStyle ParentDimensionStyle
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TextHeight
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean MaskEnabled
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean MaskUsesViewportColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.MaskType MaskColorSource
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean DrawTextFrame
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.MaskFrame MaskFrame
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Drawing.Color MaskColor
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double MaskOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double DimensionScale
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean DrawForward
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.Font Font
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Int32 FontIndex
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.LengthDisplay DimensionLengthDisplay
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.DimensionStyle.LengthDisplay AlternateDimensionLengthDisplay
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Char DecimalSeparator
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.Geometry.Plane Plane
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String TextFormula
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String RichText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Text
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String PlainText
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String PlainTextWithFields
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean TextHasRtfFormatting
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Rhino.DocObjects.Font FirstCharFont
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double TextModelWidth
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FormatWidth
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Boolean TextIsWrapped
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TextRotationRadians
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double TextRotationDegrees
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

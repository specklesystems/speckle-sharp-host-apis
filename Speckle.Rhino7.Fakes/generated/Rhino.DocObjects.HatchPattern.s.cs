namespace Rhino.DocObjects;

public partial class HatchPattern : Rhino.DocObjects.ModelComponent
{
	public HatchPattern() {}
	public static Rhino.DocObjects.HatchPattern[] ReadFromFile(System.String filename,System.Boolean quiet) => throw new System.NotImplementedException();
	public virtual Rhino.Geometry.Line[] CreatePreviewGeometry(System.Int32 width,System.Int32 height,System.Double angle) => throw new System.NotImplementedException();
	public virtual System.Boolean IsDeleted
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean IsReference
	{
		get => throw new System.NotImplementedException();
	}
	public new Rhino.DocObjects.ModelComponentType ComponentType
	{
		get => throw new System.NotImplementedException();
	}
	public new System.Int32 Index
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.String Description
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Rhino.DocObjects.HatchPatternFillType FillType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

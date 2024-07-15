namespace Autodesk.Revit.DB;

public partial class RoofBase : Autodesk.Revit.DB.HostObject
{
	public RoofBase() {}
	public virtual Autodesk.Revit.DB.SlabShapeEditor GetSlabShapeEditor() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.SlabShapeEditor SlabShapeEditor
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Double FasciaDepth
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.EaveCutterType EaveCuts
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.RoofType RoofType
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

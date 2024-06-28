namespace Autodesk.Revit.DB;

public partial class Part : Autodesk.Revit.DB.Element
{
	public virtual void ResetPartShape() => throw new System.NotImplementedException();
	public virtual void ResetFaceOffset(Autodesk.Revit.DB.Face face) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PartMaker PartMaker
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.ElementId OriginalCategoryId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

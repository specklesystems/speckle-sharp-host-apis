namespace Autodesk.Revit.DB;

public partial class Part : Autodesk.Revit.DB.Element
{
	public virtual System.Boolean CanOffsetFace(Autodesk.Revit.DB.Face face) => throw new System.NotImplementedException();
	public virtual void SetFaceOffset(Autodesk.Revit.DB.Face face,System.Double offset) => throw new System.NotImplementedException();
	public virtual System.Double GetFaceOffset(Autodesk.Revit.DB.Face face) => throw new System.NotImplementedException();
	public virtual void ResetPartShape() => throw new System.NotImplementedException();
	public virtual void ResetFaceOffset(Autodesk.Revit.DB.Face face) => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.LinkElementId> GetSourceElementIds() => throw new System.NotImplementedException();
	public virtual System.Collections.Generic.ICollection<Autodesk.Revit.DB.ElementId> GetSourceElementOriginalCategoryIds() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.PartMaker PartMaker
	{
		get => throw new System.NotImplementedException();
	}
	public virtual System.Boolean Excluded
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.ElementId OriginalCategoryId
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

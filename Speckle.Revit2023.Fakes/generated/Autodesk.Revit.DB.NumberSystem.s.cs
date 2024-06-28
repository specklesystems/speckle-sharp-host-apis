namespace Autodesk.Revit.DB;

public partial class NumberSystem : Autodesk.Revit.DB.Element
{
	public virtual Autodesk.Revit.DB.Reference GetReferencePick() => throw new System.NotImplementedException();
	public virtual void SetReferencePick(Autodesk.Revit.DB.Reference referencePick) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.NumberSystemJustifyOption JustifyOption
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.TagOrientation NumberOrientation
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.NumberSystemDisplayRule NumberDisplayRule
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual Autodesk.Revit.DB.LinkElementId NumberedElementId
	{
		get => throw new System.NotImplementedException();
	}
	public virtual Autodesk.Revit.DB.LinkElementId PlacementLevelId
	{
		get => throw new System.NotImplementedException();
	}
}

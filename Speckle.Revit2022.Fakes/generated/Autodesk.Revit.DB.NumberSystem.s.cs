namespace Autodesk.Revit.DB;

public partial class NumberSystem : Autodesk.Revit.DB.Element
{
	public NumberSystem() {}
	public virtual Autodesk.Revit.DB.Reference GetReferencePick() => throw new System.NotImplementedException();
	public virtual void SetReferencePick(Autodesk.Revit.DB.Reference referencePick) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.NumberSystem Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewId,Autodesk.Revit.DB.LinkElementId hostElementId,Autodesk.Revit.DB.Architecture.StairsNumberSystemReferenceOption referenceOption,Autodesk.Revit.DB.LinkElementId placementLevelId) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.NumberSystem Create(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.ElementId viewId,Autodesk.Revit.DB.LinkElementId numberedElementId,Autodesk.Revit.DB.Reference referenceCurve) => throw new System.NotImplementedException();
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
	public virtual System.Double JustifyOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
	public virtual System.Double ReferenceOffset
	{
		get => throw new System.NotImplementedException();
		set {}
	}
}

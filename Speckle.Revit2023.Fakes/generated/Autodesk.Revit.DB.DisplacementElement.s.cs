namespace Autodesk.Revit.DB;

public partial class DisplacementElement : Autodesk.Revit.DB.Element
{
	public static Autodesk.Revit.DB.DisplacementElement Create(Autodesk.Revit.DB.Document document,ICollection<Autodesk.Revit.DB.ElementId> elementsToDisplace,Autodesk.Revit.DB.XYZ displacement,Autodesk.Revit.DB.View ownerDBView,Autodesk.Revit.DB.DisplacementElement parentDisplacementElement) => throw new System.NotImplementedException();
	public virtual void ResetDisplacedElements() => throw new System.NotImplementedException();
	public static System.Boolean IsElementDisplacedInView(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public static Autodesk.Revit.DB.ElementId GetDisplacementElementId(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.ElementId id) => throw new System.NotImplementedException();
	public static System.Boolean CanCategoryBeDisplaced(Autodesk.Revit.DB.ElementId categoryId) => throw new System.NotImplementedException();
	public static System.Boolean IsAllowedAsDisplacedElement(Autodesk.Revit.DB.Element element) => throw new System.NotImplementedException();
	public static System.Boolean IsValidAsParentInView(Autodesk.Revit.DB.View view,Autodesk.Revit.DB.DisplacementElement parent) => throw new System.NotImplementedException();
	public static System.Boolean CanElementsBeDisplaced(Autodesk.Revit.DB.View view,ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public static ICollection<Autodesk.Revit.DB.ElementId> GetAdditionalElementsToDisplace(Autodesk.Revit.DB.Document document,Autodesk.Revit.DB.View view,Autodesk.Revit.DB.ElementId idToDisplace) => throw new System.NotImplementedException();
	public static System.Boolean IsNotEmpty(ICollection<Autodesk.Revit.DB.ElementId> elementIds) => throw new System.NotImplementedException();
	public static ICollection<Autodesk.Revit.DB.ElementId> GetDisplacementElementIds(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetDisplacedElementIds() => throw new System.NotImplementedException();
	public static ICollection<Autodesk.Revit.DB.ElementId> GetDisplacedElementIds(Autodesk.Revit.DB.View view) => throw new System.NotImplementedException();
	public virtual ICollection<Autodesk.Revit.DB.ElementId> GetDisplacedElementIdsFromAllChildren() => throw new System.NotImplementedException();
	public virtual void SetDisplacedElementIds(ICollection<Autodesk.Revit.DB.ElementId> displacedElemIds) => throw new System.NotImplementedException();
	public virtual System.Boolean CanElementsBeAddedToDisplacementSet(ICollection<Autodesk.Revit.DB.ElementId> toDisplace) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetRelativeDisplacement() => throw new System.NotImplementedException();
	public virtual void SetRelativeDisplacement(Autodesk.Revit.DB.XYZ displacement) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetAbsoluteDisplacement() => throw new System.NotImplementedException();
	public virtual void RemoveDisplacedElement(Autodesk.Revit.DB.Element ElemToRemove) => throw new System.NotImplementedException();
	public virtual IList<Autodesk.Revit.DB.DisplacementElement> GetChildren() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId ParentId
	{
		get => throw new System.NotImplementedException();
	}
}

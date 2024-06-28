namespace Autodesk.Revit.DB;

public partial class DisplacementElement : Autodesk.Revit.DB.Element
{
	public virtual void ResetDisplacedElements() => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetRelativeDisplacement() => throw new System.NotImplementedException();
	public virtual void SetRelativeDisplacement(Autodesk.Revit.DB.XYZ displacement) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.XYZ GetAbsoluteDisplacement() => throw new System.NotImplementedException();
	public virtual void RemoveDisplacedElement(Autodesk.Revit.DB.Element ElemToRemove) => throw new System.NotImplementedException();
	public virtual Autodesk.Revit.DB.ElementId ParentId
	{
		get => throw new System.NotImplementedException();
	}
}
